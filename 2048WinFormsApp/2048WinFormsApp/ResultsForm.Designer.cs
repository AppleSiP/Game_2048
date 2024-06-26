namespace _2048WinFormsApp
{
    partial class ResultsForm
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
            resultsDataGridView = new DataGridView();
            NameColumn = new DataGridViewTextBoxColumn();
            ScoreColumn = new DataGridViewTextBoxColumn();
            StatusColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)resultsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // resultsDataGridView
            // 
            resultsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            resultsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultsDataGridView.Columns.AddRange(new DataGridViewColumn[] { NameColumn, ScoreColumn, StatusColumn });
            resultsDataGridView.Location = new Point(0, 0);
            resultsDataGridView.Name = "resultsDataGridView";
            resultsDataGridView.Size = new Size(345, 194);
            resultsDataGridView.TabIndex = 0;
            // 
            // NameColumn
            // 
            NameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NameColumn.HeaderText = "Имя";
            NameColumn.Name = "NameColumn";
            // 
            // ScoreColumn
            // 
            ScoreColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ScoreColumn.HeaderText = "Кол-во очков";
            ScoreColumn.Name = "ScoreColumn";
            // 
            // StatusColumn
            // 
            StatusColumn.HeaderText = "Статус";
            StatusColumn.Name = "StatusColumn";
            // 
            // ResultsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 199);
            Controls.Add(resultsDataGridView);
            Name = "ResultsForm";
            Text = "Результаты предыдущих игр";
            Load += ResultsForm_Load;
            ((System.ComponentModel.ISupportInitialize)resultsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView resultsDataGridView;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn ScoreColumn;
        private DataGridViewTextBoxColumn StatusColumn;
    }
}