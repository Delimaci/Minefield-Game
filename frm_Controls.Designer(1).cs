namespace ProjectMinefield
{
    partial class frm_Controls
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
            this.components = new System.ComponentModel.Container();
            this.button6 = new System.Windows.Forms.Button();
            this.label402 = new System.Windows.Forms.Label();
            this.label403 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setDifficultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leaderboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(-3, -2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(73, 28);
            this.button6.TabIndex = 11;
            this.button6.Text = "Settings";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label402
            // 
            this.label402.AutoSize = true;
            this.label402.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label402.Location = new System.Drawing.Point(220, 5);
            this.label402.Name = "label402";
            this.label402.Size = new System.Drawing.Size(100, 22);
            this.label402.TabIndex = 12;
            this.label402.Text = "Minefield";
            // 
            // label403
            // 
            this.label403.AutoSize = true;
            this.label403.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label403.Location = new System.Drawing.Point(237, 25);
            this.label403.Name = "label403";
            this.label403.Size = new System.Drawing.Size(66, 18);
            this.label403.TabIndex = 13;
            this.label403.Text = "Controls";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Keyboard";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(265, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 429);
            this.panel1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mouse";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setDifficultyToolStripMenuItem,
            this.leaderboardToolStripMenuItem,
            this.controlsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 70);
            // 
            // setDifficultyToolStripMenuItem
            // 
            this.setDifficultyToolStripMenuItem.Name = "setDifficultyToolStripMenuItem";
            this.setDifficultyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setDifficultyToolStripMenuItem.Text = "Set Difficulty";
            // 
            // leaderboardToolStripMenuItem
            // 
            this.leaderboardToolStripMenuItem.Name = "leaderboardToolStripMenuItem";
            this.leaderboardToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.leaderboardToolStripMenuItem.Text = "Leaderboard";
            // 
            // controlsToolStripMenuItem
            // 
            this.controlsToolStripMenuItem.Name = "controlsToolStripMenuItem";
            this.controlsToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.controlsToolStripMenuItem.Text = "Game";
            this.controlsToolStripMenuItem.Click += new System.EventHandler(this.controlsToolStripMenuItem_Click);
            // 
            // frm_Controls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(540, 589);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label403);
            this.Controls.Add(this.label402);
            this.Controls.Add(this.button6);
            this.Name = "frm_Controls";
            this.Text = "frm_Controls";
            this.Load += new System.EventHandler(this.frm_Controls_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label402;
        private System.Windows.Forms.Label label403;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setDifficultyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leaderboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlsToolStripMenuItem;
    }
}