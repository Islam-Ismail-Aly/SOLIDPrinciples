using SOLID_Lab01.ISP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Lab01.ISP
{
    public class AudioPlayer : IPlayAudio, ILoadMedia
    {
        public void PlayAudio()
        {
            // implement code to play audio
        }
        public void LoadMedia(string filePath)
        {
            // implement code to load media
        }

    }
}
