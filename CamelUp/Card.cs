using CamelUp.Properties;
using System.Windows.Forms;

namespace CamelUp {
    public sealed class Card:PictureBox {
        public CardType CardT;
        public CamelColor CamelColor;
        public int Value;

        public Card(int j, int cardTypeNumber) {
            CardType card = (CardType)cardTypeNumber;
            switch(card) {
                 case CardType.Blue:
                 switch(j) {
                     case 0:
                     Image = Resources.carte_2_B;
                     break;
                     case 1:
                     Image = Resources.carte_3_B;
                     break;
                     case 2:
                     Image = Resources.carte_5_B;
                     break;
                 }
                 break;
                 case CardType.Green:
                    switch (j) {
                     case 0:
                     Image = Resources.carte_2_V;
                     break;
                     case 1:
                     Image = Resources.carte_3_V;
                     break;
                     case 2:
                     Image = Resources.carte_5_V;
                     break;
                 }
                 break;
                 case CardType.Yellow:
                    switch (j) {
                     case 0:
                     Image = Resources.carte_2_J;
                     break;
                     case 1:
                     Image = Resources.carte_3_J;
                     break;
                     case 2:
                     Image = Resources.carte_5_J;
                     break;
                 }
                 break;
                 case CardType.White:
                    switch (j) {
                     case 0:
                     Image = Resources.carte_2_Bl;
                     break;
                     case 1:
                     Image = Resources.carte_3_Bl;
                     break;
                     case 2:
                     Image = Resources.carte_5_Bl;
                     break;
                 }
                 break;
                 case CardType.Red:
                    switch (j) {
                     case 0:
                     Image = Resources.carte_2_R;
                     break;
                     case 1:
                     Image = Resources.carte_3_R;
                     break;
                     case 2:
                     Image = Resources.carte_5_R;
                     break;
                 }
                 break;
                 case CardType.Pyramide:
                    if (j == -1)
                    {
                        Image = Resources.pyramide1;
                    }
                break;
             }

            if(CardT != CardType.Pyramide) {
                CamelColor = (CamelColor)cardTypeNumber;
            }
            CardT = card;

            BackColor = System.Drawing.Color.Transparent;
            Value = j;
            Size = new System.Drawing.Size(80, 122);
            Cursor = Cursors.Hand;
        }

        public enum CardType {
            Blue = 0,
            Green = 1,
            Yellow = 2,
            White = 3,
            Red = 4,
            Pyramide = 5
        }

    }
}
