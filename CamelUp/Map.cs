using CamelUp.Properties;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CamelUp {
    public class Map {
        public Cell[] MapCells = new Cell[16];
        protected Card[,] CardsArray = new Card[5, 3];
        public LinkedList<Camel> CamelPlaces = new LinkedList<Camel>();
        public int Round = 0;
        private readonly Form1 _form;

        public Map (Form1 form, Cell[] cells) {
            MapCells = cells;
            _form = form;

            for(int i = 0; i < cells.Length; i++) {
                cells[i].Id = i;
            }
        }

        /// <summary>
        /// Créer les cases de la carte et y ajouter les éléments de base. Les chameaux et les
        /// cases spéciales.
        /// </summary>
        public void CreateMap() {

            Random rnd = new Random();
            int desertCell = rnd.Next(16);
            int oasisCell = rnd.Next(16);
            while(desertCell == 0 || desertCell == 14 || desertCell == 15) {
                desertCell = rnd.Next(16);
            }
            while(oasisCell == 0 || oasisCell == 14 || oasisCell == 15 || oasisCell == desertCell || desertCell - 1 == oasisCell || desertCell + 1 == oasisCell) {
                oasisCell = rnd.Next(16);
            }

            SetSpecialCell(desertCell, CellType.Desert);
            SetSpecialCell(oasisCell, CellType.Oasis);
            SetSpecialCell(15, CellType.Start);

            SetNewCamels(15);
        }

        /// <summary>
        /// Ajouter les cartes de mise de la ronde en cours.
        /// </summary>
        /// <param name="panel"></param>
        public void AddCards(Panel panel) {
            int x = 1;
            int y = 0;

            for(int i = 0; i < 5; i++) {
                for(int j = 0; j < 3; j++) {
                    var card = new Card(j, i)
                    {
                        Location = new System.Drawing.Point(x, y),
                        Name = "card" + i + "" + j
                    };

                    panel.Controls.Add(card);
                    card.BringToFront();

                    card.Click += CardClick;

                    CardsArray[i, j] = card;
                }
                x += 94;
            }
        }

        public void ResetCards()
        {
            foreach (Card card in CardsArray)
            {
                card.Visible = true;
            }
        }

        /// <summary>
        /// Événement du clic des cartes de mise de la ronde en cours.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CardClick(object sender, EventArgs e) {
            Card card = (Card)sender;
            _form.AddPlayerCard(card);
            card.Visible = false;
        }

        /// <summary>
          /// Déplacer le chameau de la couleur et du nombre de cases spécifié en argument.
        /// </summary>
        /// <param name="element">La couleur et le nombre de cases à avancer.</param>
        public void MoveCamel(Tuple<CamelColor, int> element) {
            int camel = FindCamel(element.Item1);
            MapCells[camel].MoveCamel(MapCells, element.Item2, element.Item1, Round);
            UpdateMap();

            if(Round >= 4) {
                if (MapCells[0].CamelStack.Count > 0) {
                    _form.Win(0);
                } else if(MapCells[1].CamelStack.Count > 0) {
                    _form.Win(1);
                } else if(MapCells[2].CamelStack.Count > 0) {
                    _form.Win(2);
                } else if(MapCells[3].CamelStack.Count > 0) {
                    _form.Win(3);
                }
            }
        }

        /// <summary>
        /// Identifier l'emplacement d'un chameau de la couleur spécifié en argument.
        /// </summary>
        /// <param name="couleur">Couleur du chameau.</param>
        /// <returns>Le numéro de la case où se trouve le chameau.</returns>
        private int FindCamel(CamelColor couleur) {
            for(int i = 0; i < MapCells.Length; i++) {
                if(MapCells[i].CheckChameauPresent(couleur)) {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Mettre à jour les éléments de l'interface graphique.
        /// </summary>
        public void UpdateMap()
        {
            foreach (Cell cell in MapCells)
            {
                if (cell.Controls.Count > 0)
                {
                    cell.Controls.Clear();
                }

                Panel panel = cell.GetChameauPresentPanel();
                cell.Controls.Add(panel);
            }
        }

        /// <summary>
        /// Ajouter les 5 couleurs de chameau dans la case spécifié en argument.
        /// </summary>
        /// <param name="cell"></param>
        private void SetNewCamels(int cell) {
            MapCells[cell].CamelStack.Push(new Camel(CamelColor.White));
            MapCells[cell].CamelStack.Push(new Camel(CamelColor.Orange));
            MapCells[cell].CamelStack.Push(new Camel(CamelColor.Blue));
            MapCells[cell].CamelStack.Push(new Camel(CamelColor.Yellow));
            MapCells[cell].CamelStack.Push(new Camel(CamelColor.Green));

            UpdateMap();
        }

        /// <summary>
        /// Mettre un Type de case spécial à la case spécifié en argument.
        /// </summary>
        /// <param name="cell">Case à changer le Type.</param>
        /// <param name="cellType">Nouveau Type de la case.</param>
        private void SetSpecialCell(int cell, CellType cellType) {
            if(cellType == CellType.Desert) {
                MapCells[cell].Image = Resources.desert;
                MapCells[cell].Type = CellType.Desert;
            } else if(cellType == CellType.Oasis) {
                MapCells[cell].Image = Resources.oasis;
                MapCells[cell].Type = CellType.Oasis;
            } else if(cellType == CellType.Start) {
                MapCells[cell].Type = CellType.Start;
            }
        }


        /// <summary>
        /// Calculer la position des chameaux dans la course.
        /// </summary>
        public void ComputeCamelRacePlace(){
            CamelPlaces.Clear();

            for (int i = 0; i < MapCells.Length; i++) {
                if(Round == 0 && i == 15) {
                    continue;
                }

                Camel[] camelPlacesCell = MapCells[i].GetPresentCamelArray();
                
                for (int j = camelPlacesCell.Length - 1; j >= 0; j--) {
                    CamelPlaces.AddFirst(camelPlacesCell[j]);
                }
            }
        }
    }
}
