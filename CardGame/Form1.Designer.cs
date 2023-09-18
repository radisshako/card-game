namespace ArchaelogyGame1
{
    partial class Form1
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
            this.listBoxPlayersDeck = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxMarket = new System.Windows.Forms.ListBox();
            this.textBoxPlayerBalance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPlayerDrawn = new System.Windows.Forms.TextBox();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.buttonDig = new System.Windows.Forms.Button();
            this.buttonTrade = new System.Windows.Forms.Button();
            this.buttonExplore = new System.Windows.Forms.Button();
            this.buttonSell = new System.Windows.Forms.Button();
            this.buttonEnd = new System.Windows.Forms.Button();
            this.buttonEndOppponent = new System.Windows.Forms.Button();
            this.buttonSellOpponent = new System.Windows.Forms.Button();
            this.buttonExploreOpponent = new System.Windows.Forms.Button();
            this.buttonTradeOpponenet = new System.Windows.Forms.Button();
            this.buttonDigOpponent = new System.Windows.Forms.Button();
            this.buttonNewGameOpponent = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxOpponentDrawn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxOpponentBalance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listBoxOpponentsDeck = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonSandstormPlayer = new System.Windows.Forms.Button();
            this.buttonStartPlayPlayer = new System.Windows.Forms.Button();
            this.buttonStartPlayOpponent = new System.Windows.Forms.Button();
            this.buttonSandstormOpponent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxPlayersDeck
            // 
            this.listBoxPlayersDeck.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPlayersDeck.FormattingEnabled = true;
            this.listBoxPlayersDeck.ItemHeight = 14;
            this.listBoxPlayersDeck.Location = new System.Drawing.Point(12, 537);
            this.listBoxPlayersDeck.Name = "listBoxPlayersDeck";
            this.listBoxPlayersDeck.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxPlayersDeck.Size = new System.Drawing.Size(756, 200);
            this.listBoxPlayersDeck.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 502);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Players Deck";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Marketplace";
            // 
            // listBoxMarket
            // 
            this.listBoxMarket.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMarket.FormattingEnabled = true;
            this.listBoxMarket.ItemHeight = 14;
            this.listBoxMarket.Location = new System.Drawing.Point(24, 298);
            this.listBoxMarket.Name = "listBoxMarket";
            this.listBoxMarket.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxMarket.Size = new System.Drawing.Size(756, 172);
            this.listBoxMarket.TabIndex = 2;
            // 
            // textBoxPlayerBalance
            // 
            this.textBoxPlayerBalance.Location = new System.Drawing.Point(168, 511);
            this.textBoxPlayerBalance.Name = "textBoxPlayerBalance";
            this.textBoxPlayerBalance.Size = new System.Drawing.Size(109, 20);
            this.textBoxPlayerBalance.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(164, 488);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Balance for Player:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(326, 488);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Currently Drawn Card:";
            // 
            // textBoxPlayerDrawn
            // 
            this.textBoxPlayerDrawn.Location = new System.Drawing.Point(330, 511);
            this.textBoxPlayerDrawn.Name = "textBoxPlayerDrawn";
            this.textBoxPlayerDrawn.Size = new System.Drawing.Size(109, 20);
            this.textBoxPlayerDrawn.TabIndex = 6;
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewGame.Location = new System.Drawing.Point(774, 627);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(85, 33);
            this.buttonNewGame.TabIndex = 8;
            this.buttonNewGame.Text = "New Game";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // buttonDig
            // 
            this.buttonDig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDig.Location = new System.Drawing.Point(879, 606);
            this.buttonDig.Name = "buttonDig";
            this.buttonDig.Size = new System.Drawing.Size(85, 33);
            this.buttonDig.TabIndex = 9;
            this.buttonDig.Text = "Dig";
            this.buttonDig.UseVisualStyleBackColor = true;
            this.buttonDig.Click += new System.EventHandler(this.buttonDig_Click);
            // 
            // buttonTrade
            // 
            this.buttonTrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTrade.Location = new System.Drawing.Point(879, 661);
            this.buttonTrade.Name = "buttonTrade";
            this.buttonTrade.Size = new System.Drawing.Size(85, 33);
            this.buttonTrade.TabIndex = 10;
            this.buttonTrade.Text = "Trade";
            this.buttonTrade.UseVisualStyleBackColor = true;
            this.buttonTrade.Click += new System.EventHandler(this.buttonTrade_Click);
            // 
            // buttonExplore
            // 
            this.buttonExplore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExplore.Location = new System.Drawing.Point(970, 606);
            this.buttonExplore.Name = "buttonExplore";
            this.buttonExplore.Size = new System.Drawing.Size(85, 33);
            this.buttonExplore.TabIndex = 11;
            this.buttonExplore.Text = "Explore";
            this.buttonExplore.UseVisualStyleBackColor = true;
            this.buttonExplore.Click += new System.EventHandler(this.buttonExplore_Click);
            // 
            // buttonSell
            // 
            this.buttonSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSell.Location = new System.Drawing.Point(975, 661);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(85, 33);
            this.buttonSell.TabIndex = 12;
            this.buttonSell.Text = "Sell";
            this.buttonSell.UseVisualStyleBackColor = true;
            this.buttonSell.Click += new System.EventHandler(this.buttonSell_Click);
            // 
            // buttonEnd
            // 
            this.buttonEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnd.Location = new System.Drawing.Point(975, 549);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(85, 33);
            this.buttonEnd.TabIndex = 13;
            this.buttonEnd.Text = "End Play";
            this.buttonEnd.UseVisualStyleBackColor = true;
            this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // buttonEndOppponent
            // 
            this.buttonEndOppponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEndOppponent.Location = new System.Drawing.Point(987, 82);
            this.buttonEndOppponent.Name = "buttonEndOppponent";
            this.buttonEndOppponent.Size = new System.Drawing.Size(85, 33);
            this.buttonEndOppponent.TabIndex = 25;
            this.buttonEndOppponent.Text = "End Play";
            this.buttonEndOppponent.UseVisualStyleBackColor = true;
            this.buttonEndOppponent.Click += new System.EventHandler(this.buttonEndOppponent_Click);
            // 
            // buttonSellOpponent
            // 
            this.buttonSellOpponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSellOpponent.Location = new System.Drawing.Point(987, 189);
            this.buttonSellOpponent.Name = "buttonSellOpponent";
            this.buttonSellOpponent.Size = new System.Drawing.Size(85, 33);
            this.buttonSellOpponent.TabIndex = 24;
            this.buttonSellOpponent.Text = "Sell";
            this.buttonSellOpponent.UseVisualStyleBackColor = true;
            this.buttonSellOpponent.Click += new System.EventHandler(this.buttonSellOpponent_Click);
            // 
            // buttonExploreOpponent
            // 
            this.buttonExploreOpponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExploreOpponent.Location = new System.Drawing.Point(982, 134);
            this.buttonExploreOpponent.Name = "buttonExploreOpponent";
            this.buttonExploreOpponent.Size = new System.Drawing.Size(85, 33);
            this.buttonExploreOpponent.TabIndex = 23;
            this.buttonExploreOpponent.Text = "Explore";
            this.buttonExploreOpponent.UseVisualStyleBackColor = true;
            // 
            // buttonTradeOpponenet
            // 
            this.buttonTradeOpponenet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTradeOpponenet.Location = new System.Drawing.Point(891, 189);
            this.buttonTradeOpponenet.Name = "buttonTradeOpponenet";
            this.buttonTradeOpponenet.Size = new System.Drawing.Size(85, 33);
            this.buttonTradeOpponenet.TabIndex = 22;
            this.buttonTradeOpponenet.Text = "Trade";
            this.buttonTradeOpponenet.UseVisualStyleBackColor = true;
            this.buttonTradeOpponenet.Click += new System.EventHandler(this.buttonTradeOpponenet_Click);
            // 
            // buttonDigOpponent
            // 
            this.buttonDigOpponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDigOpponent.Location = new System.Drawing.Point(891, 134);
            this.buttonDigOpponent.Name = "buttonDigOpponent";
            this.buttonDigOpponent.Size = new System.Drawing.Size(85, 33);
            this.buttonDigOpponent.TabIndex = 21;
            this.buttonDigOpponent.Text = "Dig";
            this.buttonDigOpponent.UseVisualStyleBackColor = true;
            this.buttonDigOpponent.Click += new System.EventHandler(this.buttonDigOpponent_Click);
            // 
            // buttonNewGameOpponent
            // 
            this.buttonNewGameOpponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewGameOpponent.Location = new System.Drawing.Point(786, 134);
            this.buttonNewGameOpponent.Name = "buttonNewGameOpponent";
            this.buttonNewGameOpponent.Size = new System.Drawing.Size(85, 33);
            this.buttonNewGameOpponent.TabIndex = 20;
            this.buttonNewGameOpponent.Text = "New Game";
            this.buttonNewGameOpponent.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(388, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Currently Drawn Card:";
            // 
            // textBoxOpponentDrawn
            // 
            this.textBoxOpponentDrawn.Location = new System.Drawing.Point(392, 39);
            this.textBoxOpponentDrawn.Name = "textBoxOpponentDrawn";
            this.textBoxOpponentDrawn.Size = new System.Drawing.Size(109, 20);
            this.textBoxOpponentDrawn.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(202, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Balance for Opponent:";
            // 
            // textBoxOpponentBalance
            // 
            this.textBoxOpponentBalance.Location = new System.Drawing.Point(206, 39);
            this.textBoxOpponentBalance.Name = "textBoxOpponentBalance";
            this.textBoxOpponentBalance.Size = new System.Drawing.Size(109, 20);
            this.textBoxOpponentBalance.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Opponents Deck";
            // 
            // listBoxOpponentsDeck
            // 
            this.listBoxOpponentsDeck.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxOpponentsDeck.FormattingEnabled = true;
            this.listBoxOpponentsDeck.ItemHeight = 14;
            this.listBoxOpponentsDeck.Location = new System.Drawing.Point(24, 65);
            this.listBoxOpponentsDeck.Name = "listBoxOpponentsDeck";
            this.listBoxOpponentsDeck.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxOpponentsDeck.Size = new System.Drawing.Size(756, 200);
            this.listBoxOpponentsDeck.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(846, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 26;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // buttonSandstormPlayer
            // 
            this.buttonSandstormPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSandstormPlayer.Location = new System.Drawing.Point(1088, 606);
            this.buttonSandstormPlayer.Name = "buttonSandstormPlayer";
            this.buttonSandstormPlayer.Size = new System.Drawing.Size(85, 33);
            this.buttonSandstormPlayer.TabIndex = 27;
            this.buttonSandstormPlayer.Text = "SandStorm";
            this.buttonSandstormPlayer.UseVisualStyleBackColor = true;
            this.buttonSandstormPlayer.Click += new System.EventHandler(this.buttonSandstormPlayer_Click);
            // 
            // buttonStartPlayPlayer
            // 
            this.buttonStartPlayPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartPlayPlayer.Location = new System.Drawing.Point(879, 549);
            this.buttonStartPlayPlayer.Name = "buttonStartPlayPlayer";
            this.buttonStartPlayPlayer.Size = new System.Drawing.Size(85, 33);
            this.buttonStartPlayPlayer.TabIndex = 28;
            this.buttonStartPlayPlayer.Text = "Start Play";
            this.buttonStartPlayPlayer.UseVisualStyleBackColor = true;
            this.buttonStartPlayPlayer.Click += new System.EventHandler(this.buttonStartPlayPlayer_Click);
            // 
            // buttonStartPlayOpponent
            // 
            this.buttonStartPlayOpponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartPlayOpponent.Location = new System.Drawing.Point(891, 82);
            this.buttonStartPlayOpponent.Name = "buttonStartPlayOpponent";
            this.buttonStartPlayOpponent.Size = new System.Drawing.Size(85, 33);
            this.buttonStartPlayOpponent.TabIndex = 29;
            this.buttonStartPlayOpponent.Text = "Start Play";
            this.buttonStartPlayOpponent.UseVisualStyleBackColor = true;
            // 
            // buttonSandstormOpponent
            // 
            this.buttonSandstormOpponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSandstormOpponent.Location = new System.Drawing.Point(1092, 134);
            this.buttonSandstormOpponent.Name = "buttonSandstormOpponent";
            this.buttonSandstormOpponent.Size = new System.Drawing.Size(85, 33);
            this.buttonSandstormOpponent.TabIndex = 30;
            this.buttonSandstormOpponent.Text = "SandStorm";
            this.buttonSandstormOpponent.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 749);
            this.Controls.Add(this.buttonSellOpponent);
            this.Controls.Add(this.buttonSandstormOpponent);
            this.Controls.Add(this.buttonStartPlayOpponent);
            this.Controls.Add(this.buttonStartPlayPlayer);
            this.Controls.Add(this.buttonSandstormPlayer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonEndOppponent);
            this.Controls.Add(this.buttonExploreOpponent);
            this.Controls.Add(this.buttonTradeOpponenet);
            this.Controls.Add(this.buttonDigOpponent);
            this.Controls.Add(this.buttonNewGameOpponent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxOpponentDrawn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxOpponentBalance);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBoxOpponentsDeck);
            this.Controls.Add(this.buttonEnd);
            this.Controls.Add(this.buttonSell);
            this.Controls.Add(this.buttonExplore);
            this.Controls.Add(this.buttonTrade);
            this.Controls.Add(this.buttonDig);
            this.Controls.Add(this.buttonNewGame);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPlayerDrawn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPlayerBalance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxMarket);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxPlayersDeck);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPlayersDeck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxMarket;
        private System.Windows.Forms.TextBox textBoxPlayerBalance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPlayerDrawn;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Button buttonDig;
        private System.Windows.Forms.Button buttonTrade;
        private System.Windows.Forms.Button buttonExplore;
        private System.Windows.Forms.Button buttonSell;
        private System.Windows.Forms.Button buttonEnd;
        private System.Windows.Forms.Button buttonEndOppponent;
        private System.Windows.Forms.Button buttonSellOpponent;
        private System.Windows.Forms.Button buttonExploreOpponent;
        private System.Windows.Forms.Button buttonTradeOpponenet;
        private System.Windows.Forms.Button buttonDigOpponent;
        private System.Windows.Forms.Button buttonNewGameOpponent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxOpponentDrawn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxOpponentBalance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBoxOpponentsDeck;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonSandstormPlayer;
        private System.Windows.Forms.Button buttonStartPlayPlayer;
        private System.Windows.Forms.Button buttonStartPlayOpponent;
        private System.Windows.Forms.Button buttonSandstormOpponent;
    }
}

