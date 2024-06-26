

namespace _2048WinFormsApp
{
    public partial class OptionSizeForm : Form
    {
        public OptionSizeForm()
        {
            InitializeComponent();
        }
        private void optionSizeFormTextBox_TextChanged(object sender, EventArgs e)
        {
            opionSizeFormRepeatLabel.Text = $"x  {optionSizeFormTextBox.Text}";
        }

        private void OptionSizeForm_Load(object sender, EventArgs e)
        {
            optionSizeFormTextBox.Text = MainForm.fieldSize.ToString();
            opionSizeFormRepeatLabel.Text = $"x  {optionSizeFormTextBox.Text}";
            optionSizeFormTextBox.Select();
        }


        private void optionSizeFormTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                newSizeButton_Click(newSizeButton, null);
                e.SuppressKeyPress = true;
            }
        }

        private void userNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                optionSizeFormCloseButton_Click(optionSizeFormCloseButton, null);
                e.SuppressKeyPress = true;
            }
        }

        private void newSizeButton_Click(object sender, EventArgs e)
        {
            var newSize = Check.InputNumber(optionSizeFormTextBox.Text);
            if (newSize != "No Correct")
            {
                optionSizeFormTextBox.Text = newSize;
                MainForm.fieldSize = Convert.ToInt32(optionSizeFormTextBox.Text);
                MessageBox.Show("Размер задан", "Сообщение", MessageBoxButtons.OK);
                userNameTextBox.Select();
            }
            else
            {
                optionSizeFormTextBox.Text = "";
            }
        }

        private void optionSizeFormCloseButton_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text != String.Empty)
            {
                if (userNameTextBox.Text.Length > 32)
                {
                    MessageBox.Show("Введенное имя слишком длинное!\n\nМаксимальная длина 32 символа.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    userNameTextBox.Text = String.Empty;
                    userNameTextBox.Select();
                }
                else
                {
                    MainForm.result.Name = userNameTextBox.Text;
                    Close();
                }
            }
            else
            {
                Close();
            }
        }
    }
}
