namespace ProjectMinefield
{
    partial class frm_Difficulty
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
            this.label402 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Begin = new System.Windows.Forms.Label();
            this.lbl_Amateur = new System.Windows.Forms.Label();
            this.lbl_Advanced = new System.Windows.Forms.Label();
            this.lbl_Expert = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxs_Controls = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxs_leaderboard = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxs_Game = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_Survival = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label402
            // 
            this.label402.AutoSize = true;
            this.label402.Font = new System.Drawing.Font("Corbel Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label402.ForeColor = System.Drawing.Color.Black;
            this.label402.Location = new System.Drawing.Point(609, 9);
            this.label402.Name = "label402";
            this.label402.Size = new System.Drawing.Size(203, 59);
            this.label402.TabIndex = 12;
            this.label402.Text = "Minefield";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(609, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 42);
            this.label1.TabIndex = 13;
            this.label1.Text = "Set Difficulty:";
            // 
            // lbl_Begin
            // 
            this.lbl_Begin.AutoSize = true;
            this.lbl_Begin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Begin.Font = new System.Drawing.Font("Corbel Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Begin.ForeColor = System.Drawing.Color.Black;
            this.lbl_Begin.Location = new System.Drawing.Point(585, 185);
            this.lbl_Begin.Name = "lbl_Begin";
            this.lbl_Begin.Size = new System.Drawing.Size(280, 42);
            this.lbl_Begin.TabIndex = 14;
            this.lbl_Begin.Text = "Beginner - 10 Lives";
            this.lbl_Begin.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_Amateur
            // 
            this.lbl_Amateur.AutoSize = true;
            this.lbl_Amateur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Amateur.Font = new System.Drawing.Font("Corbel Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Amateur.ForeColor = System.Drawing.Color.Black;
            this.lbl_Amateur.Location = new System.Drawing.Point(587, 248);
            this.lbl_Amateur.Name = "lbl_Amateur";
            this.lbl_Amateur.Size = new System.Drawing.Size(262, 42);
            this.lbl_Amateur.TabIndex = 15;
            this.lbl_Amateur.Text = "Amateur - 8 Lives";
            this.lbl_Amateur.Click += new System.EventHandler(this.lbl_Amateur_Click);
            // 
            // lbl_Advanced
            // 
            this.lbl_Advanced.AutoSize = true;
            this.lbl_Advanced.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Advanced.Font = new System.Drawing.Font("Corbel Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Advanced.ForeColor = System.Drawing.Color.Black;
            this.lbl_Advanced.Location = new System.Drawing.Point(579, 311);
            this.lbl_Advanced.Name = "lbl_Advanced";
            this.lbl_Advanced.Size = new System.Drawing.Size(279, 42);
            this.lbl_Advanced.TabIndex = 16;
            this.lbl_Advanced.Text = "Advanced - 5 Lives";
            this.lbl_Advanced.Click += new System.EventHandler(this.lbl_Advanced_Click);
            // 
            // lbl_Expert
            // 
            this.lbl_Expert.AutoSize = true;
            this.lbl_Expert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Expert.Font = new System.Drawing.Font("Corbel Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Expert.ForeColor = System.Drawing.Color.Black;
            this.lbl_Expert.Location = new System.Drawing.Point(603, 374);
            this.lbl_Expert.Name = "lbl_Expert";
            this.lbl_Expert.Size = new System.Drawing.Size(230, 42);
            this.lbl_Expert.TabIndex = 17;
            this.lbl_Expert.Text = "Expert - 2 Lives";
            this.lbl_Expert.Click += new System.EventHandler(this.lbl_Expert_Click);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(12, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(73, 28);
            this.button6.TabIndex = 18;
            this.button6.Text = "Settings";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxs_Controls,
            this.ctxs_leaderboard,
            this.ctxs_Game});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(141, 70);
            // 
            // ctxs_Controls
            // 
            this.ctxs_Controls.Name = "ctxs_Controls";
            this.ctxs_Controls.Size = new System.Drawing.Size(140, 22);
            this.ctxs_Controls.Text = "Controls";
            this.ctxs_Controls.Click += new System.EventHandler(this.ctxs_Controls_Click);
            // 
            // ctxs_leaderboard
            // 
            this.ctxs_leaderboard.Name = "ctxs_leaderboard";
            this.ctxs_leaderboard.Size = new System.Drawing.Size(140, 22);
            this.ctxs_leaderboard.Text = "Leaderboard";
            this.ctxs_leaderboard.Click += new System.EventHandler(this.leaderboardToolStripMenuItem_Click);
            // 
            // ctxs_Game
            // 
            this.ctxs_Game.Name = "ctxs_Game";
            this.ctxs_Game.Size = new System.Drawing.Size(140, 22);
            this.ctxs_Game.Text = "Game";
            this.ctxs_Game.Click += new System.EventHandler(this.controlsToolStripMenuItem_Click);
            // 
            // lbl_Survival
            // 
            this.lbl_Survival.AutoSize = true;
            this.lbl_Survival.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Survival.Font = new System.Drawing.Font("Corbel Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Survival.ForeColor = System.Drawing.Color.Black;
            this.lbl_Survival.Location = new System.Drawing.Point(603, 437);
            this.lbl_Survival.Name = "lbl_Survival";
            this.lbl_Survival.Size = new System.Drawing.Size(225, 42);
            this.lbl_Survival.TabIndex = 19;
            this.lbl_Survival.Text = "Survival - 1 Life";
            this.lbl_Survival.Click += new System.EventHandler(this.lbl_Survival_Click);
            // 
            // frm_Difficulty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 782);
            this.Controls.Add(this.lbl_Survival);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.lbl_Expert);
            this.Controls.Add(this.lbl_Advanced);
            this.Controls.Add(this.lbl_Amateur);
            this.Controls.Add(this.lbl_Begin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label402);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Difficulty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Difficulty";
            this.Load += new System.EventHandler(this.frm_Difficulty_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label402;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbl_Begin;
        public System.Windows.Forms.Label lbl_Amateur;
        public System.Windows.Forms.Label lbl_Advanced;
        public System.Windows.Forms.Label lbl_Expert;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctxs_Controls;
        private System.Windows.Forms.ToolStripMenuItem ctxs_leaderboard;
        private System.Windows.Forms.ToolStripMenuItem ctxs_Game;
        private System.Windows.Forms.Label lbl_Survival;
    }
}