using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamelUp.Properties;

namespace CamelUp
{
    public class MainMenu : Form
    {
        private Label LblJouer;
        private Label LblQuitter;
        private TextBox TxtJoueur1;
        private TextBox TxtJoueur2;
        private TextBox TxtJoueur4;
        private TextBox TxtJoueur3;
        private Label LblContinuer;
        private ErrorProvider ErpJoueurs;
        private System.ComponentModel.IContainer components;
        private Form1 game;

        public MainMenu()
        {
            InitializeComponent();
            
            this.game = new Form1(this);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LblJouer = new System.Windows.Forms.Label();
            this.LblQuitter = new System.Windows.Forms.Label();
            this.TxtJoueur1 = new System.Windows.Forms.TextBox();
            this.TxtJoueur2 = new System.Windows.Forms.TextBox();
            this.TxtJoueur4 = new System.Windows.Forms.TextBox();
            this.TxtJoueur3 = new System.Windows.Forms.TextBox();
            this.LblContinuer = new System.Windows.Forms.Label();
            this.ErpJoueurs = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErpJoueurs)).BeginInit();
            this.SuspendLayout();
            // 
            // LblJouer
            // 
            this.LblJouer.AutoSize = true;
            this.LblJouer.BackColor = System.Drawing.Color.Transparent;
            this.LblJouer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblJouer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblJouer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblJouer.Location = new System.Drawing.Point(25, 383);
            this.LblJouer.MinimumSize = new System.Drawing.Size(113, 37);
            this.LblJouer.Name = "LblJouer";
            this.LblJouer.Size = new System.Drawing.Size(113, 37);
            this.LblJouer.TabIndex = 0;
            this.LblJouer.Text = "Jouer";
            this.LblJouer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblJouer.Click += new System.EventHandler(this.LblJouer_Click);
            // 
            // LblQuitter
            // 
            this.LblQuitter.AutoSize = true;
            this.LblQuitter.BackColor = System.Drawing.Color.Transparent;
            this.LblQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuitter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblQuitter.Location = new System.Drawing.Point(161, 383);
            this.LblQuitter.MinimumSize = new System.Drawing.Size(113, 37);
            this.LblQuitter.Name = "LblQuitter";
            this.LblQuitter.Size = new System.Drawing.Size(113, 37);
            this.LblQuitter.TabIndex = 1;
            this.LblQuitter.Text = "Quitter";
            this.LblQuitter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblQuitter.Click += new System.EventHandler(this.LblQuitter_Click);
            // 
            // TxtJoueur1
            // 
            this.TxtJoueur1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(76)))), ((int)(((byte)(26)))));
            this.TxtJoueur1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtJoueur1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtJoueur1.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtJoueur1.Location = new System.Drawing.Point(54, 123);
            this.TxtJoueur1.MaximumSize = new System.Drawing.Size(185, 21);
            this.TxtJoueur1.MinimumSize = new System.Drawing.Size(185, 21);
            this.TxtJoueur1.Name = "TxtJoueur1";
            this.TxtJoueur1.Size = new System.Drawing.Size(185, 21);
            this.TxtJoueur1.TabIndex = 2;
            this.TxtJoueur1.Visible = false;
            // 
            // TxtJoueur2
            // 
            this.TxtJoueur2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(76)))), ((int)(((byte)(26)))));
            this.TxtJoueur2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtJoueur2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtJoueur2.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtJoueur2.Location = new System.Drawing.Point(54, 190);
            this.TxtJoueur2.MaximumSize = new System.Drawing.Size(185, 21);
            this.TxtJoueur2.MinimumSize = new System.Drawing.Size(185, 21);
            this.TxtJoueur2.Name = "TxtJoueur2";
            this.TxtJoueur2.Size = new System.Drawing.Size(185, 21);
            this.TxtJoueur2.TabIndex = 3;
            this.TxtJoueur2.Visible = false;
            // 
            // TxtJoueur4
            // 
            this.TxtJoueur4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(76)))), ((int)(((byte)(26)))));
            this.TxtJoueur4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtJoueur4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtJoueur4.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtJoueur4.Location = new System.Drawing.Point(54, 331);
            this.TxtJoueur4.MaximumSize = new System.Drawing.Size(185, 21);
            this.TxtJoueur4.MinimumSize = new System.Drawing.Size(185, 21);
            this.TxtJoueur4.Name = "TxtJoueur4";
            this.TxtJoueur4.Size = new System.Drawing.Size(185, 21);
            this.TxtJoueur4.TabIndex = 5;
            this.TxtJoueur4.Visible = false;
            // 
            // TxtJoueur3
            // 
            this.TxtJoueur3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(76)))), ((int)(((byte)(26)))));
            this.TxtJoueur3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtJoueur3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtJoueur3.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtJoueur3.Location = new System.Drawing.Point(54, 264);
            this.TxtJoueur3.MaximumSize = new System.Drawing.Size(185, 21);
            this.TxtJoueur3.MinimumSize = new System.Drawing.Size(185, 21);
            this.TxtJoueur3.Name = "TxtJoueur3";
            this.TxtJoueur3.Size = new System.Drawing.Size(185, 21);
            this.TxtJoueur3.TabIndex = 4;
            this.TxtJoueur3.Visible = false;
            // 
            // LblContinuer
            // 
            this.LblContinuer.AutoSize = true;
            this.LblContinuer.BackColor = System.Drawing.Color.Transparent;
            this.LblContinuer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblContinuer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContinuer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblContinuer.Location = new System.Drawing.Point(80, 371);
            this.LblContinuer.MinimumSize = new System.Drawing.Size(136, 37);
            this.LblContinuer.Name = "LblContinuer";
            this.LblContinuer.Size = new System.Drawing.Size(136, 37);
            this.LblContinuer.TabIndex = 6;
            this.LblContinuer.Text = "Continuer";
            this.LblContinuer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblContinuer.Visible = false;
            this.LblContinuer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LblContinuer_Click);
            // 
            // ErpJoueurs
            // 
            this.ErpJoueurs.BlinkRate = 0;
            this.ErpJoueurs.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErpJoueurs.ContainerControl = this;
            // 
            // MainMenu
            // 
            this.BackgroundImage = Resources.menuCamelUp;
            this.ClientSize = new System.Drawing.Size(300, 440);
            this.Controls.Add(this.LblContinuer);
            this.Controls.Add(this.TxtJoueur4);
            this.Controls.Add(this.TxtJoueur3);
            this.Controls.Add(this.TxtJoueur2);
            this.Controls.Add(this.TxtJoueur1);
            this.Controls.Add(this.LblQuitter);
            this.Controls.Add(this.LblJouer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(316, 479);
            this.MinimumSize = new System.Drawing.Size(316, 479);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Camel Up";
            ((System.ComponentModel.ISupportInitialize)(this.ErpJoueurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void LblJouer_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = global::CamelUp.Properties.Resources.menuJoueurCamelUp;
            this.LblJouer.Visible = false;
            this.LblQuitter.Visible = false;
            this.TxtJoueur1.Visible = true;
            this.TxtJoueur2.Visible = true;
            this.TxtJoueur3.Visible = true;
            this.TxtJoueur4.Visible = true;
            this.LblContinuer.Visible = true;
            TxtJoueur1.Focus();
        }

        private void LblQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LblContinuer_Click(object sender, MouseEventArgs e)
        {
            ErpJoueurs.Clear();

            bool ready = true;

            if (this.TxtJoueur1.Text == "")
            {
                ErpJoueurs.SetError(TxtJoueur1, "Veuillez remplir le champ.");
                ready = false;
            }
            if (this.TxtJoueur2.Text == "")
            {
                ErpJoueurs.SetError(TxtJoueur2, "Veuillez remplir le champ.");
                ready = false;
            }
            if (this.TxtJoueur3.Text == "")
            {
                ErpJoueurs.SetError(TxtJoueur3, "Veuillez remplir le champ.");
                ready = false;
            }
            if (this.TxtJoueur4.Text == "")
            {
                ErpJoueurs.SetError(TxtJoueur4, "Veuillez remplir le champ.");
                ready = false;
            }

            if (ready)
            {
                this.Visible = false;
                game.AddPlayer(TxtJoueur1.Text, 0);
                game.AddPlayer(TxtJoueur2.Text, 1);
                game.AddPlayer(TxtJoueur3.Text, 2);
                game.AddPlayer(TxtJoueur4.Text, 3);
                this.game.Show();
            }
        }

        public void newGame(Form1 form) {
            String p1 = game.Players[0].Name;
            String p2 = game.Players[1].Name;
            String p3 = game.Players[2].Name;
            String p4 = game.Players[3].Name;
            this.game.Hide();

            this.game = new Form1(this);
            game.AddPlayer(TxtJoueur1.Text, 0);
            game.AddPlayer(TxtJoueur2.Text, 1);
            game.AddPlayer(TxtJoueur3.Text, 2);
            game.AddPlayer(TxtJoueur4.Text, 3);
            this.game.Show();
        }
    }
}
