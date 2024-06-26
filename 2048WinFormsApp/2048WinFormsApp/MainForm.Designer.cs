namespace _2048WinFormsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStripMainForm = new MenuStrip();
            toolStripMenuItem = new ToolStripMenuItem();
            статистикаToolStripMenuItem = new ToolStripMenuItem();
            размерыПоляToolStripMenuItem = new ToolStripMenuItem();
            перезапускToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            правилаToolStripMenuItem = new ToolStripMenuItem();
            maxScoreLabel = new Label();
            scoreLabel = new Label();
            menuStripMainForm.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripMainForm
            // 
            menuStripMainForm.Items.AddRange(new ToolStripItem[] { toolStripMenuItem, правилаToolStripMenuItem });
            menuStripMainForm.Location = new Point(0, 0);
            menuStripMainForm.Name = "menuStripMainForm";
            menuStripMainForm.Size = new Size(329, 24);
            menuStripMainForm.TabIndex = 0;
            menuStripMainForm.Text = "menuStrip1";
            // 
            // toolStripMenuItem
            // 
            toolStripMenuItem.BackColor = SystemColors.ControlLight;
            toolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { статистикаToolStripMenuItem, размерыПоляToolStripMenuItem, перезапускToolStripMenuItem, выходToolStripMenuItem });
            toolStripMenuItem.Name = "toolStripMenuItem";
            toolStripMenuItem.Size = new Size(53, 20);
            toolStripMenuItem.Text = "Меню";
            // 
            // статистикаToolStripMenuItem
            // 
            статистикаToolStripMenuItem.Name = "статистикаToolStripMenuItem";
            статистикаToolStripMenuItem.Size = new Size(153, 22);
            статистикаToolStripMenuItem.Text = "Статистика";
            статистикаToolStripMenuItem.Click += статистикаToolStripMenuItem_Click;
            // 
            // размерыПоляToolStripMenuItem
            // 
            размерыПоляToolStripMenuItem.Name = "размерыПоляToolStripMenuItem";
            размерыПоляToolStripMenuItem.Size = new Size(153, 22);
            размерыПоляToolStripMenuItem.Text = "Размеры поля";
            размерыПоляToolStripMenuItem.Click += размерыПоляToolStripMenuItem_Click;
            // 
            // перезапускToolStripMenuItem
            // 
            перезапускToolStripMenuItem.Name = "перезапускToolStripMenuItem";
            перезапускToolStripMenuItem.Size = new Size(153, 22);
            перезапускToolStripMenuItem.Text = "Перезапуск";
            перезапускToolStripMenuItem.Click += перезапускToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(153, 22);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // правилаToolStripMenuItem
            // 
            правилаToolStripMenuItem.BackColor = SystemColors.ControlLight;
            правилаToolStripMenuItem.Name = "правилаToolStripMenuItem";
            правилаToolStripMenuItem.Size = new Size(67, 20);
            правилаToolStripMenuItem.Text = "Правила";
            правилаToolStripMenuItem.Click += правилаToolStripMenuItem_Click;
            // 
            // maxScoreLabel
            // 
            maxScoreLabel.AutoSize = true;
            maxScoreLabel.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            maxScoreLabel.ForeColor = Color.Red;
            maxScoreLabel.Location = new Point(10, 28);
            maxScoreLabel.Name = "maxScoreLabel";
            maxScoreLabel.Size = new Size(46, 24);
            maxScoreLabel.TabIndex = 1;
            maxScoreLabel.Text = "100";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.BackColor = SystemColors.Control;
            scoreLabel.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            scoreLabel.ForeColor = Color.Black;
            scoreLabel.Location = new Point(10, 57);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(71, 24);
            scoreLabel.TabIndex = 2;
            scoreLabel.Text = "label2";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(329, 366);
            Controls.Add(scoreLabel);
            Controls.Add(maxScoreLabel);
            Controls.Add(menuStripMainForm);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStripMainForm;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game - 2048";
            Load += MainForm_Load;
            KeyDown += MainForm_KeyDown;
            menuStripMainForm.ResumeLayout(false);
            menuStripMainForm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripMainForm;
        private ToolStripMenuItem toolStripMenuItem;
        private ToolStripMenuItem статистикаToolStripMenuItem;
        private ToolStripMenuItem размерыПоляToolStripMenuItem;
        private ToolStripMenuItem перезапускToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem правилаToolStripMenuItem;
        private Label maxScoreLabel;
        private Label scoreLabel;
    }
}
