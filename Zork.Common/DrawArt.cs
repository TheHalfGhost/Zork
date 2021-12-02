using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;

namespace Zork
{
    public class DrawArt
    {
        static string FullPath;

        public static void Draw()
        {
            FullPath = Path.GetFullPath($@"Images\{Game.Instance.Player.CurrentRoom.Picture}");

            Image Picture = Image.FromFile(FullPath);

            FrameDimension Dimension = new FrameDimension(Picture.FrameDimensionsList[0x0]);

            char[] Chars = { '░', '▒', '▓', ' ' };

            Picture.SelectActiveFrame(Dimension, 0x0);

            for (int i = 0x0; i < Picture.Height; i++)
            {
                for (int x = 0x0; x < Picture.Width; x++)
                {
                    Color Color = ((Bitmap)Picture).GetPixel(x, i);

                    int Gray = (Color.R + Color.G + Color.B) / 0x3;

                    int Index = (Gray * (Chars.Length - 0x1)) / 0xFF;

                    Console.Write(Chars[Index]);
                }

                Console.Write('\n');

                Thread.Sleep(50);
            }

            Console.Read();
        }
    }
}
