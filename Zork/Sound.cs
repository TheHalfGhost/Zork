using System.IO;
using System.Media;

namespace Zork
{

    public class Sound
    {
       static string SoundPath;

       public static void PlaySound()
        {
            SoundPath = Path.GetFullPath($@"Music\{Game.Instance.Player.CurrentRoom.Music}");

            SoundPlayer Music = new SoundPlayer
            {
                SoundLocation = SoundPath
            };

            Music.Play();
        }
    }
}
