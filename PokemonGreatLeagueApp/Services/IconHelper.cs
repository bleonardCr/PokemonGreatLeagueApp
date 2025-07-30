using System.Drawing;

namespace NebsojiPVPTrainer.Services
{
    public static class IconHelper
    {
        // Return a colored square as a quick visual stub:
        public static Image GetMatchupIcon(double multiplier)
        {
            var bmp = new Bitmap(24, 24);
            using var g = Graphics.FromImage(bmp);
            var color = multiplier > 1 ? Color.Green
                      : multiplier < 1 ? Color.Red
                                      : Color.Gray;
            g.Clear(color);
            return bmp;
        }
    }
}
