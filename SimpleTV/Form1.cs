using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace SimpleTV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + @"\canais.xml"))
            {
                XmlTextWriter xml = new XmlTextWriter(Application.StartupPath + @"\canais.xml", null);
                xml.WriteStartDocument();
                xml.WriteStartElement("Canal");
                xml.WriteAttributeString("Nome", "");
                xml.WriteAttributeString("URL", "");
                xml.WriteEndDocument();
                xml.Close();

                MessageBox.Show("Arquivo canais.xml criado");
                Application.Restart();
            }
            else
            {
                DataSet ds = new DataSet();
                ds.ReadXml(Application.StartupPath + @"\canais.xml");
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string url;
            axVLCPlugin21.playlist.stop();
            axVLCPlugin21.playlist.items.clear();
            url = dataGridView1.SelectedCells[1].Value.ToString();
            axVLCPlugin21.playlist.add(url,"Canal",null);
            axVLCPlugin21.playlist.play();
        }

        private void adicionarCanalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addChannel chn = new addChannel();
            chn.ShowDialog();
            DataSet ds = new DataSet();
            ds.ReadXml(Application.StartupPath + @"\canais.xml");
            dataGridView1.DataSource = ds.Tables[0];

            
        }
    }
}
