using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Game_Gear_Generator
{
    public partial class Form1 : Form
    {
        List<String> m_html;
        public Form1()
        {
            InitializeComponent();
            m_html = new List<string>();
            m_html.Add("<html>");
            m_html.Add("<body>");
            m_html.Add("<applet code=\"JavaGearApplet.class\" width=\"{0}\" height=\"{1}\">");//Resolucio
            m_html.Add("<param name=\"archive\" value=\"{0}\">");//Emulador
            m_html.Add("<param name=\"rom\" value=\"{0}\">");//Rom
            m_html.Add("<param name=\"video\" value=\"{0}\">");//Format de video
            m_html.Add("<param name=\"lightgun\" value=\"{0}\">");//LightGun
            m_html.Add("</applet>");
            m_html.Add("</html>");
            m_html.Add("</body>");

        }


        private void Form_Load(object sender, EventArgs e)
        {
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(Form_DragEnter);
            this.DragDrop += new DragEventHandler(Form_DragDrop);
        }

        void Form_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy; // Okay
            else
                e.Effect = DragDropEffects.None; // Unknown data, ignore it
        }


        void Form_DragDrop(object sender, DragEventArgs e)
        {
            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);


            foreach (string file in FileList)
            {
                string rom = Path.GetFileName(file);
                string path = Path.GetDirectoryName(file);
                string name = Path.GetFileNameWithoutExtension(file);
                string htmlPath = Path.Combine(path, name);
                htmlPath += ".html";

                var stream = File.CreateText(htmlPath);

                short cont = 0;
                foreach (string str in m_html)
                {
                    String MyStr = str;
                    switch (cont)
                    {
                        case 2: //Resolucio
                            if (String.IsNullOrWhiteSpace(textBoxResX.Text))
                            {
                                MessageBox.Show("Resolucio X no pot esta vuida, introdueix un numero i torna a arrastrar les ROMs");
                                return;
                            }
                            else if (String.IsNullOrWhiteSpace(textBoxResY.Text))
                            {
                                MessageBox.Show("Resolucio Y no pot esta vuida, introdueix un numero i torna a arrastrar les ROMs");
                                return;
                            }

                            MyStr = String.Format(str, textBoxResX.Text, textBoxResY.Text);
                            break;

                        case 3://Emulador
                            String emulatorPath = Path.Combine(path, textEmulador.Text);
                            if (File.Exists(emulatorPath) == false)
                            {
                                MessageBox.Show(String.Format("No s'ha trobat l'archiu {0} en el seguent path: {1}, verifica el nom i torna-ho a intentar si no trucam i t'ajudu! :)", textEmulador.Text, emulatorPath));
                                return;
                            }
                            MyStr = String.Format(str, textEmulador.Text);
                            break;

                        case 4://Rom
                            MyStr = String.Format(str, rom);
                            break;

                        case 5://Format video
                            string video;
                            if (radioNTSC.Checked) video = "ntsc";
                            else video = "pal";
                            MyStr = String.Format(str, video);
                            break;

                        case 6:
                            string lightGun;
                            if (checkBoxLightGun.Checked) lightGun = "true";
                            else lightGun = "false";
                            MyStr = String.Format(str, lightGun);
                            break;
                    }

                    stream.WriteLine(MyStr);
                    cont++;
                }

                stream.Close();
            }

            if (FileList.Length == 1)
            {
                MessageBox.Show(String.Format("Generat {0} archiu HTML a la seguent ruta: \r {1}", FileList.Length, Path.GetDirectoryName(FileList[0])));
            }
            else
            {
                MessageBox.Show(String.Format("Generat {0} archius HTML a la seguent ruta: \r {1}", FileList.Length, Path.GetDirectoryName(FileList[0])));
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            var source = sender as TextBox;
            String t = source.Text;
            foreach (char ch in t)
            {
                if (char.IsDigit(ch) == false)
                {
                    source.Text = String.Empty;
                    MessageBox.Show("Nomes numeros!!");
                    return;
                }
            }
        }
    }
}
