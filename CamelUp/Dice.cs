using System;

namespace CamelUp {
    public class Dice {
        private readonly Tuple<CamelColor, int>[] _dicesList = new Tuple<CamelColor, int>[5];
        private readonly CamelColor[] _camelColors = new CamelColor[5];
        public int DicesCount;

        public Dice() {
            ShuffleDice();
        }

        public void ShuffleDice() {
            Random rnd = new Random();

            _camelColors[0] = CamelColor.White;
            _camelColors[1] = CamelColor.Blue;
            _camelColors[2] = CamelColor.Yellow;
            _camelColors[3] = CamelColor.Orange;
            _camelColors[4] = CamelColor.Green;

            for(int i = 0; i < _camelColors.Length; i++) {
                int number = rnd.Next(5);
                CamelColor tmp = _camelColors[i];
                _camelColors[i] = _camelColors[number];
                _camelColors[number] = tmp;
            }

            for(int i = 0; i < _dicesList.Length; i++)
            {
                var cellsMovingNumber = rnd.Next(1, 4);
                _dicesList[i] = new Tuple<CamelColor, int>(_camelColors[i], cellsMovingNumber);
            }
        }

        public Tuple<CamelColor, int> DrawDice() {
            DicesCount++;
            return _dicesList[DicesCount - 1];
        }

        public void Reset() {
            ShuffleDice();
            DicesCount = 0;
        }
    }
}
