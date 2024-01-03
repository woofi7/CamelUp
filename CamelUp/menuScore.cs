using CamelUp.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CamelUp
{
    public partial class MenuScore : Form
    {
        private readonly CamelColor _camelFirst;
        private readonly CamelColor _camelLast;
        private readonly Player[] _players;
        private readonly Form1 _form;

        public MenuScore(CamelColor camelFirst, CamelColor camelLast, Player[] players, Form1 form) {
            _players = players;
            _camelFirst = camelFirst;
            _camelLast = camelLast;
            _form = form;

            InitializeComponent();
            SetCamelImages();
            InitializeInfos();
            
            PctCamelWin.Controls.Add(PctCamelLose);
            PctCamelLose.Location = new Point(0, 0);
        }

        private void InitializeInfos()
        {
            foreach (Player player in _players)
            {
                foreach (CamelColor color in player.WinnerBet)
                {
                    if (color == _camelFirst)
                    {
                        player.Score += 5;
                    }
                    else
                    {
                        player.Score -= 1;
                    }
                }

                foreach (CamelColor color in player.LoserBet)
                {
                    if (color == _camelLast)
                    {
                        player.Score += 5;
                    }
                    else
                    {
                        player.Score -= 1;
                    }
                }
            }

            LblPlayer1.Text = _players[0].Name;
            LblPlayer1Score.Text = _players[0].Score + "";

            LblPlayer2.Text = _players[1].Name;
            LblPlayer2Score.Text = _players[1].Score + "";

            LblPlayer3.Text = _players[2].Name;
            LblPlayer3Score.Text = _players[2].Score + "";

            LblPlayer4.Text = _players[3].Name;
            LblPlayer4Score.Text = _players[3].Score + "";

            int[] playersScore = new int[_players.Length];

            for (int i = 0; i < _players.Length; i++)
            {
                playersScore[i] = _players[i].Score;
            }

            Array.Sort(playersScore);

            if (LblPlayer1Score.Text.Equals(playersScore[3] + ""))
                PctPlayer1Medal.Image = Resources.Player_Rank_1;
            if (LblPlayer2Score.Text.Equals(playersScore[3] + ""))
                PctPlayer2Medal.Image = Resources.Player_Rank_1;
            if (LblPlayer3Score.Text.Equals(playersScore[3] + ""))
                PctPlayer3Medal.Image = Resources.Player_Rank_1;
            if (LblPlayer4Score.Text.Equals(playersScore[3] + ""))
                PctPlayer4Medal.Image = Resources.Player_Rank_1;

            if (LblPlayer1Score.Text.Equals(playersScore[2] + ""))
                PctPlayer1Medal.Image = Resources.Player_Rank_2;
            if (LblPlayer2Score.Text.Equals(playersScore[2] + ""))
                PctPlayer2Medal.Image = Resources.Player_Rank_2;
            if (LblPlayer3Score.Text.Equals(playersScore[2] + ""))
                PctPlayer3Medal.Image = Resources.Player_Rank_2;
            if (LblPlayer4Score.Text.Equals(playersScore[2] + ""))
                PctPlayer4Medal.Image = Resources.Player_Rank_2;

            if (LblPlayer1Score.Text.Equals(playersScore[1] + ""))
                PctPlayer1Medal.Image = Resources.Player_Rank_3;
            if (LblPlayer2Score.Text.Equals(playersScore[1] + ""))
                PctPlayer2Medal.Image = Resources.Player_Rank_3;
            if (LblPlayer3Score.Text.Equals(playersScore[1] + ""))
                PctPlayer3Medal.Image = Resources.Player_Rank_3;
            if (LblPlayer4Score.Text.Equals(playersScore[1] + ""))
                PctPlayer4Medal.Image = Resources.Player_Rank_3;
        }

        private void SetCamelImages()
        {
            switch (_camelFirst)
            {
                case CamelColor.Blue:
                    PctCamelWin.Image = Resources.Camel_Winner_Blue;
                    break;
                case CamelColor.Green:
                    PctCamelWin.Image = Resources.Camel_Winner_Green;
                    break;
                case CamelColor.Yellow:
                    PctCamelWin.Image = Resources.Camel_Winner_Yellow;
                    break;
                case CamelColor.White:
                    PctCamelWin.Image = Resources.Camel_Winner_White;
                    break;
                case CamelColor.Orange:
                    PctCamelWin.Image = Resources.Camel_Winner_Orange;
                    break;
            }

            switch (_camelLast)
            {
                case CamelColor.Blue:
                    PctCamelLose.Image = Resources.Camel_Loser_Blue;
                    break;
                case CamelColor.Green:
                    PctCamelLose.Image = Resources.Camel_Loser_Green;
                    break;
                case CamelColor.Yellow:
                    PctCamelLose.Image = Resources.Camel_Loser_Yellow;
                    break;
                case CamelColor.White:
                    PctCamelLose.Image = Resources.Camel_Loser_White;
                    break;
                case CamelColor.Orange:
                    PctCamelLose.Image = Resources.Camel_Loser_Orange;
                    break;
            }

        }

        private void LblQuitter_Click(object sender, EventArgs e)
        {
            _form.Close();
        }

        private void LblNewGame_Click(object sender, EventArgs e)
        {
            _form.menu.newGame(_form);
            Close();
        }
    }
}
