using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CamelUp {
    public class Cell : Label {
        public Stack<Camel> CamelStack = new Stack<Camel>();
        public int Id;
        public CellType Type;

        public Cell() {
            Type = CellType.Normal;
        }

        /// <summary>
        /// Cherche si le chameau de la couleur spécifié en paramètre est présent sur la case. Si 
        /// celui-ci est présent, le prendre en l'avant sur la case spécifié par l'argument passé
        /// en paramètre.
        /// </summary>
        /// <param name="cells">L'ensemble des cases de la carte</param>
        /// <param name="moving">Nombre de cases que le chameau doit avancer</param>
        /// <param name="camelColor">Couleur du chameau à avancer</param>
        /// <param name="round"></param>
        public void MoveCamel(Cell[] cells, int moving, CamelColor camelColor, int round) {
            Stack<Camel> tmpCamelStack = new Stack<Camel>();

            bool found = false;
            while(!found && CamelStack.Count > 0) {
                Camel camel = CamelStack.Pop();
                if(Id + moving > 15) {
                    moving = -(Id - (Id + moving - 16));
                }

                tmpCamelStack.Push(camel);
                if(camel.CamelColor == camelColor) {
                    if(Type == CellType.Start && round < 2) {
                        Stack<Camel> camelStackStart = new Stack<Camel>();
                        camelStackStart.Push(tmpCamelStack.Pop());

                        while(tmpCamelStack.Count > 0) {
                            CamelStack.Push(tmpCamelStack.Pop());
                        }
                        tmpCamelStack = camelStackStart;
                    }

                    if(cells[Id + moving].Type == CellType.Normal || cells[Id + moving].Type == CellType.Start) {
                        MoveFoward(cells, moving, tmpCamelStack);
                    } else if(cells[Id + moving].Type == CellType.Desert) {
                        MovingBackward(cells, moving - 1, tmpCamelStack);
                    } else if(cells[Id + moving].Type == CellType.Oasis) {
                        MoveFoward(cells, moving + 1, tmpCamelStack);
                    }
                    found = true;
                }
            }

            if(!found) {
                while(tmpCamelStack.Count > 0) {
                    CamelStack.Push(tmpCamelStack.Pop());
                }
            }
        }

        /// <summary>
        /// Ajouter le chameau sur le dessus de la pile de chameau présent sur la case spécifié
        /// en paramètre.
        /// </summary>
        /// <param name="cells">L'ensemble des cases de la carte</param>
        /// <param name="moving">Nombre de cases que le chameau doit avancer</param>
        /// <param name="tmpCamelStack">Chameaux à ajouter à la case</param>
        public void MoveFoward(Cell[] cells, int moving, Stack<Camel> tmpCamelStack) {
            if(Id + moving > 15) {
                throw new IndexOutOfRangeException();
            }

            foreach(Camel camel in tmpCamelStack) {
                cells[Id + moving].CamelStack.Push(camel);
            }
        }

        /// <summary>
        /// Ajouter le chameau sous la pile de chameau présent sur la case spécifié en paramètre.
        /// </summary>
        /// <param name="cells">L'ensemble des cases de la carte</param>
        /// <param name="moving">Nombre de cases que le chameau doit avancer</param>
        /// <param name="tmpCamelStack">Chameaux à ajouter à la case</param>
        public void MovingBackward(Cell[] cells, int moving, Stack<Camel> tmpCamelStack) {
            if(Id + moving < 0) {
                throw new IndexOutOfRangeException();
            }

            Stack<Camel> camelStackTmp = new Stack<Camel>();

            while(cells[Id + moving].CamelStack.Count > 0) {
                camelStackTmp.Push(cells[Id + moving].CamelStack.Pop());
            }

            foreach(Camel chameau in tmpCamelStack) {
                cells[Id + moving].CamelStack.Push(chameau);
            }

            foreach(Camel chameau in camelStackTmp) {
                cells[Id + moving].CamelStack.Push(chameau);
            }
        }

        /// <summary>
        /// Récupérer les chameaux présent sur la case.
        /// </summary>
        /// <returns></returns>
        public Panel GetChameauPresentPanel() {
            Panel panel = new Panel();
            Stack<Camel> tmpStack = new Stack<Camel>();

            panel.BackColor = Color.Transparent;
            panel.Size = new Size(42, 50);
            panel.Location = new Point(25, 10);

            foreach (Camel chameau in CamelStack)
            {
                tmpStack.Push(chameau);
            }

            int count = 4;
            foreach(Camel chameau in tmpStack) {
                Label colorLabel = new Label();
                colorLabel.Size = new Size(42, 10);

                switch (chameau.CamelColor)
                {
                    case CamelColor.Blue:
                        colorLabel.BackColor = Color.Blue;
                        break;
                    case CamelColor.Green:
                        colorLabel.BackColor = Color.Green;
                        break;
                    case CamelColor.Yellow:
                        colorLabel.BackColor = Color.Yellow;
                        break;
                    case CamelColor.White:
                        colorLabel.BackColor = Color.White;
                        break;
                    case CamelColor.Orange:
                        colorLabel.BackColor = Color.Orange;
                        break;
                }

                colorLabel.Location = new Point(0, count * 10);
                panel.Controls.Add(colorLabel);
                count--;
            }

            return panel;
        }

        public bool CheckChameauPresent(CamelColor couleur) {
            foreach(Camel chameau in CamelStack) {
                if(chameau.CamelColor == couleur) {
                    return true;
                }
            }
            return false;
        }

        public Camel[] GetPresentCamelArray() {
            Camel[] camelArray = new Camel[CamelStack.Count];
            int i = 0;

            foreach(Camel camel in CamelStack) {
                camelArray[i] = camel;
                i++;
            }

            return camelArray;
        }
    }

    public enum CellType {
        Normal,
        Desert,
        Oasis,
        Start
    }
}
