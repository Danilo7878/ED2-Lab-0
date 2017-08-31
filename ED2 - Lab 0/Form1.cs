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

        public RHYTHMN()
        {
            InitializeComponent();
            
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
            for (int i = 0; i < llaves.Count-1; i++)
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

        private void exit1_Click(object sender, EventArgs e)
        {
            panelLista.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

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
                IEnumerable<Canción> Ordenada;
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
            }
        }

        //pasa a la interfaz de listas
        private void listasDeReproducciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            pictureBox1.Visible = true;
            label5.Visible = true;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            button1.Visible = false;
            btnNuevaCanción.Visible = false;
        }

        
    }
}
