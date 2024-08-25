
using System.Formats.Asn1;

namespace _2048WinFormsApp
{
    public partial class MainForm : Form
    {
        public static int fieldSize = 4;
        public int emptyCount;
        private Label[,] labelsField;
        public static Result result = new Result();
        private int maxScore = ResultManager.GetAll(DataProvider.Results)[0].Score;
        public MainForm()
        {
            InitializeComponent();
        }

        public void MainForm_Load(object sender, EventArgs e)
        {
            var optionSizeForm = new OptionSizeForm();
            optionSizeForm.ShowDialog();
            emptyCount = fieldSize * fieldSize;
            int sizeWidth = fieldSize * 75 + 35;
            int sizeHeight = fieldSize * 75 + 145;
            Size = new Size(sizeWidth, sizeHeight);
            InitField();
            GenerateNumber();
            ShowScore();
        }

        private void InitField()
        {
            labelsField = new Label[fieldSize, fieldSize];
            for (int indexRow = 0; indexRow < fieldSize; indexRow++)
            {
                for (int indexColumn = 0; indexColumn < fieldSize; indexColumn++)
                {
                    labelsField[indexRow, indexColumn] = CreateLabel(indexRow, indexColumn);
                    Controls.Add(labelsField[indexRow, indexColumn]);
                }
            }
        }

        private Label CreateLabel(int indexRow, int indexColumn)
        {
            var label = new Label();
            label.BackColor = SystemColors.GradientInactiveCaption;
            label.BorderStyle = BorderStyle.FixedSingle;
            label.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label.Location = new Point(10 + indexColumn * 75, 100 + indexRow * 75);
            label.Size = new Size(70, 70);
            label.TextAlign = ContentAlignment.MiddleCenter;
            return label;
        }
        private void GenerateNumber()
        {
            if (emptyCount > 0)
            {
                while (true)
                {
                    var randomNumberLabel = new Random().Next(fieldSize * fieldSize);
                    var indexRow = randomNumberLabel / fieldSize;
                    var indexColumn = randomNumberLabel % fieldSize;
                    if (labelsField[indexRow, indexColumn].Text == String.Empty)
                    {
                        var randomNumber = new Random().Next(100);
                        if (randomNumber < 75)
                        {
                            labelsField[indexRow, indexColumn].Text = "2";
                            labelsField[indexRow, indexColumn].BackColor = ColorManager.GetColor(labelsField[indexRow, indexColumn].Text);
                            emptyCount--;
                            break;
                        }
                        else
                        {
                            labelsField[indexRow, indexColumn].Text = "4";
                            labelsField[indexRow, indexColumn].BackColor = ColorManager.GetColor(labelsField[indexRow, indexColumn].Text);
                            emptyCount--;
                            break;
                        }
                    }
                }
            }
            else
            {
                var message = $"Игра закончена!\nВы проиграли.\nВаш результат: {result.Score}";
                if (Win())
                {
                    message = $"Поздравляю!\nВы победили.\nВаш результат: {result.Score}";
                    result.Status = "Winner";
                }
                ResultManager.Save(result, DataProvider.Results);
                MessageBox.Show(message, "Конец игры!", MessageBoxButtons.OK);
            }
        }
        private void ShowScore()
        {
            maxScoreLabel.Text = $"Лучший счёт: {maxScore}";
            scoreLabel.Text = $"Счёт: {result.Score}";
            if (maxScore < result.Score)
            {
                maxScoreLabel.Text = $"Лучший счёт: {result.Score}";
                maxScoreLabel.ForeColor = Color.Black;
                scoreLabel.ForeColor = Color.Red;
            }
        }
        public bool Win()
        {
            for (int i = 0; i < fieldSize; i++)
            {
                for (int j = 0; j < fieldSize; j++)
                {
                    if (Convert.ToInt32(labelsField[i, j].Text) >= 2048)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void перезапускToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void правилаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataProvider.ShowText(DataProvider.Rules, "Правила");
        }
        private void статистикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ResultsForm().ShowDialog();
        }
        private void размерыПоляToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var optionSizeForm = new OptionSizeForm();
            optionSizeForm.ShowDialog();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Right && e.KeyCode != Keys.Left && e.KeyCode != Keys.Up && e.KeyCode != Keys.Down)
            {
                return;
            }
            if (e.KeyCode == Keys.Right)
            {
                MoveRight();
            }
            if (e.KeyCode == Keys.Left)
            {
                MoveLeft();
            }
            if (e.KeyCode == Keys.Up)
            {
                MoveUp();
            }
            if (e.KeyCode == Keys.Down)
            {
                MoveDown();
            }
            GenerateNumber();
            ShowScore();
        }

