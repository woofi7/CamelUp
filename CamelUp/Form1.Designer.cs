namespace CamelUp {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.PnlPyramide = new System.Windows.Forms.Panel();
            this.PnlCartes = new System.Windows.Forms.Panel();
            this.LblDiceB = new System.Windows.Forms.Label();
            this.LblDiceW = new System.Windows.Forms.Label();
            this.LblDiceY = new System.Windows.Forms.Label();
            this.LblDiceO = new System.Windows.Forms.Label();
            this.LblDiceG = new System.Windows.Forms.Label();
            this.LblTime = new System.Windows.Forms.Label();
            this.LblRound = new System.Windows.Forms.Label();
            this.LblLastPlace = new System.Windows.Forms.Label();
            this.LblFirstPlace = new System.Windows.Forms.Label();
            this.LblTimer = new System.Windows.Forms.Label();
            this.LblRoundNum = new System.Windows.Forms.Label();
            this.LblLastPlaceInfo = new System.Windows.Forms.Label();
            this.LblFirstPlaceInfo = new System.Windows.Forms.Label();
            this.LblPlayer1Score = new System.Windows.Forms.Label();
            this.LblPlayer1 = new System.Windows.Forms.Label();
            this.LblPlayer2Score = new System.Windows.Forms.Label();
            this.LblPlayer2 = new System.Windows.Forms.Label();
            this.LblPlayer4Score = new System.Windows.Forms.Label();
            this.LblPlayer4 = new System.Windows.Forms.Label();
            this.LblPlayer3Score = new System.Windows.Forms.Label();
            this.LblPlayer3 = new System.Windows.Forms.Label();
            this.PctFirst = new System.Windows.Forms.PictureBox();
            this.PctLast = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tmr1 = new System.Windows.Forms.Timer(this.components);
            this.LblPlayerName1 = new System.Windows.Forms.Label();
            this.LblPlayerName2 = new System.Windows.Forms.Label();
            this.LblPlayerName4 = new System.Windows.Forms.Label();
            this.LblPlayerName3 = new System.Windows.Forms.Label();
            this.PnlPlayerCards1 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PnlPlayerCards2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PnlPlayerCards4 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PnlPlayerCards3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.nouvellePartieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.àProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LblCase15 = new CamelUp.Cell();
            this.LblCase14 = new CamelUp.Cell();
            this.LblCase13 = new CamelUp.Cell();
            this.LblCase12 = new CamelUp.Cell();
            this.LblCase11 = new CamelUp.Cell();
            this.LblCase10 = new CamelUp.Cell();
            this.LblCase9 = new CamelUp.Cell();
            this.LblCase8 = new CamelUp.Cell();
            this.LblCase7 = new CamelUp.Cell();
            this.LblCase6 = new CamelUp.Cell();
            this.LblCase5 = new CamelUp.Cell();
            this.LblCase4 = new CamelUp.Cell();
            this.cell4 = new CamelUp.Cell();
            this.LblCase3 = new CamelUp.Cell();
            this.LblCase2 = new CamelUp.Cell();
            this.LblCase1 = new CamelUp.Cell();
            this.LblCase0 = new CamelUp.Cell();
            ((System.ComponentModel.ISupportInitialize)(this.PctFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctLast)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.PnlPlayerCards1.SuspendLayout();
            this.PnlPlayerCards2.SuspendLayout();
            this.PnlPlayerCards4.SuspendLayout();
            this.PnlPlayerCards3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlPyramide
            // 
            this.PnlPyramide.BackColor = System.Drawing.Color.Transparent;
            this.PnlPyramide.BackgroundImage = global::CamelUp.Properties.Resources.pyramide;
            this.PnlPyramide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PnlPyramide.Location = new System.Drawing.Point(326, 217);
            this.PnlPyramide.Name = "PnlPyramide";
            this.PnlPyramide.Size = new System.Drawing.Size(131, 133);
            this.PnlPyramide.TabIndex = 0;
            this.PnlPyramide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlPyramide_Down);
            // 
            // PnlCartes
            // 
            this.PnlCartes.BackColor = System.Drawing.Color.Transparent;
            this.PnlCartes.Location = new System.Drawing.Point(189, 499);
            this.PnlCartes.Name = "PnlCartes";
            this.PnlCartes.Size = new System.Drawing.Size(458, 122);
            this.PnlCartes.TabIndex = 0;
            // 
            // LblDiceB
            // 
            this.LblDiceB.AutoSize = true;
            this.LblDiceB.BackColor = System.Drawing.Color.Transparent;
            this.LblDiceB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDiceB.Location = new System.Drawing.Point(310, 369);
            this.LblDiceB.MaximumSize = new System.Drawing.Size(30, 30);
            this.LblDiceB.MinimumSize = new System.Drawing.Size(30, 30);
            this.LblDiceB.Name = "LblDiceB";
            this.LblDiceB.Size = new System.Drawing.Size(30, 30);
            this.LblDiceB.TabIndex = 1;
            // 
            // LblDiceW
            // 
            this.LblDiceW.AutoSize = true;
            this.LblDiceW.BackColor = System.Drawing.Color.Transparent;
            this.LblDiceW.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDiceW.Location = new System.Drawing.Point(356, 369);
            this.LblDiceW.MaximumSize = new System.Drawing.Size(30, 30);
            this.LblDiceW.MinimumSize = new System.Drawing.Size(30, 30);
            this.LblDiceW.Name = "LblDiceW";
            this.LblDiceW.Size = new System.Drawing.Size(30, 30);
            this.LblDiceW.TabIndex = 2;
            // 
            // LblDiceY
            // 
            this.LblDiceY.AutoSize = true;
            this.LblDiceY.BackColor = System.Drawing.Color.Transparent;
            this.LblDiceY.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDiceY.Location = new System.Drawing.Point(400, 369);
            this.LblDiceY.MaximumSize = new System.Drawing.Size(30, 30);
            this.LblDiceY.MinimumSize = new System.Drawing.Size(30, 30);
            this.LblDiceY.Name = "LblDiceY";
            this.LblDiceY.Size = new System.Drawing.Size(30, 30);
            this.LblDiceY.TabIndex = 3;
            // 
            // LblDiceO
            // 
            this.LblDiceO.AutoSize = true;
            this.LblDiceO.BackColor = System.Drawing.Color.Transparent;
            this.LblDiceO.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDiceO.Location = new System.Drawing.Point(445, 369);
            this.LblDiceO.MaximumSize = new System.Drawing.Size(30, 30);
            this.LblDiceO.MinimumSize = new System.Drawing.Size(30, 30);
            this.LblDiceO.Name = "LblDiceO";
            this.LblDiceO.Size = new System.Drawing.Size(30, 30);
            this.LblDiceO.TabIndex = 4;
            // 
            // LblDiceG
            // 
            this.LblDiceG.AutoSize = true;
            this.LblDiceG.BackColor = System.Drawing.Color.Transparent;
            this.LblDiceG.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDiceG.Location = new System.Drawing.Point(490, 369);
            this.LblDiceG.MaximumSize = new System.Drawing.Size(30, 30);
            this.LblDiceG.MinimumSize = new System.Drawing.Size(30, 30);
            this.LblDiceG.Name = "LblDiceG";
            this.LblDiceG.Size = new System.Drawing.Size(30, 30);
            this.LblDiceG.TabIndex = 5;
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.BackColor = System.Drawing.Color.Transparent;
            this.LblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblTime.Location = new System.Drawing.Point(26, 129);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(62, 20);
            this.LblTime.TabIndex = 6;
            this.LblTime.Text = "Temps";
            // 
            // LblRound
            // 
            this.LblRound.AutoSize = true;
            this.LblRound.BackColor = System.Drawing.Color.Transparent;
            this.LblRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRound.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblRound.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblRound.Location = new System.Drawing.Point(26, 154);
            this.LblRound.Name = "LblRound";
            this.LblRound.Size = new System.Drawing.Size(62, 20);
            this.LblRound.TabIndex = 7;
            this.LblRound.Text = "Ronde";
            // 
            // LblLastPlace
            // 
            this.LblLastPlace.AutoSize = true;
            this.LblLastPlace.BackColor = System.Drawing.Color.Transparent;
            this.LblLastPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLastPlace.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblLastPlace.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblLastPlace.Location = new System.Drawing.Point(26, 215);
            this.LblLastPlace.Name = "LblLastPlace";
            this.LblLastPlace.Size = new System.Drawing.Size(68, 20);
            this.LblLastPlace.TabIndex = 9;
            this.LblLastPlace.Text = "Dernier";
            // 
            // LblFirstPlace
            // 
            this.LblFirstPlace.AutoSize = true;
            this.LblFirstPlace.BackColor = System.Drawing.Color.Transparent;
            this.LblFirstPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFirstPlace.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblFirstPlace.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblFirstPlace.Location = new System.Drawing.Point(26, 190);
            this.LblFirstPlace.Name = "LblFirstPlace";
            this.LblFirstPlace.Size = new System.Drawing.Size(70, 20);
            this.LblFirstPlace.TabIndex = 8;
            this.LblFirstPlace.Text = "Premier";
            // 
            // LblTimer
            // 
            this.LblTimer.AutoSize = true;
            this.LblTimer.BackColor = System.Drawing.Color.Transparent;
            this.LblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTimer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblTimer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LblTimer.Location = new System.Drawing.Point(102, 132);
            this.LblTimer.MaximumSize = new System.Drawing.Size(60, 16);
            this.LblTimer.MinimumSize = new System.Drawing.Size(60, 16);
            this.LblTimer.Name = "LblTimer";
            this.LblTimer.Size = new System.Drawing.Size(60, 16);
            this.LblTimer.TabIndex = 10;
            this.LblTimer.Text = "00:00";
            this.LblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblRoundNum
            // 
            this.LblRoundNum.AutoSize = true;
            this.LblRoundNum.BackColor = System.Drawing.Color.Transparent;
            this.LblRoundNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRoundNum.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblRoundNum.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LblRoundNum.Location = new System.Drawing.Point(102, 157);
            this.LblRoundNum.MaximumSize = new System.Drawing.Size(60, 16);
            this.LblRoundNum.MinimumSize = new System.Drawing.Size(60, 16);
            this.LblRoundNum.Name = "LblRoundNum";
            this.LblRoundNum.Size = new System.Drawing.Size(60, 16);
            this.LblRoundNum.TabIndex = 11;
            this.LblRoundNum.Text = "1";
            this.LblRoundNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblLastPlaceInfo
            // 
            this.LblLastPlaceInfo.AutoSize = true;
            this.LblLastPlaceInfo.BackColor = System.Drawing.Color.Transparent;
            this.LblLastPlaceInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLastPlaceInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LblLastPlaceInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LblLastPlaceInfo.Location = new System.Drawing.Point(102, 218);
            this.LblLastPlaceInfo.MaximumSize = new System.Drawing.Size(60, 16);
            this.LblLastPlaceInfo.MinimumSize = new System.Drawing.Size(60, 16);
            this.LblLastPlaceInfo.Name = "LblLastPlaceInfo";
            this.LblLastPlaceInfo.Size = new System.Drawing.Size(60, 16);
            this.LblLastPlaceInfo.TabIndex = 13;
            this.LblLastPlaceInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblFirstPlaceInfo
            // 
            this.LblFirstPlaceInfo.AutoSize = true;
            this.LblFirstPlaceInfo.BackColor = System.Drawing.Color.Transparent;
            this.LblFirstPlaceInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFirstPlaceInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LblFirstPlaceInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LblFirstPlaceInfo.Location = new System.Drawing.Point(102, 193);
            this.LblFirstPlaceInfo.MaximumSize = new System.Drawing.Size(60, 16);
            this.LblFirstPlaceInfo.MinimumSize = new System.Drawing.Size(60, 16);
            this.LblFirstPlaceInfo.Name = "LblFirstPlaceInfo";
            this.LblFirstPlaceInfo.Size = new System.Drawing.Size(60, 16);
            this.LblFirstPlaceInfo.TabIndex = 12;
            this.LblFirstPlaceInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblPlayer1Score
            // 
            this.LblPlayer1Score.AutoSize = true;
            this.LblPlayer1Score.BackColor = System.Drawing.Color.Transparent;
            this.LblPlayer1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlayer1Score.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblPlayer1Score.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LblPlayer1Score.Location = new System.Drawing.Point(132, 253);
            this.LblPlayer1Score.MaximumSize = new System.Drawing.Size(30, 16);
            this.LblPlayer1Score.MinimumSize = new System.Drawing.Size(30, 16);
            this.LblPlayer1Score.Name = "LblPlayer1Score";
            this.LblPlayer1Score.Size = new System.Drawing.Size(30, 16);
            this.LblPlayer1Score.TabIndex = 15;
            this.LblPlayer1Score.Text = "0";
            this.LblPlayer1Score.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblPlayer1
            // 
            this.LblPlayer1.AutoSize = true;
            this.LblPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.LblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlayer1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblPlayer1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblPlayer1.Location = new System.Drawing.Point(26, 250);
            this.LblPlayer1.MaximumSize = new System.Drawing.Size(100, 20);
            this.LblPlayer1.MinimumSize = new System.Drawing.Size(100, 20);
            this.LblPlayer1.Name = "LblPlayer1";
            this.LblPlayer1.Size = new System.Drawing.Size(100, 20);
            this.LblPlayer1.TabIndex = 14;
            // 
            // LblPlayer2Score
            // 
            this.LblPlayer2Score.AutoSize = true;
            this.LblPlayer2Score.BackColor = System.Drawing.Color.Transparent;
            this.LblPlayer2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlayer2Score.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblPlayer2Score.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LblPlayer2Score.Location = new System.Drawing.Point(132, 273);
            this.LblPlayer2Score.MaximumSize = new System.Drawing.Size(30, 16);
            this.LblPlayer2Score.MinimumSize = new System.Drawing.Size(30, 16);
            this.LblPlayer2Score.Name = "LblPlayer2Score";
            this.LblPlayer2Score.Size = new System.Drawing.Size(30, 16);
            this.LblPlayer2Score.TabIndex = 17;
            this.LblPlayer2Score.Text = "0";
            this.LblPlayer2Score.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblPlayer2
            // 
            this.LblPlayer2.AutoSize = true;
            this.LblPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.LblPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlayer2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblPlayer2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblPlayer2.Location = new System.Drawing.Point(26, 270);
            this.LblPlayer2.MaximumSize = new System.Drawing.Size(100, 20);
            this.LblPlayer2.MinimumSize = new System.Drawing.Size(100, 20);
            this.LblPlayer2.Name = "LblPlayer2";
            this.LblPlayer2.Size = new System.Drawing.Size(100, 20);
            this.LblPlayer2.TabIndex = 16;
            // 
            // LblPlayer4Score
            // 
            this.LblPlayer4Score.AutoSize = true;
            this.LblPlayer4Score.BackColor = System.Drawing.Color.Transparent;
            this.LblPlayer4Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlayer4Score.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblPlayer4Score.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LblPlayer4Score.Location = new System.Drawing.Point(132, 313);
            this.LblPlayer4Score.MaximumSize = new System.Drawing.Size(30, 16);
            this.LblPlayer4Score.MinimumSize = new System.Drawing.Size(30, 16);
            this.LblPlayer4Score.Name = "LblPlayer4Score";
            this.LblPlayer4Score.Size = new System.Drawing.Size(30, 16);
            this.LblPlayer4Score.TabIndex = 21;
            this.LblPlayer4Score.Text = "0";
            this.LblPlayer4Score.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblPlayer4
            // 
            this.LblPlayer4.AutoSize = true;
            this.LblPlayer4.BackColor = System.Drawing.Color.Transparent;
            this.LblPlayer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlayer4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblPlayer4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblPlayer4.Location = new System.Drawing.Point(26, 310);
            this.LblPlayer4.MaximumSize = new System.Drawing.Size(100, 20);
            this.LblPlayer4.MinimumSize = new System.Drawing.Size(100, 20);
            this.LblPlayer4.Name = "LblPlayer4";
            this.LblPlayer4.Size = new System.Drawing.Size(100, 20);
            this.LblPlayer4.TabIndex = 20;
            // 
            // LblPlayer3Score
            // 
            this.LblPlayer3Score.AutoSize = true;
            this.LblPlayer3Score.BackColor = System.Drawing.Color.Transparent;
            this.LblPlayer3Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlayer3Score.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblPlayer3Score.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LblPlayer3Score.Location = new System.Drawing.Point(132, 293);
            this.LblPlayer3Score.MaximumSize = new System.Drawing.Size(30, 16);
            this.LblPlayer3Score.MinimumSize = new System.Drawing.Size(30, 16);
            this.LblPlayer3Score.Name = "LblPlayer3Score";
            this.LblPlayer3Score.Size = new System.Drawing.Size(30, 16);
            this.LblPlayer3Score.TabIndex = 19;
            this.LblPlayer3Score.Text = "0";
            this.LblPlayer3Score.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblPlayer3
            // 
            this.LblPlayer3.AutoSize = true;
            this.LblPlayer3.BackColor = System.Drawing.Color.Transparent;
            this.LblPlayer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlayer3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblPlayer3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblPlayer3.Location = new System.Drawing.Point(26, 290);
            this.LblPlayer3.MaximumSize = new System.Drawing.Size(100, 20);
            this.LblPlayer3.MinimumSize = new System.Drawing.Size(100, 20);
            this.LblPlayer3.Name = "LblPlayer3";
            this.LblPlayer3.Size = new System.Drawing.Size(100, 20);
            this.LblPlayer3.TabIndex = 18;
            // 
            // PctFirst
            // 
            this.PctFirst.BackColor = System.Drawing.Color.Transparent;
            this.PctFirst.Image = global::CamelUp.Properties.Resources.cardFirst;
            this.PctFirst.Location = new System.Drawing.Point(30, 350);
            this.PctFirst.Name = "PctFirst";
            this.PctFirst.Size = new System.Drawing.Size(59, 88);
            this.PctFirst.TabIndex = 22;
            this.PctFirst.TabStop = false;
            this.PctFirst.Click += new System.EventHandler(this.PctFirst_Click);
            this.PctFirst.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PctFirst_Down);
            this.PctFirst.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PctFirst_Up);
            // 
            // PctLast
            // 
            this.PctLast.BackColor = System.Drawing.Color.Transparent;
            this.PctLast.Image = global::CamelUp.Properties.Resources.cardLast;
            this.PctLast.Location = new System.Drawing.Point(98, 350);
            this.PctLast.Name = "PctLast";
            this.PctLast.Size = new System.Drawing.Size(59, 88);
            this.PctLast.TabIndex = 23;
            this.PctLast.TabStop = false;
            this.PctLast.Click += new System.EventHandler(this.PctLast_Click);
            this.PctLast.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PctLast_Down);
            this.PctLast.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PctLast_Up);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(836, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouvellePartieToolStripMenuItem,
            this.toolStripMenuItem1,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.àProposToolStripMenuItem});
            this.aideToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // Tmr1
            // 
            this.Tmr1.Interval = 1000;
            this.Tmr1.Tick += new System.EventHandler(this.Tmr1_Tick);
            // 
            // LblPlayerName1
            // 
            this.LblPlayerName1.AutoSize = true;
            this.LblPlayerName1.BackColor = System.Drawing.Color.Transparent;
            this.LblPlayerName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlayerName1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblPlayerName1.Location = new System.Drawing.Point(669, 44);
            this.LblPlayerName1.MaximumSize = new System.Drawing.Size(147, 24);
            this.LblPlayerName1.MinimumSize = new System.Drawing.Size(147, 24);
            this.LblPlayerName1.Name = "LblPlayerName1";
            this.LblPlayerName1.Size = new System.Drawing.Size(147, 24);
            this.LblPlayerName1.TabIndex = 25;
            this.LblPlayerName1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblPlayerName2
            // 
            this.LblPlayerName2.AutoSize = true;
            this.LblPlayerName2.BackColor = System.Drawing.Color.Transparent;
            this.LblPlayerName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlayerName2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblPlayerName2.Location = new System.Drawing.Point(669, 187);
            this.LblPlayerName2.MaximumSize = new System.Drawing.Size(147, 24);
            this.LblPlayerName2.MinimumSize = new System.Drawing.Size(147, 24);
            this.LblPlayerName2.Name = "LblPlayerName2";
            this.LblPlayerName2.Size = new System.Drawing.Size(147, 24);
            this.LblPlayerName2.TabIndex = 26;
            this.LblPlayerName2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblPlayerName4
            // 
            this.LblPlayerName4.AutoSize = true;
            this.LblPlayerName4.BackColor = System.Drawing.Color.Transparent;
            this.LblPlayerName4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlayerName4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblPlayerName4.Location = new System.Drawing.Point(669, 473);
            this.LblPlayerName4.MaximumSize = new System.Drawing.Size(147, 24);
            this.LblPlayerName4.MinimumSize = new System.Drawing.Size(147, 24);
            this.LblPlayerName4.Name = "LblPlayerName4";
            this.LblPlayerName4.Size = new System.Drawing.Size(147, 24);
            this.LblPlayerName4.TabIndex = 28;
            this.LblPlayerName4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblPlayerName3
            // 
            this.LblPlayerName3.AutoSize = true;
            this.LblPlayerName3.BackColor = System.Drawing.Color.Transparent;
            this.LblPlayerName3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlayerName3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblPlayerName3.Location = new System.Drawing.Point(669, 330);
            this.LblPlayerName3.MaximumSize = new System.Drawing.Size(147, 24);
            this.LblPlayerName3.MinimumSize = new System.Drawing.Size(147, 24);
            this.LblPlayerName3.Name = "LblPlayerName3";
            this.LblPlayerName3.Size = new System.Drawing.Size(147, 24);
            this.LblPlayerName3.TabIndex = 27;
            this.LblPlayerName3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlPlayerCards1
            // 
            this.PnlPlayerCards1.BackColor = System.Drawing.Color.Transparent;
            this.PnlPlayerCards1.Controls.Add(this.panel1);
            this.PnlPlayerCards1.Location = new System.Drawing.Point(681, 77);
            this.PnlPlayerCards1.Name = "PnlPlayerCards1";
            this.PnlPlayerCards1.Size = new System.Drawing.Size(121, 91);
            this.PnlPlayerCards1.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 91);
            this.panel1.TabIndex = 30;
            // 
            // PnlPlayerCards2
            // 
            this.PnlPlayerCards2.BackColor = System.Drawing.Color.Transparent;
            this.PnlPlayerCards2.Controls.Add(this.panel3);
            this.PnlPlayerCards2.Location = new System.Drawing.Point(681, 220);
            this.PnlPlayerCards2.Name = "PnlPlayerCards2";
            this.PnlPlayerCards2.Size = new System.Drawing.Size(121, 91);
            this.PnlPlayerCards2.TabIndex = 31;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(0, 144);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(121, 91);
            this.panel3.TabIndex = 30;
            // 
            // PnlPlayerCards4
            // 
            this.PnlPlayerCards4.BackColor = System.Drawing.Color.Transparent;
            this.PnlPlayerCards4.Controls.Add(this.panel4);
            this.PnlPlayerCards4.Location = new System.Drawing.Point(681, 506);
            this.PnlPlayerCards4.Name = "PnlPlayerCards4";
            this.PnlPlayerCards4.Size = new System.Drawing.Size(121, 91);
            this.PnlPlayerCards4.TabIndex = 33;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Location = new System.Drawing.Point(0, 144);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(121, 91);
            this.panel4.TabIndex = 30;
            // 
            // PnlPlayerCards3
            // 
            this.PnlPlayerCards3.BackColor = System.Drawing.Color.Transparent;
            this.PnlPlayerCards3.Controls.Add(this.panel6);
            this.PnlPlayerCards3.Location = new System.Drawing.Point(681, 363);
            this.PnlPlayerCards3.Name = "PnlPlayerCards3";
            this.PnlPlayerCards3.Size = new System.Drawing.Size(121, 91);
            this.PnlPlayerCards3.TabIndex = 32;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Location = new System.Drawing.Point(0, 144);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(121, 91);
            this.panel6.TabIndex = 30;
            // 
            // nouvellePartieToolStripMenuItem
            // 
            this.nouvellePartieToolStripMenuItem.Name = "nouvellePartieToolStripMenuItem";
            this.nouvellePartieToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.nouvellePartieToolStripMenuItem.Text = "Nouvelle partie";
            this.nouvellePartieToolStripMenuItem.Click += new System.EventHandler(this.nouvellePartieToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(151, 6);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // àProposToolStripMenuItem
            // 
            this.àProposToolStripMenuItem.Name = "àProposToolStripMenuItem";
            this.àProposToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.àProposToolStripMenuItem.Text = "À propos";
            this.àProposToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.àProposToolStripMenuItem.Click += new System.EventHandler(this.àProposToolStripMenuItem_Click);
            // 
            // LblCase15
            // 
            this.LblCase15.AutoSize = true;
            this.LblCase15.BackColor = System.Drawing.Color.Transparent;
            this.LblCase15.Location = new System.Drawing.Point(556, 164);
            this.LblCase15.MinimumSize = new System.Drawing.Size(91, 74);
            this.LblCase15.Name = "LblCase15";
            this.LblCase15.Size = new System.Drawing.Size(91, 74);
            this.LblCase15.TabIndex = 50;
            // 
            // LblCase14
            // 
            this.LblCase14.AutoSize = true;
            this.LblCase14.BackColor = System.Drawing.Color.Transparent;
            this.LblCase14.Location = new System.Drawing.Point(556, 86);
            this.LblCase14.MinimumSize = new System.Drawing.Size(91, 74);
            this.LblCase14.Name = "LblCase14";
            this.LblCase14.Size = new System.Drawing.Size(91, 74);
            this.LblCase14.TabIndex = 49;
            // 
            // LblCase13
            // 
            this.LblCase13.AutoSize = true;
            this.LblCase13.BackColor = System.Drawing.Color.Transparent;
            this.LblCase13.Location = new System.Drawing.Point(463, 86);
            this.LblCase13.MinimumSize = new System.Drawing.Size(91, 74);
            this.LblCase13.Name = "LblCase13";
            this.LblCase13.Size = new System.Drawing.Size(91, 74);
            this.LblCase13.TabIndex = 48;
            // 
            // LblCase12
            // 
            this.LblCase12.AutoSize = true;
            this.LblCase12.BackColor = System.Drawing.Color.Transparent;
            this.LblCase12.Location = new System.Drawing.Point(371, 86);
            this.LblCase12.MinimumSize = new System.Drawing.Size(91, 74);
            this.LblCase12.Name = "LblCase12";
            this.LblCase12.Size = new System.Drawing.Size(91, 74);
            this.LblCase12.TabIndex = 47;
            // 
            // LblCase11
            // 
            this.LblCase11.AutoSize = true;
            this.LblCase11.BackColor = System.Drawing.Color.Transparent;
            this.LblCase11.Location = new System.Drawing.Point(279, 86);
            this.LblCase11.MinimumSize = new System.Drawing.Size(91, 74);
            this.LblCase11.Name = "LblCase11";
            this.LblCase11.Size = new System.Drawing.Size(91, 74);
            this.LblCase11.TabIndex = 46;
            // 
            // LblCase10
            // 
            this.LblCase10.AutoSize = true;
            this.LblCase10.BackColor = System.Drawing.Color.Transparent;
            this.LblCase10.Location = new System.Drawing.Point(181, 86);
            this.LblCase10.MinimumSize = new System.Drawing.Size(91, 74);
            this.LblCase10.Name = "LblCase10";
            this.LblCase10.Size = new System.Drawing.Size(91, 74);
            this.LblCase10.TabIndex = 45;
            // 
            // LblCase9
            // 
            this.LblCase9.AutoSize = true;
            this.LblCase9.BackColor = System.Drawing.Color.Transparent;
            this.LblCase9.Location = new System.Drawing.Point(181, 164);
            this.LblCase9.MinimumSize = new System.Drawing.Size(91, 74);
            this.LblCase9.Name = "LblCase9";
            this.LblCase9.Size = new System.Drawing.Size(91, 74);
            this.LblCase9.TabIndex = 44;
            // 
            // LblCase8
            // 
            this.LblCase8.AutoSize = true;
            this.LblCase8.BackColor = System.Drawing.Color.Transparent;
            this.LblCase8.Location = new System.Drawing.Point(181, 246);
            this.LblCase8.MinimumSize = new System.Drawing.Size(91, 74);
            this.LblCase8.Name = "LblCase8";
            this.LblCase8.Size = new System.Drawing.Size(91, 74);
            this.LblCase8.TabIndex = 43;
            // 
            // LblCase7
            // 
            this.LblCase7.AutoSize = true;
            this.LblCase7.BackColor = System.Drawing.Color.Transparent;
            this.LblCase7.Location = new System.Drawing.Point(181, 332);
            this.LblCase7.MinimumSize = new System.Drawing.Size(91, 74);
            this.LblCase7.Name = "LblCase7";
            this.LblCase7.Size = new System.Drawing.Size(91, 74);
            this.LblCase7.TabIndex = 42;
            // 
            // LblCase6
            // 
            this.LblCase6.AutoSize = true;
            this.LblCase6.BackColor = System.Drawing.Color.Transparent;
            this.LblCase6.Location = new System.Drawing.Point(181, 410);
            this.LblCase6.MinimumSize = new System.Drawing.Size(91, 74);
            this.LblCase6.Name = "LblCase6";
            this.LblCase6.Size = new System.Drawing.Size(91, 74);
            this.LblCase6.TabIndex = 41;
            // 
            // LblCase5
            // 
            this.LblCase5.AutoSize = true;
            this.LblCase5.BackColor = System.Drawing.Color.Transparent;
            this.LblCase5.Location = new System.Drawing.Point(279, 410);
            this.LblCase5.MinimumSize = new System.Drawing.Size(91, 74);
            this.LblCase5.Name = "LblCase5";
            this.LblCase5.Size = new System.Drawing.Size(91, 74);
            this.LblCase5.TabIndex = 40;
            // 
            // LblCase4
            // 
            this.LblCase4.AutoSize = true;
            this.LblCase4.BackColor = System.Drawing.Color.Transparent;
            this.LblCase4.Location = new System.Drawing.Point(371, 410);
            this.LblCase4.MinimumSize = new System.Drawing.Size(91, 74);
            this.LblCase4.Name = "LblCase4";
            this.LblCase4.Size = new System.Drawing.Size(91, 74);
            this.LblCase4.TabIndex = 39;
            // 
            // cell4
            // 
            this.cell4.AutoSize = true;
            this.cell4.BackColor = System.Drawing.Color.Transparent;
            this.cell4.Location = new System.Drawing.Point(371, 410);
            this.cell4.MinimumSize = new System.Drawing.Size(91, 74);
            this.cell4.Name = "cell4";
            this.cell4.Size = new System.Drawing.Size(91, 74);
            this.cell4.TabIndex = 38;
            // 
            // LblCase3
            // 
            this.LblCase3.AutoSize = true;
            this.LblCase3.BackColor = System.Drawing.Color.Transparent;
            this.LblCase3.Location = new System.Drawing.Point(463, 410);
            this.LblCase3.MinimumSize = new System.Drawing.Size(91, 74);
            this.LblCase3.Name = "LblCase3";
            this.LblCase3.Size = new System.Drawing.Size(91, 74);
            this.LblCase3.TabIndex = 37;
            // 
            // LblCase2
            // 
            this.LblCase2.AutoSize = true;
            this.LblCase2.BackColor = System.Drawing.Color.Transparent;
            this.LblCase2.Location = new System.Drawing.Point(556, 410);
            this.LblCase2.MinimumSize = new System.Drawing.Size(91, 74);
            this.LblCase2.Name = "LblCase2";
            this.LblCase2.Size = new System.Drawing.Size(91, 74);
            this.LblCase2.TabIndex = 36;
            // 
            // LblCase1
            // 
            this.LblCase1.AutoSize = true;
            this.LblCase1.BackColor = System.Drawing.Color.Transparent;
            this.LblCase1.Location = new System.Drawing.Point(556, 332);
            this.LblCase1.MinimumSize = new System.Drawing.Size(91, 74);
            this.LblCase1.Name = "LblCase1";
            this.LblCase1.Size = new System.Drawing.Size(91, 74);
            this.LblCase1.TabIndex = 35;
            // 
            // LblCase0
            // 
            this.LblCase0.AutoSize = true;
            this.LblCase0.BackColor = System.Drawing.Color.Transparent;
            this.LblCase0.Location = new System.Drawing.Point(556, 246);
            this.LblCase0.MinimumSize = new System.Drawing.Size(91, 74);
            this.LblCase0.Name = "LblCase0";
            this.LblCase0.Size = new System.Drawing.Size(91, 74);
            this.LblCase0.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(82)))), ((int)(((byte)(24)))));
            this.BackgroundImage = global::CamelUp.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(836, 646);
            this.Controls.Add(this.LblCase15);
            this.Controls.Add(this.LblCase14);
            this.Controls.Add(this.LblCase13);
            this.Controls.Add(this.LblCase12);
            this.Controls.Add(this.LblCase11);
            this.Controls.Add(this.LblCase10);
            this.Controls.Add(this.LblCase9);
            this.Controls.Add(this.LblCase8);
            this.Controls.Add(this.LblCase7);
            this.Controls.Add(this.LblCase6);
            this.Controls.Add(this.LblCase5);
            this.Controls.Add(this.LblCase4);
            this.Controls.Add(this.cell4);
            this.Controls.Add(this.LblCase3);
            this.Controls.Add(this.LblCase2);
            this.Controls.Add(this.LblCase1);
            this.Controls.Add(this.LblCase0);
            this.Controls.Add(this.PnlPlayerCards4);
            this.Controls.Add(this.PnlPlayerCards2);
            this.Controls.Add(this.PnlPlayerCards3);
            this.Controls.Add(this.PnlPlayerCards1);
            this.Controls.Add(this.LblPlayerName4);
            this.Controls.Add(this.LblPlayerName3);
            this.Controls.Add(this.LblPlayerName2);
            this.Controls.Add(this.LblPlayerName1);
            this.Controls.Add(this.PctLast);
            this.Controls.Add(this.PctFirst);
            this.Controls.Add(this.LblPlayer4Score);
            this.Controls.Add(this.LblPlayer4);
            this.Controls.Add(this.LblPlayer3Score);
            this.Controls.Add(this.LblPlayer3);
            this.Controls.Add(this.LblPlayer2Score);
            this.Controls.Add(this.LblPlayer2);
            this.Controls.Add(this.LblPlayer1Score);
            this.Controls.Add(this.LblPlayer1);
            this.Controls.Add(this.LblLastPlaceInfo);
            this.Controls.Add(this.LblFirstPlaceInfo);
            this.Controls.Add(this.LblRoundNum);
            this.Controls.Add(this.LblTimer);
            this.Controls.Add(this.LblLastPlace);
            this.Controls.Add(this.LblFirstPlace);
            this.Controls.Add(this.LblRound);
            this.Controls.Add(this.LblTime);
            this.Controls.Add(this.LblDiceG);
            this.Controls.Add(this.LblDiceO);
            this.Controls.Add(this.LblDiceY);
            this.Controls.Add(this.LblDiceW);
            this.Controls.Add(this.LblDiceB);
            this.Controls.Add(this.PnlCartes);
            this.Controls.Add(this.PnlPyramide);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(852, 685);
            this.MinimumSize = new System.Drawing.Size(852, 685);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Camel Up";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.PctFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctLast)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PnlPlayerCards1.ResumeLayout(false);
            this.PnlPlayerCards2.ResumeLayout(false);
            this.PnlPlayerCards4.ResumeLayout(false);
            this.PnlPlayerCards3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlPyramide;
        private System.Windows.Forms.Panel PnlCartes;
        private System.Windows.Forms.Label LblDiceB;
        private System.Windows.Forms.Label LblDiceW;
        private System.Windows.Forms.Label LblDiceY;
        private System.Windows.Forms.Label LblDiceO;
        private System.Windows.Forms.Label LblDiceG;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Label LblRound;
        private System.Windows.Forms.Label LblLastPlace;
        private System.Windows.Forms.Label LblFirstPlace;
        private System.Windows.Forms.Label LblTimer;
        private System.Windows.Forms.Label LblRoundNum;
        private System.Windows.Forms.Label LblLastPlaceInfo;
        private System.Windows.Forms.Label LblFirstPlaceInfo;
        private System.Windows.Forms.Label LblPlayer1Score;
        private System.Windows.Forms.Label LblPlayer1;
        private System.Windows.Forms.Label LblPlayer2Score;
        private System.Windows.Forms.Label LblPlayer2;
        private System.Windows.Forms.Label LblPlayer4Score;
        private System.Windows.Forms.Label LblPlayer4;
        private System.Windows.Forms.Label LblPlayer3Score;
        private System.Windows.Forms.Label LblPlayer3;
        private System.Windows.Forms.PictureBox PctFirst;
        private System.Windows.Forms.PictureBox PctLast;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.Timer Tmr1;
        private System.Windows.Forms.Label LblPlayerName1;
        private System.Windows.Forms.Label LblPlayerName2;
        private System.Windows.Forms.Label LblPlayerName4;
        private System.Windows.Forms.Label LblPlayerName3;
        private System.Windows.Forms.Panel PnlPlayerCards1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PnlPlayerCards2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel PnlPlayerCards4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel PnlPlayerCards3;
        private System.Windows.Forms.Panel panel6;
        private Cell LblCase0;
        private Cell LblCase1;
        private Cell LblCase2;
        private Cell LblCase3;
        private Cell cell4;
        private Cell LblCase4;
        private Cell LblCase5;
        private Cell LblCase6;
        private Cell LblCase7;
        private Cell LblCase8;
        private Cell LblCase9;
        private Cell LblCase10;
        private Cell LblCase11;
        private Cell LblCase12;
        private Cell LblCase13;
        private Cell LblCase14;
        private Cell LblCase15;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem nouvellePartieToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem àProposToolStripMenuItem;
    }
}

