
namespace wf_TicTacToe
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.X1 = new System.Windows.Forms.Button();
            this.X2 = new System.Windows.Forms.Button();
            this.X3 = new System.Windows.Forms.Button();
            this.Y1 = new System.Windows.Forms.Button();
            this.Y2 = new System.Windows.Forms.Button();
            this.Y3 = new System.Windows.Forms.Button();
            this.Z1 = new System.Windows.Forms.Button();
            this.Z2 = new System.Windows.Forms.Button();
            this.Z3 = new System.Windows.Forms.Button();
            this.lblDisplayTurn = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.lblPlayerCol = new System.Windows.Forms.Label();
            this.lblScoreCol = new System.Windows.Forms.Label();
            this.lblPlayerX_Score = new System.Windows.Forms.Label();
            this.lblPlayerX = new System.Windows.Forms.Label();
            this.lblPlayerO_Score = new System.Windows.Forms.Label();
            this.lblPlayerO = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(565, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // X1
            // 
            this.X1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X1.Location = new System.Drawing.Point(49, 52);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(90, 90);
            this.X1.TabIndex = 1;
            this.X1.UseVisualStyleBackColor = true;
            this.X1.Click += new System.EventHandler(this.btnClick);
            // 
            // X2
            // 
            this.X2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X2.Location = new System.Drawing.Point(145, 52);
            this.X2.Name = "X2";
            this.X2.Size = new System.Drawing.Size(90, 90);
            this.X2.TabIndex = 2;
            this.X2.UseVisualStyleBackColor = true;
            this.X2.Click += new System.EventHandler(this.btnClick);
            // 
            // X3
            // 
            this.X3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X3.Location = new System.Drawing.Point(241, 52);
            this.X3.Name = "X3";
            this.X3.Size = new System.Drawing.Size(90, 90);
            this.X3.TabIndex = 3;
            this.X3.UseVisualStyleBackColor = true;
            this.X3.Click += new System.EventHandler(this.btnClick);
            // 
            // Y1
            // 
            this.Y1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Y1.Location = new System.Drawing.Point(49, 148);
            this.Y1.Name = "Y1";
            this.Y1.Size = new System.Drawing.Size(90, 90);
            this.Y1.TabIndex = 4;
            this.Y1.UseVisualStyleBackColor = true;
            this.Y1.Click += new System.EventHandler(this.btnClick);
            // 
            // Y2
            // 
            this.Y2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Y2.Location = new System.Drawing.Point(145, 148);
            this.Y2.Name = "Y2";
            this.Y2.Size = new System.Drawing.Size(90, 90);
            this.Y2.TabIndex = 5;
            this.Y2.UseVisualStyleBackColor = true;
            this.Y2.Click += new System.EventHandler(this.btnClick);
            // 
            // Y3
            // 
            this.Y3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Y3.Location = new System.Drawing.Point(241, 148);
            this.Y3.Name = "Y3";
            this.Y3.Size = new System.Drawing.Size(90, 90);
            this.Y3.TabIndex = 6;
            this.Y3.UseVisualStyleBackColor = true;
            this.Y3.Click += new System.EventHandler(this.btnClick);
            // 
            // Z1
            // 
            this.Z1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Z1.Location = new System.Drawing.Point(49, 244);
            this.Z1.Name = "Z1";
            this.Z1.Size = new System.Drawing.Size(90, 90);
            this.Z1.TabIndex = 7;
            this.Z1.UseVisualStyleBackColor = true;
            this.Z1.Click += new System.EventHandler(this.btnClick);
            // 
            // Z2
            // 
            this.Z2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Z2.Location = new System.Drawing.Point(145, 244);
            this.Z2.Name = "Z2";
            this.Z2.Size = new System.Drawing.Size(90, 90);
            this.Z2.TabIndex = 8;
            this.Z2.UseVisualStyleBackColor = true;
            this.Z2.Click += new System.EventHandler(this.btnClick);
            // 
            // Z3
            // 
            this.Z3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Z3.Location = new System.Drawing.Point(241, 244);
            this.Z3.Name = "Z3";
            this.Z3.Size = new System.Drawing.Size(90, 90);
            this.Z3.TabIndex = 9;
            this.Z3.UseVisualStyleBackColor = true;
            this.Z3.Click += new System.EventHandler(this.btnClick);
            // 
            // lblDisplayTurn
            // 
            this.lblDisplayTurn.BackColor = System.Drawing.SystemColors.Info;
            this.lblDisplayTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayTurn.Location = new System.Drawing.Point(337, 83);
            this.lblDisplayTurn.Name = "lblDisplayTurn";
            this.lblDisplayTurn.Size = new System.Drawing.Size(175, 59);
            this.lblDisplayTurn.TabIndex = 13;
            this.lblDisplayTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTurn
            // 
            this.lblTurn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTurn.Location = new System.Drawing.Point(337, 52);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(175, 31);
            this.lblTurn.TabIndex = 12;
            this.lblTurn.Text = "Turn";
            this.lblTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerCol
            // 
            this.lblPlayerCol.BackColor = System.Drawing.Color.LightGreen;
            this.lblPlayerCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerCol.Location = new System.Drawing.Point(339, 148);
            this.lblPlayerCol.Name = "lblPlayerCol";
            this.lblPlayerCol.Size = new System.Drawing.Size(76, 38);
            this.lblPlayerCol.TabIndex = 14;
            this.lblPlayerCol.Text = "Player";
            this.lblPlayerCol.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblScoreCol
            // 
            this.lblScoreCol.BackColor = System.Drawing.Color.LightGreen;
            this.lblScoreCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreCol.Location = new System.Drawing.Point(441, 148);
            this.lblScoreCol.Name = "lblScoreCol";
            this.lblScoreCol.Size = new System.Drawing.Size(72, 38);
            this.lblScoreCol.TabIndex = 15;
            this.lblScoreCol.Text = "Score";
            this.lblScoreCol.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPlayerX_Score
            // 
            this.lblPlayerX_Score.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblPlayerX_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerX_Score.Location = new System.Drawing.Point(441, 186);
            this.lblPlayerX_Score.Name = "lblPlayerX_Score";
            this.lblPlayerX_Score.Size = new System.Drawing.Size(72, 23);
            this.lblPlayerX_Score.TabIndex = 17;
            this.lblPlayerX_Score.Text = "0";
            this.lblPlayerX_Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerX
            // 
            this.lblPlayerX.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblPlayerX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerX.Location = new System.Drawing.Point(337, 186);
            this.lblPlayerX.Name = "lblPlayerX";
            this.lblPlayerX.Size = new System.Drawing.Size(76, 23);
            this.lblPlayerX.TabIndex = 16;
            this.lblPlayerX.Text = "X";
            this.lblPlayerX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerO_Score
            // 
            this.lblPlayerO_Score.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblPlayerO_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerO_Score.Location = new System.Drawing.Point(441, 215);
            this.lblPlayerO_Score.Name = "lblPlayerO_Score";
            this.lblPlayerO_Score.Size = new System.Drawing.Size(72, 23);
            this.lblPlayerO_Score.TabIndex = 19;
            this.lblPlayerO_Score.Text = "0";
            this.lblPlayerO_Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerO
            // 
            this.lblPlayerO.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblPlayerO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerO.Location = new System.Drawing.Point(337, 215);
            this.lblPlayerO.Name = "lblPlayerO";
            this.lblPlayerO.Size = new System.Drawing.Size(76, 23);
            this.lblPlayerO.TabIndex = 18;
            this.lblPlayerO.Text = "O";
            this.lblPlayerO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(337, 244);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(176, 45);
            this.btnNewGame.TabIndex = 22;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(337, 289);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(176, 45);
            this.btnReset.TabIndex = 23;
            this.btnReset.Text = "Reset Board";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 354);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(460, 122);
            this.dataGridView1.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 490);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblPlayerO_Score);
            this.Controls.Add(this.lblPlayerO);
            this.Controls.Add(this.lblPlayerX_Score);
            this.Controls.Add(this.lblPlayerX);
            this.Controls.Add(this.lblScoreCol);
            this.Controls.Add(this.lblPlayerCol);
            this.Controls.Add(this.lblDisplayTurn);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.Z3);
            this.Controls.Add(this.Z2);
            this.Controls.Add(this.Z1);
            this.Controls.Add(this.Y3);
            this.Controls.Add(this.Y2);
            this.Controls.Add(this.Y1);
            this.Controls.Add(this.X3);
            this.Controls.Add(this.X2);
            this.Controls.Add(this.X1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button X1;
        private System.Windows.Forms.Button X2;
        private System.Windows.Forms.Button X3;
        private System.Windows.Forms.Button Y1;
        private System.Windows.Forms.Button Y2;
        private System.Windows.Forms.Button Y3;
        private System.Windows.Forms.Button Z1;
        private System.Windows.Forms.Button Z2;
        private System.Windows.Forms.Button Z3;
        private System.Windows.Forms.Label lblDisplayTurn;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblPlayerCol;
        private System.Windows.Forms.Label lblScoreCol;
        private System.Windows.Forms.Label lblPlayerX_Score;
        private System.Windows.Forms.Label lblPlayerX;
        private System.Windows.Forms.Label lblPlayerO_Score;
        private System.Windows.Forms.Label lblPlayerO;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

