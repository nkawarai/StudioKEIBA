namespace StudioKEIBA.HorseProfilerApp.Extensions
{
    static public class ControlEx
    {
        static internal int ScaleWidth(this Control self, int width)
        {
            using var g = self.CreateGraphics();
            return (int)(width * g.DpiX / 96f);
        }
    }
}
