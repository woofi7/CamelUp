using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CamelUp.Properties;

namespace CamelUp
{
    public class Player {
        public String Name;
        public int Score;
        public List<Card> CardsList = new List<Card>();
        public List<CamelColor> WinnerBet = new List<CamelColor>();
        public List<CamelColor> LoserBet = new List<CamelColor>();

        public Player(String name) {
            if (name.Length > 12) {
                Name = name.Substring(0, 12);
            }
            else {
                Name = name;
            }
        }

        /// <summary>
        /// Ajouter une carte au joueur.
        /// </summary>
        /// <param name="card"></param>
        public void AddCard(Card card) {
            CardsList.Add(card);
        }

        /// <summary>
        /// Récupérer les éléments graphiques des cartes pour les afficher.
        /// </summary>
        /// <param name="nbElements"></param>
        /// <param name="camelPlaces">Liste de la place des chameaux.</param>
        /// <returns></returns>
        public List<Label> GetCardsLabel(int nbElements, LinkedList<Camel> camelPlaces) {
            if(nbElements >= 8) {
                return null;
            }

            List<Label> labelList = new List<Label>();
            int count = 0;

            foreach (Card card in CardsList) {
                if(count < nbElements) {
                    count++;
                    continue;
                }
                if (count == 8) {
                    return null;
                }

                Label label = new Label
                {
                    BackColor = Color.Transparent,
                    Font =
                        new Font("Microsoft Sans Serif", 18F, FontStyle.Bold,
                            GraphicsUnit.Point, 0),
                    Size = new Size(28, 44),
                    TextAlign = ContentAlignment.MiddleCenter
                };


                switch (card.CardT){
                    case Card.CardType.Blue:
                        label.Image = Resources.carte_B_small;
                        break;
                    case Card.CardType.Green:
                        label.Image = Resources.carte_V_small;
                        break;
                    case Card.CardType.Yellow:
                        label.Image = Resources.carte_J_small;
                        break;
                    case Card.CardType.White:
                        label.Image = Resources.carte_Bl_small;
                        break;
                    case Card.CardType.Red:
                        label.Image = Resources.carte_R_small;
                        break;
                    case Card.CardType.Pyramide:
                        label.Image = Resources.pyramide1;
                        break;
                }

                labelList.Add(label);
                count++;
            }
            return labelList;
        }

        /// <summary>
        /// Récupérer la valeur mise à jour des cartes du joueur selon l'emplacement
        /// des chameaux dans la course.
        /// </summary>
        /// <param name="nbElements"></param>
        /// <param name="camelPlaces"></param>
        /// <returns></returns>
        public int[] GetCardsInfos(int nbElements, LinkedList<Camel> camelPlaces) {
            int[] cardsInfos = new int[nbElements + 1];
            int i = 0;

            foreach(Card card in CardsList) {
                if(i == cardsInfos.Length)
                    break;

                int value = calculateValue(camelPlaces, card);
                cardsInfos[i] = value;

                i++;
            }
            return cardsInfos;
        }

        /// <summary>
        /// Calculer la valeur de la carte selon l'emplacement des chameaux.
        /// </summary>
        /// <param name="camels">Liste de la place des chameaux.</param>
        /// <param name="card">Carte à vérifier.</param>
        /// <returns></returns>
        private int calculateValue(LinkedList<Camel> camels, Card card) {
            int value = 0;


            foreach(Camel camel in camels) {
                if(camel.CamelColor == card.CamelColor) {
                    break;
                }
            }

            if(card.CardT == Card.CardType.Pyramide) {
                value = 1;
            } else {

                if(card.Value == 2) {
                    value = 5;
                } else if(card.Value == 1) {
                    value = 3;
                } else if(card.Value == 0) {
                    value = 2;
                }

                if(camels.Count == 0) {
                    value = 0;
                } else if(camels.Count > 1) {
                    if(camels.First.Next != null && camels.First.Next.Value.CamelColor == card.CamelColor) {
                        value = 1;
                    } else if(camels.First.Value.CamelColor != card.CamelColor) {
                        value = -1;
                    }
                }
            }
            
            return value;
        }

        public void ComputeScore(LinkedList<Camel> camels) {
            foreach(Card card in CardsList) {
                int value = calculateValue(camels, card);

                Score += value;
            }

            if(Score < 0) {
                Score = 0;
            }
        }
    }
}
