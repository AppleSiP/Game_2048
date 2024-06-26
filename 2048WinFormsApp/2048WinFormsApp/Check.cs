
namespace _2048WinFormsApp
{
    public static class Check
    {
       public static string InputNumber(string input)
        {
            int correctInput;
            bool statusAnswer = int.TryParse(input, out correctInput);
            if (statusAnswer && correctInput <= 10 && correctInput > 0)
            {
                return correctInput.ToString();
            }
            else
            {
                MessageBox.Show("Пожулйства  введите число (max = 10)", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "No Correct";
            }
        }
    }
}