using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using TagLib;

namespace ED2___Lab_0
{
    public partial class RHYTHMN : Form
    {
        public RHYTHMN()
        {
            InitializeComponent();
            Dictionary<string, Canción> biblioteca = new Dictionary<string, Canción>();
            Dictionary<string, List<Canción>> listas = new Dictionary<string, List<Canción>>();
            DirectoryInfo dir = new DirectoryInfo(@"C: \Users\"+Environment.UserName+ @"\Music\Rhythmn");
            foreach(var item in dir.GetFiles())
            {
                TagLib.File Mp3File = TagLib.File.Create(item.DirectoryName + @"\" + item.Name);
                Canción song = new Canción(Mp3File.Tag.Title, Mp3File.Tag.Performers, Mp3File.Tag.Album,
                                            Mp3File.Properties.Duration.TotalSeconds, (item.DirectoryName+ @"\"+item.Name));
                biblioteca.Add(Mp3File.Tag.Title, song);
            }
            
        }






        private void menú_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
