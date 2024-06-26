namespace _2048WinFormsApp
{
    partial class OptionSizeForm
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
            optionSizeFormLabel = new Label();
            optionSizeFormTextBox = new TextBox();
            opionSizeFormRepeatLabel = new Label();
            optionSizeFormCloseButton = new Button();
            userNameOptionSizeForm = new Label();
            userNameTextBox = new TextBox();
            newSizeButton = new Button();
            SuspendLayout();
            // 
            // optionSizeFormLabel
            // 
            optionSizeFormLabel.AutoSize = true;
            optionSizeFormLabel.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            optionSizeFormLabel.Location = new Point(20, 20);
            optionSizeFormLabel.Name = "optionSizeFormLabel";
            optionSizeFormLabel.Size = new Size(253, 24);
            optionSizeFormLabel.TabIndex = 0;
            optionSizeFormLabel.Text = "Введите размер поля:";
            // 
            // optionSizeFormTextBox
            // 
            optionSizeFormTextBox.BackColor = SystemColors.ControlLightLight;
            optionSizeFormTextBox.BorderStyle = BorderStyle.None;
            optionSizeFormTextBox.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            optionSizeFormTextBox.Location = new Point(55, 70);
            optionSizeFormTextBox.Name = "optionSizeFormTextBox";
            optionSizeFormTextBox.Size = new Size(32, 25);
            optionSizeFormTextBox.TabIndex = 1;
            optionSizeFormTextBox.Text = "4";
            optionSizeFormTextBox.TextAlign = HorizontalAlignment.Center;
            optionSizeFormTextBox.TextChanged += optionSizeFormTextBox_TextChanged;
            optionSizeFormTextBox.KeyDown += optionSizeFormTextBox_KeyDown;
            // 
            // opionSizeFormRepeatLabel
            // 
            opionSizeFormRepeatLabel.BackColor = SystemColors.Control;
            opionSizeFormRepeatLabel.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            opionSizeFormRepeatLabel.Location = new Point(97, 70);
            opionSizeFormRepeatLabel.Name = "opionSizeFormRepeatLabel";
            opionSizeFormRepeatLabel.Size = new Size(70, 25);
            opionSizeFormRepeatLabel.TabIndex = 2;
            opionSizeFormRepeatLabel.Text = "x  4";
            opionSizeFormRepeatLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // optionSizeFormCloseButton
            // 
            optionSizeFormCloseButton.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            optionSizeFormCloseButton.Location = new Point(105, 290);
            optionSizeFormCloseButton.Name = "optionSizeFormCloseButton";
            optionSizeFormCloseButton.Size = new Size(75, 23);
            optionSizeFormCloseButton.TabIndex = 3;
            optionSizeFormCloseButton.Text = "Ok";
            optionSizeFormCloseButton.UseVisualStyleBackColor = true;
            optionSizeFormCloseButton.Click += optionSizeFormCloseButton_Click;
            // 
            // userNameOptionSizeForm
            // 
            userNameOptionSizeForm.AutoSize = true;
            userNameOptionSizeForm.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic);
            userNameOptionSizeForm.Location = new Point(20, 189);
            userNameOptionSizeForm.Name = "userNameOptionSizeForm";
            userNameOptionSizeForm.Size = new Size(160, 24);
            userNameOptionSizeForm.TabIndex = 4;
            userNameOptionSizeForm.Text = "Введите имя:";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic);
            userNameTextBox.Location = new Point(20, 239);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(252, 32);
            userNameTextBox.TabIndex = 5;
            userNameTextBox.KeyDown += userNameTextBox_KeyDown;
            // 
            // newSizeButton
            // 
            newSizeButton.Location = new Point(84, 125);
            newSizeButton.Name = "newSizeButton";
            newSizeButton.Size = new Size(125, 23);
            newSizeButton.TabIndex = 6;
            newSizeButton.Text = "Задать размер";
            newSizeButton.UseVisualStyleBackColor = true;
            newSizeButton.Click += newSizeButton_Click;
            // 
            // OptionSizeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 325);
            Controls.Add(newSizeButton);
            Controls.Add(userNameTextBox);
            Controls.Add(userNameOptionSizeForm);
            Controls.Add(optionSizeFormCloseButton);
            Controls.Add(opionSizeFormRepeatLabel);
            Controls.Add(optionSizeFormTextBox);
            Controls.Add(optionSizeFormLabel);
            Name = "OptionSizeForm";
            Text = "Размер поля";
            Load += OptionSizeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label optionSizeFormLabel;
        private TextBox optionSizeFormTextBox;
        private Label opionSizeFormRepeatLabel;
        private Button optionSizeFormCloseButton;
        private Label userNameOptionSizeForm;
        private TextBox userNameTextBox;
        private Button newSizeButton;
    }
}