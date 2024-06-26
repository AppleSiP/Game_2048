
namespace _2048WinFormsApp
{
    public static class ColorManager
    {
        public  static Color  GetColor(string value)
        {
            var colors = new List<Color>()
            {
                Color.FromArgb(255, 248, 220),
                Color.FromArgb(255, 235, 205),
                Color.FromArgb(255, 228, 196),
                Color.FromArgb(255, 222, 173),
                Color.FromArgb(245, 222, 179),
                Color.FromArgb(222, 184, 135),
                Color.FromArgb(210, 180, 140),
                Color.FromArgb(188, 143, 143),
                Color.FromArgb(244, 164, 96),
                Color.FromArgb(218, 165, 32),
                Color.FromArgb(184, 134, 11),
                Color.FromArgb(205, 133, 63),
                Color.FromArgb(210, 105, 30),
                Color.FromArgb(139, 69, 19),
                Color.FromArgb(160, 82, 45),
                Color.FromArgb(165, 42, 42),
                Color.FromArgb(128, 0, 0)
            };
            var index = Convert.ToInt32(Math.Log(Convert.ToDouble(value), 2.0) - 1);
            return colors[index];
        }
    }
}
