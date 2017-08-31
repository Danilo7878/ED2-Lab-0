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
        //Diccionario utilizado para almacenar la biblioteca de canciones
        //Ficheros MP3 extraídos de la carpeta "Rhythmn" en la
        //biblioteca "música" de cualquier ordenador
        Dictionary<string, Canción> biblioteca = new Dictionary<string, Canción>();
        //contiene una colección con listas de reproducción
        Dictionary<string, List<Canción>> listas = new Dictionary<string, List<Canción>>();
        //contiene las llaves de las canciones únicamente como ayuda para mostrar la info
        // en el dataGridView1
        List<string> llaves = new List<string>();
        //controlar el número de canción;
        int control;
        // controlar play y pausa
        bool play;
        //define si debe reproducir una lista, una lista ordenada o toda la música
        bool tipo = true;
        IEnumerable<Canción> Ordenada;
        string aux;
        string auxNombre;
        string auxArtista;

        public RHYTHMN()
        {
            InitializeComponent();
            
            //obtiene los archivos mp3 de la carpeta Rhythmn creada en
            //la biblioteca "música
            //y obtiene sus tag
            DirectoryInfo dir = new DirectoryInfo(@"C: \Users\"+Environment.UserName+ @"\Music\Rhythmn");
            foreach(var item in dir.GetFiles())
            {
                TagLib.File Mp3File = TagLib.File.Create(item.DirectoryName + @"\" + item.Name);
                Canción song = new Canción(Mp3File.Tag.Title, Mp3File.Tag.FirstPerformer, Mp3File.Tag.Album,
                                            Mp3File.Properties.Duration.TotalSeconds, (item.DirectoryName+ @"\"+item.Name));
                biblioteca.Add(Mp3File.Tag.Title, song);
                llaves.Add(Mp3File.Tag.Title);
            }
            MostrarBiblioteca();
        }

        //Método que muestra toda la música en la tabla
        public void MostrarBiblioteca()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < llaves.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1[0, i].Value = biblioteca[llaves[i]].GetTitle();
                dataGridView1[1, i].Value = biblioteca[llaves[i]].GetPerformers();
                dataGridView1[2, i].Value = biblioteca[llaves[i]].GetAlbum();
                dataGridView1[3, i].Value = biblioteca[llaves[i]].GetTotalSeconds().ToString("#.##");
            }
        }

        private void menú_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        // botón que muestra el panel para crear las listas de reproducción
        private void button1_Click(object sender, EventArgs e)
        {
            panelLista.Visible = true;
        }

        //crea la lista de reproducción luego de asignarle un nombre
        //agrega la lista como un item en un combobox
        private void btnAgregarLista_Click(object sender, EventArgs e)
        {
            if (txtNombreLista != null)
            {
                List<Canción> nueva = new List<Canción>();
                listas.Add(txtNombreLista.Text, nueva);
                System.Object item = txtNombreLista.Text;
                comboBox1.Items.Add(item);
                MessageBox.Show("lista creada exitosamente");
                panelLista.Visible = false;
                txtNombreLista.Text = "";
            }
            else
            {
                MessageBox.Show("Debes agregar un nombre para tu lista");
            }
        }

        //permite salir del panel de creación de lista
        private void exit1_Click(object sender, EventArgs e)
        {
            panelLista.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //permite salir del panel de agregar canción
        private void exit2_Click(object sender, EventArgs e)
        {
            panelCanción.Visible = false;
        }

        //botón que muestra el panel para buscar canción y agregarla a la lista
        //seleccionada en el combobox1
        private void btnNuevaCanción_Click(object sender, EventArgs e)
        {
            panelCanción.Visible = true;
        }

        //agrega el objeto canción a la lista de reproducción y lo muestra en la vista
        private void btnAgregarCanción_Click(object sender, EventArgs e)
        {
            if (txtNombreCanción.Text != null)
            {
                try
                {
                    listas[comboBox1.SelectedItem.ToString()].Add(biblioteca[txtNombreCanción.Text]);
                    panelCanción.Visible = false;
                    dataGridView1.Rows.Clear();
                    for (int i = 0; i < listas[comboBox1.SelectedItem.ToString()].Count; i++)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1[0, i].Value = listas[comboBox1.SelectedItem.ToString()][i].GetTitle();
                        dataGridView1[1, i].Value = listas[comboBox1.SelectedItem.ToString()][i].GetPerformers();
                        dataGridView1[2, i].Value = listas[comboBox1.SelectedItem.ToString()][i].GetAlbum();
                        dataGridView1[3, i].Value = listas[comboBox1.SelectedItem.ToString()][i].GetTotalSeconds().ToString();
                    }
                    txtNombreCanción.Text = "";
                }
                catch
                {
                    MessageBox.Show("Esta canción no se encuentra disponible");
                }
            }
            else
            {
                MessageBox.Show("Error, escribe un título de canción");
            }
        }

        //elige la forma de ordenamiento de la lista y muestra ya ordenada
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem.ToString() != null)
            {  
                if (comboBox2.SelectedItem.ToString() == "Nombre (ascendente)")
                {
                    Ordenada = listas[comboBox1.SelectedItem.ToString()].OrderBy(x => x.GetTitle());
                }
                else if (comboBox2.SelectedItem.ToString() == "Nombre (descendente)")
                {
                    Ordenada = listas[comboBox1.SelectedItem.ToString()].OrderByDescending(x => x.GetTitle());
                }
                else if (comboBox2.SelectedItem.ToString() == "Duración (ascendente)")
                {
                    Ordenada = listas[comboBox1.SelectedItem.ToString()].OrderBy(x => x.GetTotalSeconds());
                }
                else if (comboBox2.SelectedItem.ToString() == "Duración (descendente)")
                {
                    Ordenada = listas[comboBox1.SelectedItem.ToString()].OrderByDescending(x => x.GetTotalSeconds());
                }
                else
                {
                    Ordenada = null;
                }
                int i = 0;
                dataGridView1.Rows.Clear();
                foreach (Canción item in Ordenada)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1[0, i].Value = item.GetTitle();
                    dataGridView1[1, i].Value = item.GetPerformers();
                    dataGridView1[2, i].Value = item.GetAlbum();
                    dataGridView1[3, i].Value = item.GetTotalSeconds().ToString();
                    i++;
                }  
            }
        }

        //elige una lista de reproducción existente
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() != null)
            {
                dataGridView1.Rows.Clear();
                for (int i = 0; i < listas[comboBox1.SelectedItem.ToString()].Count; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1[0, i].Value = listas[comboBox1.SelectedItem.ToString()][i].GetTitle();
                    dataGridView1[1, i].Value = listas[comboBox1.SelectedItem.ToString()][i].GetPerformers();
                    dataGridView1[2, i].Value = listas[comboBox1.SelectedItem.ToString()][i].GetAlbum();
                    dataGridView1[3, i].Value = listas[comboBox1.SelectedItem.ToString()][i].GetTotalSeconds().ToString();
                }
                btnNuevaCanción.Visible = true;
                comboBox2.Visible = true;
                label4.Visible = true;
                ReproducirLista.Visible = true;
            }
        }

        //pasa a la interfaz de listas
        private void listasDeReproducciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tipo = false;
            comboBox1.Visible = true;
            label3.Visible = true;
            button1.Visible = true;
            label5.Visible = false;
            pictureBox1.Visible = false;
        }

        //vuelve a la página principal de la ubicación
        private void todaLaMúsicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarBiblioteca();
            tipo = true;
            pictureBox1.Visible = true;
            label5.Visible = true;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            button1.Visible = false;
            btnNuevaCanción.Visible = false;
        }

        //manda a reproducir la lista en orden 
        private void ReproducirLista_Click(object sender, EventArgs e)
        {
            control = 0;
            ReproducirDesdeUnaLista();
        }
        
        //oculta y muestra los controles del reproductor
        public void MostrarBotones()
        {
            playPausa.Visible = true;
            anterior.Visible = true;
            siguiente.Visible = true;
            Detener.Visible = true;
        }
        public void OcultarBotones()
        {
            playPausa.Visible = false;
            anterior.Visible = false;
            siguiente.Visible = false;
            Detener.Visible = false;
            label6.Text = "";
        }

        //Reproduce la lista desde la canción indicada o en orden
        public void ReproducirDesdeUnaLista()
        {
            if (comboBox2.SelectedItem != null)
            {
                int i = 0;
                foreach (Canción item in Ordenada)
                {
                    if (i == control)
                    {
                        aux = item.GetDirectoryName();
                        auxNombre = item.GetTitle();
                        auxArtista = item.GetPerformers();
                        break;
                    }
                    i++;
                }
                Reproductor.URL = aux;
                label6.Text = auxNombre + " - " + auxArtista;
            }
            else
            {
                Reproductor.URL = listas[comboBox1.SelectedItem.ToString()][control].GetDirectoryName();
                label6.Text = listas[comboBox1.SelectedItem.ToString()][control].GetTitle() + " - " + listas[comboBox1.SelectedItem.ToString()][control].GetPerformers();
            }   
            play = true;
            playPausa.Image = Properties.Resources.pausa__1_;
            MostrarBotones();
            
            
        }

        //Reproduce la biblioteca desde la canción indicada o en orden
        public void ReproducirDesdeBiblioteca()
        {
            Reproductor.URL = biblioteca[llaves[control]].GetDirectoryName();
            play = true;
            playPausa.Image = Properties.Resources.pausa__1_;
            MostrarBotones();
            label6.Text = biblioteca[llaves[control]].GetTitle() + " - " + biblioteca[llaves[control]].GetPerformers();
        }
        private void RHYTHMN_Load(object sender, EventArgs e)
        {

        }

        //manda a reproducir la canción que se seleccionó en el DGV con doble click
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            control = e.RowIndex;
            if (tipo)
            {
                ReproducirDesdeBiblioteca();
            }
            else
            {
                ReproducirDesdeUnaLista();
            }
        }

        //reproduce la canción anterior a la actual
        private void anterior_Click(object sender, EventArgs e)
        {
            if (tipo)
            {
                if(control > 0 && control < llaves.Count)
                {
                    control--;
                    ReproducirDesdeBiblioteca();
                }
            }
            else
            {
                if (control > 0 && control < listas[comboBox1.SelectedItem.ToString()].Count)
                {
                    control--;
                    ReproducirDesdeUnaLista();
                }
            }

        }

        //Reproduce la siguiente canción a la actual
        private void siguiente_Click(object sender, EventArgs e)
        {
            if (tipo)
            {
                if (control >= 0 && control < llaves.Count -1)
                {
                    control++;
                    ReproducirDesdeBiblioteca();
                }
            }
            else
            {
                if (control >= 0 && control < listas[comboBox1.SelectedItem.ToString()].Count -1)
                {
                    control++;
                    ReproducirDesdeUnaLista();
                }
            }
        }

        //se encargar de controlor la reproducción de una canción
        //e intercambiar el símbolo del botón.
        private void playPausa_Click(object sender, EventArgs e)
        {
            if (play)
            {
                Reproductor.Ctlcontrols.pause();
                playPausa.Image = Properties.Resources.play2;
                play = false;
            }
            else
            {
                Reproductor.Ctlcontrols.play();
                playPausa.Image = Properties.Resources.pausa__1_;
                play = true;
            }
        }

        //Detiene la reproducción y oculta los controladores.
        private void Detener_Click(object sender, EventArgs e)
        {
            Reproductor.Ctlcontrols.stop();
            play = false;
            OcultarBotones();
        }
    }
}
