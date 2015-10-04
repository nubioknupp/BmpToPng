using System.Drawing;
using System.Drawing.Imaging;

namespace BmpToPng
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var bmp = new Bitmap(@"D:\Temp\logo.bmp"))
            {
                bmp.MakeTransparent();
                bmp.Save(@"D:\Temp\logo.png", ImageFormat.Png);
            }
        }
    }
}
