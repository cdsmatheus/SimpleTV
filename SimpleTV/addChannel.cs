using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SimpleTV
{
    public partial class addChannel : Form
    {
        public addChannel()
        {
            InitializeComponent();
        }

        private void btnAddChannel_Click(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load(Application.StartupPath + @"\canais.xml");
            XElement root = new XElement("Canal");
            root.Add(new XAttribute("Nome", txtChannelName.Text));
            root.Add(new XAttribute("URL", txtChannelURL.Text));
            doc.Element("Canal").Add(root);
            doc.Save(Application.StartupPath + @"\canais.xml");

            MessageBox.Show("Canal Adicionado");
            this.Close();
        }
    }
}
