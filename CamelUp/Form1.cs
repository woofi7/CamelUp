using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CamelUp {
    public partial class Form1:Form {
        public Player[] Players = new Player[4];
        private readonly Dice _dices = new Dice();
        private readonly Map _map;
        private BetMenu _winnerMenu;
        private BetMenu _loserMenu;

        private int _actualPlayer;
        private int _time;
        public MainMenu menu;

        public Form1(MainMenu menu) {
            this.menu = menu;
            InitializeComponent();

            Cell[] mapCells = new Cell[16];
            mapCells[0] = LblCase0;
            mapCells[1] = LblCase1;
            mapCells[2] = LblCase2;
            mapCells[3] = LblCase3;
            mapCells[4] = LblCase4;
            mapCells[5] = LblCase5;
            mapCells[6] = LblCase6;
            mapCells[7] = LblCase7;
            mapCells[8] = LblCase8;
            mapCells[9] = LblCase9;
            mapCells[10] = LblCase10;
            mapCells[11] = LblCase11;
            mapCells[12] = LblCase12;
            mapCells[13] = LblCase13;
            mapCells[14] = LblCase14;
            mapCells[15] = LblCase15;
            _map = new Map(this, mapCells);

            StartNewGame();
        }

        public void LoserBet(CamelColor camelColor) {
            Players[_actualPlayer].LoserBet.Add(camelColor);
            NextPlayer();
        }

        public void WinnerBet(CamelColor camelColor) {
            Players[_actualPlayer].WinnerBet.Add(camelColor);
            NextPlayer();
        }

        /// <summary>
        /// Ajouter les joueurs.
        /// </summary>
        public void AddPlayer(String name, int player) {
            if(player == 0) {
                Players[0] = new Player(name);
                LblPlayerName1.Text = Players[0].Name;
                LblPlayer1.Text = Players[0].Name;
                LblPlayer1.ForeColor = Color.Red;
            }
            else if(player == 1) {
                Players[1] = new Player(name);
                LblPlayerName2.Text = Players[1].Name;
                LblPlayer2.Text = Players[1].Name;
            }
            else if(player == 2) {
                Players[2] = new Player(name);
                LblPlayerName3.Text = Players[2].Name;
                LblPlayer3.Text = Players[2].Name;
            }
            else if(player == 3) {
                Players[3] = new Player(name);
                LblPlayerName4.Text = Players[3].Name;
                LblPlayer4.Text = Players[3].Name;
            }
        }

        /// <summary>
        /// Préparer les éléments pour démarrer une nouvelle partie.
        /// </summary>
        public void StartNewGame() {
            _map.CreateMap();
            _map.AddCards(PnlCartes);
            
            Tmr1.Start();
            _actualPlayer = 0;
        }

        /// <summary>
        /// Mettre à jour le panel des joueurs.
        /// </summary>
        private void UpdateAllPlayersPanel() {
            UpdatePlayerPanel(PnlPlayerCards1, 0);
            UpdatePlayerPanel(PnlPlayerCards2, 1);
            UpdatePlayerPanel(PnlPlayerCards3, 2);
            UpdatePlayerPanel(PnlPlayerCards4, 3);
        }

        public void Win(int cell) {
            Camel firstCamel = _map.MapCells[cell].CamelStack.Pop();
            Camel lastCamel = null;
            int count = 0;

            while (true)
            {
                while (_map.MapCells[cell].CamelStack.Count > 0)
                {
                    lastCamel = _map.MapCells[cell].CamelStack.Pop();
                    count++;
                }
                if (count == 4)
                {
                    break;
                }

                cell--;

                if (cell == -1)
                {
                    cell = 15;
                }
            }

            Hide();
            if (lastCamel != null)
            {
                MenuScore score = new MenuScore(firstCamel.CamelColor, lastCamel.CamelColor, Players, this);
                score.Show();
            }
        }

        private void UpdatePlayerPanel(Panel panel, int id) {
            int nbElements = panel.Controls.Count - 1;

            if(nbElements < Players[id].CardsList.Count) {
                List<Label> cardsLabel = Players[id].GetCardsLabel(nbElements, _map.CamelPlaces);

                if(cardsLabel != null) {
                    int x = 0;
                    int y = 0;

                    for(int i = 0; i < nbElements; i++) {
                        x += 31;
                        if(x >= 95) {
                            x = 0;
                            y += 47;
                        }
                    }

                    foreach(Label label in cardsLabel) {
                        label.Location = new Point(x, y);
                        panel.Controls.Add(label);

                        x += 31;
                        if(x >= 95) {
                            x = 0;
                            y += 47;
                        }
                    }
                }
            }
            
            int[] cardsInfos = Players[id].GetCardsInfos(nbElements, _map.CamelPlaces);

            int count = 0;
            foreach(Control item in panel.Controls) {
                if(count > 0) {
                    int value = cardsInfos[count - 1];

                     if(value > 0) {
                        item.ForeColor = Color.Lime;
                    } else if(value == 0) {
                        item.ForeColor = Color.White;
                    } else {
                        value = Math.Abs(value);
                        item.ForeColor = Color.Red;
                    }
                    item.Text = value + "";
                }
                count++;
            }
        }

        /// <summary>
        /// Mettre à jour le panel des informations.
        /// </summary>
        private void UpdateInfosPanel() {
            if(_map.CamelPlaces.Count > 1) {
                switch(_map.CamelPlaces.First().CamelColor) {
                    case CamelColor.Blue:
                    LblFirstPlaceInfo.Text = "Bleu";
                    LblFirstPlaceInfo.ForeColor = Color.Blue;
                    break;
                    case CamelColor.Green:
                    LblFirstPlaceInfo.Text = "Vert";
                    LblFirstPlaceInfo.ForeColor = Color.Green;
                    break;
                    case CamelColor.Yellow:
                    LblFirstPlaceInfo.Text = "Jaune";
                    LblFirstPlaceInfo.ForeColor = Color.Yellow;
                    break;
                    case CamelColor.White:
                    LblFirstPlaceInfo.Text = "Blanc";
                    LblFirstPlaceInfo.ForeColor = Color.White;
                    break;
                    case CamelColor.Orange:
                    LblFirstPlaceInfo.Text = "Orange";
                    LblFirstPlaceInfo.ForeColor = Color.Orange;
                    break;
                }

                switch(_map.CamelPlaces.Last().CamelColor) {
                    case CamelColor.Blue:
                    LblLastPlaceInfo.Text = "Bleu";
                    LblLastPlaceInfo.ForeColor = Color.Blue;
                    break;
                    case CamelColor.Green:
                    LblLastPlaceInfo.Text = "Vert";
                    LblLastPlaceInfo.ForeColor = Color.Green;
                    break;
                    case CamelColor.Yellow:
                    LblLastPlaceInfo.Text = "Jaune";
                    LblLastPlaceInfo.ForeColor = Color.Yellow;
                    break;
                    case CamelColor.White:
                    LblLastPlaceInfo.Text = "Blanc";
                    LblLastPlaceInfo.ForeColor = Color.White;
                    break;
                    case CamelColor.Orange:
                    LblLastPlaceInfo.Text = "Orange";
                    LblLastPlaceInfo.ForeColor = Color.Orange;
                    break;
                }
            }

            LblRoundNum.Text = (_map.Round + 1) + "";
            LblPlayer1Score.Text = Players[0].Score + "";
            LblPlayer2Score.Text = Players[1].Score + "";
            LblPlayer3Score.Text = Players[2].Score + "";
            LblPlayer4Score.Text = Players[3].Score + "";

            switch(_actualPlayer) {
                case 0:
                LblPlayer1.ForeColor = Color.Red;
                LblPlayer2.ForeColor = Color.White;
                LblPlayer3.ForeColor = Color.White;
                LblPlayer4.ForeColor = Color.White;
                break;
                case 1:
                LblPlayer1.ForeColor = Color.White;
                LblPlayer2.ForeColor = Color.Red;
                LblPlayer3.ForeColor = Color.White;
                LblPlayer4.ForeColor = Color.White;
                break;
                case 2:
                LblPlayer1.ForeColor = Color.White;
                LblPlayer2.ForeColor = Color.White;
                LblPlayer3.ForeColor = Color.Red;
                LblPlayer4.ForeColor = Color.White;
                break;
                case 3:
                LblPlayer1.ForeColor = Color.White;
                LblPlayer2.ForeColor = Color.White;
                LblPlayer3.ForeColor = Color.White;
                LblPlayer4.ForeColor = Color.Red;
                break;
            }
        }

        /// <summary>
        /// Tirer un nouveau dé et faire avancer les chameaux.
        /// </summary>
        private void DrawDice() {
            Tuple<CamelColor, int> diceInfos = _dices.DrawDice();

            switch(diceInfos.Item1) {
                case CamelColor.Blue:
                    LblDiceB.Text = diceInfos.Item2 + "";
                    break;
                case CamelColor.Green:
                    LblDiceG.Text = diceInfos.Item2 + "";
                    break;
                case CamelColor.Yellow:
                    LblDiceY.Text = diceInfos.Item2 + "";
                    break;
                case CamelColor.White:
                    LblDiceW.Text = diceInfos.Item2 + "";
                    break;
                case CamelColor.Orange:
                    LblDiceO.Text = diceInfos.Item2 + "";
                    break;
            }

            _map.MoveCamel(diceInfos);
            _map.ComputeCamelRacePlace();

            AddPlayerCard(new Card(-1, 5));
        }

        private void NextPlayer() {
            _actualPlayer++;
            if(_actualPlayer == 4) {
                _actualPlayer = 0;
            }
            UpdateAllPlayersPanel();
            UpdateInfosPanel();

            if(_dices.DicesCount == 5) {
                NouvelleRonde();
            }
        }

        /// <summary>
        /// Ajouter une carte aux cartes du joueur.
        /// </summary>
        /// <param name="card"></param>
        public void AddPlayerCard(Card card) {
            Players[_actualPlayer].AddCard(card);
            NextPlayer();
        }




        private void NouvelleRonde() {
            _map.Round++;
            _dices.Reset();
            _map.ResetCards();

            LblDiceB.ResetText();
            LblDiceG.ResetText();
            LblDiceY.ResetText();
            LblDiceW.ResetText();
            LblDiceO.ResetText();

            Players[0].ComputeScore(_map.CamelPlaces);
            Players[1].ComputeScore(_map.CamelPlaces);
            Players[2].ComputeScore(_map.CamelPlaces);
            Players[3].ComputeScore(_map.CamelPlaces);

            Players[0].CardsList.Clear();
            Players[1].CardsList.Clear();
            Players[2].CardsList.Clear();
            Players[3].CardsList.Clear();

            var size = PnlPlayerCards1.Controls.Count;
            for(int i = 1; i < size; i++) {
                PnlPlayerCards1.Controls.RemoveAt(1);
            }
            size = PnlPlayerCards2.Controls.Count;
            for(int i = 1; i < size; i++) {
                PnlPlayerCards2.Controls.RemoveAt(1);
            }
            size = PnlPlayerCards3.Controls.Count;
            for(int i = 1; i < size; i++) {
                PnlPlayerCards3.Controls.RemoveAt(1);
            }
            size = PnlPlayerCards4.Controls.Count;
            for(int i = 1; i < size; i++) {
                PnlPlayerCards4.Controls.RemoveAt(1);
            }

            UpdateInfosPanel();
        }




        private void PctFirst_Down(object sender, MouseEventArgs e) {
            PctFirst.Location = new Point(
                PctFirst.Location.X - 1,
                PctFirst.Location.Y + 1
            );
        }

        private void PctFirst_Up(object sender, MouseEventArgs e) {
            PctFirst.Location = new Point(
                PctFirst.Location.X + 1,
                PctFirst.Location.Y - 1
            );
        }

        private void PctLast_Down(object sender, MouseEventArgs e) {
            PctLast.Location = new Point(
                PctLast.Location.X - 1,
                PctLast.Location.Y + 1
            );
        }

        private void PctLast_Up(object sender, MouseEventArgs e) {
            PctLast.Location = new Point(
                PctLast.Location.X + 1,
                PctLast.Location.Y - 1
            );
        }

        private void PnlPyramide_Down(object sender, MouseEventArgs e) {
            DrawDice();
        }

        private void Tmr1_Tick(object sender, EventArgs e) {
            String secondsStr;
            String minutesStr;

            var minutes = _time / 60;
            var seconds = _time - minutes * 60;

            if(seconds < 10) {
                secondsStr = "0" + seconds;
            }
            else {
                secondsStr = "" + seconds;
            }
            if(minutes < 10) {
                minutesStr = "0" + minutes;
            } else {
                minutesStr = "" + minutes;
            }

            LblTimer.Text = minutesStr + ":" + secondsStr;

            _time++;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            menu.Close();
        }

        private void PctFirst_Click(object sender, EventArgs e)
        {
            _winnerMenu = new BetMenu(this, true, Players[_actualPlayer].WinnerBet);
            _winnerMenu.Show();
            Visible = false;
        }

        private void PctLast_Click(object sender, EventArgs e)
        {
            _loserMenu = new BetMenu(this, false, Players[_actualPlayer].LoserBet);
            _loserMenu.Show();
            Visible = false;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nouvellePartieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menu.newGame(this);
        }

        private void àProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nicolas Signori, 19-03-2017", "À propos");
        }
    }
}
