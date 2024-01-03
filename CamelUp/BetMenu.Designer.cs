namespace CamelUp
{
    sealed partial class BetMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnVert = new System.Windows.Forms.Button();
            this.BtnOrange = new System.Windows.Forms.Button();
            this.BtnJaune = new System.Windows.Forms.Button();
            this.BtnBlanc = new System.Windows.Forms.Button();
            this.BtnBleu = new System.Windows.Forms.Button();
            this.LblCancel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnVert
            // 
            this.BtnVert.Image = global::CamelUp.Properties.Resources.Bet_Card_Green;
            this.BtnVert.Location = new System.Drawing.Point(329, 114);
            this.BtnVert.Name = "BtnVert";
            this.BtnVert.Size = new System.Drawing.Size(65, 100);
            this.BtnVert.TabIndex = 8;
            this.BtnVert.UseVisualStyleBackColor = true;
            this.BtnVert.Click += new System.EventHandler(this.BtnVert_Click);
            // 
            // BtnOrange
            // 
            this.BtnOrange.Image = global::CamelUp.Properties.Resources.Bet_Card_Orange;
            this.BtnOrange.Location = new System.Drawing.Point(258, 114);
            this.BtnOrange.Name = "BtnOrange";
            this.BtnOrange.Size = new System.Drawing.Size(65, 100);
            this.BtnOrange.TabIndex = 6;
            this.BtnOrange.UseVisualStyleBackColor = true;
            this.BtnOrange.Click += new System.EventHandler(this.BtnOrange_Click);
            // 
            // BtnJaune
            // 
            this.BtnJaune.Image = global::CamelUp.Properties.Resources.Bet_Card_Yellow;
            this.BtnJaune.Location = new System.Drawing.Point(187, 114);
            this.BtnJaune.Name = "BtnJaune";
            this.BtnJaune.Size = new System.Drawing.Size(65, 100);
            this.BtnJaune.TabIndex = 4;
            this.BtnJaune.UseVisualStyleBackColor = true;
            this.BtnJaune.Click += new System.EventHandler(this.BtnJaune_Click);
            // 
            // BtnBlanc
            // 
            this.BtnBlanc.Image = global::CamelUp.Properties.Resources.Bet_Card_White;
            this.BtnBlanc.Location = new System.Drawing.Point(116, 114);
            this.BtnBlanc.Name = "BtnBlanc";
            this.BtnBlanc.Size = new System.Drawing.Size(65, 100);
            this.BtnBlanc.TabIndex = 2;
            this.BtnBlanc.UseVisualStyleBackColor = true;
            this.BtnBlanc.Click += new System.EventHandler(this.BtnBlanc_Click);
            // 
            // BtnBleu
            // 
            this.BtnBleu.Image = global::CamelUp.Properties.Resources.Bet_Card_Blue;
            this.BtnBleu.Location = new System.Drawing.Point(45, 114);
            this.BtnBleu.Name = "BtnBleu";
            this.BtnBleu.Size = new System.Drawing.Size(65, 100);
            this.BtnBleu.TabIndex = 0;
            this.BtnBleu.UseVisualStyleBackColor = true;
            this.BtnBleu.Click += new System.EventHandler(this.BtnBleu_Click);
            // 
            // LblCancel
            // 
            this.LblCancel.AutoSize = true;
            this.LblCancel.BackColor = System.Drawing.Color.Transparent;
            this.LblCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblCancel.Location = new System.Drawing.Point(150, 264);
            this.LblCancel.MaximumSize = new System.Drawing.Size(140, 27);
            this.LblCancel.MinimumSize = new System.Drawing.Size(140, 27);
            this.LblCancel.Name = "LblCancel";
            this.LblCancel.Size = new System.Drawing.Size(140, 27);
            this.LblCancel.TabIndex = 15;
            this.LblCancel.Text = "Annuler";
            this.LblCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblCancel.Click += new System.EventHandler(this.LblCancel_Click);
            // 
            // BetMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(54)))), ((int)(((byte)(25)))));
            this.BackgroundImage = global::CamelUp.Properties.Resources.menuGangantCamelUp;
            this.ClientSize = new System.Drawing.Size(440, 330);
            this.Controls.Add(this.LblCancel);
            this.Controls.Add(this.BtnVert);
            this.Controls.Add(this.BtnOrange);
            this.Controls.Add(this.BtnJaune);
            this.Controls.Add(this.BtnBlanc);
            this.Controls.Add(this.BtnBleu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(456, 369);
            this.MinimumSize = new System.Drawing.Size(456, 369);
            this.Name = "BetMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Camel up";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BetMenu_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBleu;
        private System.Windows.Forms.Button BtnBlanc;
        private System.Windows.Forms.Button BtnJaune;
        private System.Windows.Forms.Button BtnOrange;
        private System.Windows.Forms.Button BtnVert;
        private System.Windows.Forms.Label LblCancel;
    }
}