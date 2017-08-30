using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED2___Lab_0
{
    class Canción
    {
        private string title;
        private string[] performers;
        private string Album;
        private double totalSeconds;
        private string directoryName;

        public Canción(string title, string[] performers, string album, double totalSeconds, string directoryName)
        {
            this.title = title;
            this.performers = performers;
            Album = album;
            this.totalSeconds = totalSeconds;
            this.directoryName = directoryName;
        }
    }
}