        private void MoveDown()
        {
            for (int j = fieldSize - 1; j >= 0; j--)
            {
                for (int i = fieldSize - 1; i >= 0; i--)
                {
                    if (labelsField[i, j].Text != string.Empty)
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (labelsField[k, j].Text != string.Empty)
                            {
                                if (labelsField[k, j].Text == labelsField[i, j].Text)
                                {
                                    labelsField[i, j].Text = (int.Parse(labelsField[i, j].Text) * 2).ToString();
                                    labelsField[i, j].BackColor = ColorManager.GetColor(labelsField[i, j].Text);
                                    result.Score += int.Parse(labelsField[i, j].Text);
                                    labelsField[k, j].Text = String.Empty;
                                    emptyCount++;
                                    labelsField[k, j].BackColor = SystemColors.GradientInactiveCaption;
                                }
                                break;
                            }
                        }
                    }
                }
            }
            for (int j = fieldSize - 1; j >= 0; j--)
            {
                for (int i = fieldSize - 1; i >= 0; i--)
                {
                    if (labelsField[i, j].Text == string.Empty)
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (labelsField[k, j].Text != string.Empty)
                            {
                                labelsField[i, j].Text = labelsField[k, j].Text;
                                labelsField[i, j].BackColor = ColorManager.GetColor(labelsField[i, j].Text);
                                labelsField[k, j].Text = String.Empty;
                                labelsField[k, j].BackColor = SystemColors.GradientInactiveCaption;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void MoveUp()
        {
            for (int j = fieldSize - 1; j >= 0; j--)
            {
                for (int i = 0; i < fieldSize; i++)
                {
                    if (labelsField[i, j].Text != string.Empty)
                    {
                        for (int k = i + 1; k < fieldSize; k++)
                        {
                            if (labelsField[k, j].Text != string.Empty)
                            {
                                if (labelsField[k, j].Text == labelsField[i, j].Text)
                                {
                                    labelsField[i, j].Text = (int.Parse(labelsField[i, j].Text) * 2).ToString();
                                    labelsField[i, j].BackColor = ColorManager.GetColor(labelsField[i, j].Text);
                                    result.Score += int.Parse(labelsField[i, j].Text);
                                    labelsField[k, j].Text = String.Empty;
                                    emptyCount++;
                                    labelsField[k, j].BackColor = SystemColors.GradientInactiveCaption;
                                }
                                break;
                            }
                        }
                    }
                }
            }
            for (int j = fieldSize - 1; j >= 0; j--)
            {
                for (int i = 0; i < fieldSize; i++)
                {
                    if (labelsField[i, j].Text == string.Empty)
                    {
                        for (int k = i + 1; k < fieldSize; k++)
                        {
                            if (labelsField[k, j].Text != string.Empty)
                            {
                                labelsField[i, j].Text = labelsField[k, j].Text;
                                labelsField[i, j].BackColor = ColorManager.GetColor(labelsField[i, j].Text);
                                labelsField[k, j].Text = String.Empty;
                                labelsField[k, j].BackColor = SystemColors.GradientInactiveCaption;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void MoveLeft()
        {
            for (int i = 0; i < fieldSize; i++)
            {
                for (int j = 0; j < fieldSize; j++)
                {
                    if (labelsField[i, j].Text != string.Empty)
                    {
                        for (int k = j + 1; k < fieldSize; k++)
                        {
                            if (labelsField[i, k].Text != string.Empty)
                            {
                                if (labelsField[i, k].Text == labelsField[i, j].Text)
                                {
                                    labelsField[i, j].Text = (int.Parse(labelsField[i, j].Text) * 2).ToString();
                                    labelsField[i, j].BackColor = ColorManager.GetColor(labelsField[i, j].Text);
                                    result.Score += int.Parse(labelsField[i, j].Text);
                                    labelsField[i, k].Text = String.Empty;
                                    emptyCount++;
                                    labelsField[i, k].BackColor = SystemColors.GradientInactiveCaption;
                                }
                                break;
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < fieldSize; i++)
            {
                for (int j = 0; j < fieldSize; j++)
                {
                    if (labelsField[i, j].Text == string.Empty)
                    {
                        for (int k = j + 1; k < fieldSize; k++)
                        {
                            if (labelsField[i, k].Text != string.Empty)
                            {
                                labelsField[i, j].Text = labelsField[i, k].Text;
                                labelsField[i, j].BackColor = ColorManager.GetColor(labelsField[i, j].Text);
                                labelsField[i, k].Text = String.Empty;
                                labelsField[i, k].BackColor = SystemColors.GradientInactiveCaption;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void MoveRight()
        {
            for (int i = 0; i < fieldSize; i++)
            {
                for (int j = fieldSize - 1; j >= 0; j--)
                {
                    if (labelsField[i, j].Text != string.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (labelsField[i, k].Text != string.Empty)
                            {
                                if (labelsField[i, k].Text == labelsField[i, j].Text)
                                {
                                    labelsField[i, j].Text = (int.Parse(labelsField[i, j].Text) * 2).ToString();
                                    labelsField[i, j].BackColor = ColorManager.GetColor(labelsField[i, j].Text);
                                    result.Score += int.Parse(labelsField[i, j].Text);
                                    labelsField[i, k].Text = String.Empty;
                                    emptyCount++;
                                    labelsField[i, k].BackColor = SystemColors.GradientInactiveCaption;
                                }
                                break;
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < fieldSize; i++)
            {
                for (int j = fieldSize - 1; j >= 0; j--)
                {
                    if (labelsField[i, j].Text == string.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (labelsField[i, k].Text != string.Empty)
                            {
                                labelsField[i, j].Text = labelsField[i, k].Text;
                                labelsField[i, j].BackColor = ColorManager.GetColor(labelsField[i, j].Text);
                                labelsField[i, k].Text = String.Empty;
                                labelsField[i, k].BackColor = SystemColors.GradientInactiveCaption;
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
