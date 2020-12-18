using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Noticioneitor
{
    public partial class CadSite : Form
    {
        public CadSite()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            if (textBox.Text.Length>0)
            {                
                String pathXML = AppDomain.CurrentDomain.BaseDirectory.ToString() + @"\Noticioneitor.xml";
                DataSet dsResultado = new DataSet();
                dsResultado.ReadXml(pathXML);
                DataRow nR = dsResultado.Tables[0].NewRow();
                nR[0] = textBox.Text;
                nR[1] = Globais.Maximo+1;
                nR[2] = DateTime.Today.AddDays(-1).ToShortDateString();
                nR[3] = 0;
                nR[4] = 0;
                dsResultado.Tables[0].Rows.Add(nR);
                dsResultado.WriteXml(pathXML);
                this.Close();
            }
        }
    }
}
