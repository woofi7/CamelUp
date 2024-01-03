using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CamelUp.Properties;

namespace CamelUp
{
    public sealed partial class BetMenu : Form
    {
        private readonly Form1 _form;
        private readonly bool _betType;

        public BetMenu(Form1 form, bool betType, List<CamelColor> cards)
        {
            _form = form;
            _betType = betType;

            InitializeComponent();

            foreach (CamelColor camelColor in cards)
            {
                switch (camelColor)
                {
                    case CamelColor.Blue:
                        BtnBleu.Enabled = false;
                        break;
                    case CamelColor.Green:
                        BtnVert.Enabled = false;
                        break;
                    case CamelColor.Yellow:
                        BtnJaune.Enabled = false;
                        break;
                    case CamelColor.White:
                        BtnBlanc.Enabled = false;
                        break;
                    case CamelColor.Orange:
                        BtnOrange.Enabled = false;
                        break;
                }
            }


            if (!betType)
            {
                BackgroundImage = Resources.menuPerdantCamelUp;
            }
            
        }

        /// <summary>
        /// Quitter la fenêtre des mises.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LblCancel_Click(object sender, EventArgs e) {
            Close();
        }

        /// <summary>
        /// Choix du chameau bleu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBleu_Click(object sender, EventArgs e)  {
            if (_betType) {
                _form.WinnerBet(CamelColor.Blue);
            }
            else {
                _form.LoserBet(CamelColor.Blue);
            }

            _form.Visible = true;
            Close();
        }

        /// <summary>
        /// Choix du chameau blanc.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBlanc_Click(object sender, EventArgs e) {
            if (_betType) {
                _form.WinnerBet(CamelColor.White);
            }
            else {
                _form.LoserBet(CamelColor.White);
            }

            _form.Visible = true;
            Close();
        }

        /// <summary>
        /// Choix du chameau jaune.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnJaune_Click(object sender, EventArgs e) {
            if (_betType) {
                _form.WinnerBet(CamelColor.Yellow);
            }
            else {
                _form.LoserBet(CamelColor.Yellow);
            }

            _form.Visible = true;
            Close();
        }

        /// <summary>
        /// Choix du chameau orange.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOrange_Click(object sender, EventArgs e) {
            if (_betType) {
                _form.WinnerBet(CamelColor.Orange);
            }
            else {
                _form.LoserBet(CamelColor.Orange);
            }

            _form.Visible = true;
            Close();
        }

        /// <summary>
        /// Choix du chameau vert.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnVert_Click(object sender, EventArgs e) {
            if (_betType) {
                _form.WinnerBet(CamelColor.Green);
            }
            else {
                _form.LoserBet(CamelColor.Green);
            }

            _form.Visible = true;
            Close();
        }

        private void BetMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            _form.Visible = true;
        }
    }
}
