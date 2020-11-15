using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Noticioneitor
{
    public partial class Form1 : Form
    {
        private const int colEndereco = 0;
        private const int colpontos = 1;
        private const int colDtUltVis = 2;
        private const int coldesatualizado = 3;
        private const int colseminteressante = 4;
        private const int colUltPosic = 5;

        private int NrSites = 0;
        private DataSet dsResultado = new DataSet();
        private int IndiceSite = 0;
        private string pathXML = "";
        private Boolean JaAtivou = false;
        private Boolean Fechar = false;
        String sHoje = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void FazBackupDoXML()
        {
            string pathXMLBak = AppDomain.CurrentDomain.BaseDirectory.ToString() + @"\Noticioneitor.xml.bak";
            System.IO.File.Copy(pathXML, pathXMLBak, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pathXML = AppDomain.CurrentDomain.BaseDirectory.ToString() + @"\Noticioneitor.xml";
            FazBackupDoXML();
            CarregaXML();
            string sUltDt = dsResultado.Tables[0].Rows[0][colDtUltVis].ToString();            
            Boolean OK = true;
            sHoje = DateTime.Today.ToShortDateString();
            if (sUltDt== sHoje)
            {
                OK = ConfereProximo(sUltDt);
            } else
            {
                Reordenar(sUltDt);
            }
            if (OK)
            {
                OK = Mostrar();
                if (OK)
                {
                    System.Diagnostics.Process.Start(linkLabel.Text);
                }                
            }
        }

        private void CarregaXML()
        {            
            dsResultado.ReadXml(pathXML);
            NrSites = dsResultado.Tables[0].Rows.Count;
            progressBar.Maximum = NrSites;
        }

        private Boolean ConfereProximo(string sUltDt)
        {            
            DateTime UltDt = DateTime.Parse(sUltDt);
            string sEssaDt = "";
            DateTime EssaDt;
            for (int i = (NrSites-1); i >-1; i--)
            {
                sEssaDt = dsResultado.Tables[0].Rows[i][colDtUltVis].ToString();
                EssaDt = DateTime.Parse(sEssaDt);
                if (UltDt==EssaDt)
                {
                    IndiceSite = i + 1;
                    break;
                }
            }
            if (IndiceSite==0)
            {
                // Reordenar();
                MessageBox.Show("Tudo foi visto", "Tudo foi visto");
                this.Close();
                return false;
            } else
            {
                return true;
            }
        }

        private void Reordenar(String sUltDt)
        {
            Console.WriteLine("Reordenando");
            String sData = "";
            List<Sites> lista = new List<Sites>();
            for (int i = 0;  i < NrSites; i++)
            {
                Sites Item = new Sites();
                Item.Endereco = dsResultado.Tables[0].Rows[i][colEndereco].ToString();
                Item.pontos = int.Parse(dsResultado.Tables[0].Rows[i][colpontos].ToString());
                Item.UltPosic = i;
                sData = dsResultado.Tables[0].Rows[i][colDtUltVis].ToString();
                Item.DtUltVis = DateTime.Parse(sData);

                /* if (i==122)
                {
                    int x = 0;
                } */

                // AQUI
                // Colocar uma parada no item 123
                // Parece não estar incrementando a pontuação, só para o último

                if (sData!= sUltDt)
                {
                    Item.pontos++;
                }
                Item.desatualizado = int.Parse(dsResultado.Tables[0].Rows[i][coldesatualizado].ToString());
                Item.seminteressante = int.Parse(dsResultado.Tables[0].Rows[i][colseminteressante].ToString());                
                lista.Add(Item);
            }
            List<Sites> Novalista = new List<Sites>();
            Novalista = lista.OrderByDescending(c => c.pontos).ToList();
            DataSet dsNewRes = new DataSet();
            dsNewRes.DataSetName = "Noticias";
            dsNewRes.Tables.Add("site");
            DataColumn dcEndereco = new DataColumn("Endereco", typeof(String));
            DataColumn dcpontos = new DataColumn("pontos", typeof(int));
            DataColumn dcDtUltVis = new DataColumn("DtUltVis", typeof(String));
            DataColumn dcdesatualizado = new DataColumn("desatualizado", typeof(int));
            DataColumn dcseminteressante = new DataColumn("seminteressante", typeof(int));
            DataColumn dcUltPosic = new DataColumn("UltPosic", typeof(int));
            dsNewRes.Tables[0].Columns.Add(dcEndereco);
            dsNewRes.Tables[0].Columns.Add(dcpontos);
            dsNewRes.Tables[0].Columns.Add(dcDtUltVis);
            dsNewRes.Tables[0].Columns.Add(dcdesatualizado);
            dsNewRes.Tables[0].Columns.Add(dcseminteressante);
            dsNewRes.Tables[0].Columns.Add(dcUltPosic);
            for (int i = 0; i < NrSites; i++)
            {
                DataRow nR = dsNewRes.Tables[0].NewRow();
                nR[colEndereco] = Novalista[i].Endereco;
                nR[colpontos] = Novalista[i].pontos;
                nR[colDtUltVis] = Novalista[i].DtUltVis.ToShortDateString();
                nR[coldesatualizado] = Novalista[i].desatualizado;
                nR[colseminteressante] = Novalista[i].seminteressante;
                nR[colUltPosic] = Novalista[i].UltPosic;
                dsNewRes.Tables[0].Rows.Add(nR);
            }
            dsNewRes.WriteXml(pathXML);
        }

        private Boolean Mostrar()
        {
            Boolean Ret = true;            
            try
            {
                linkLabel.Text = dsResultado.Tables[0].Rows[IndiceSite][colEndereco].ToString();
                SetaInf(IndiceSite, false);
                if (IndiceSite< progressBar.Maximum)
                {                    
                    lnkProximo.Text = dsResultado.Tables[0].Rows[IndiceSite+1][colEndereco].ToString();
                    SetaInf(IndiceSite + 1, true);
                    if (IndiceSite>0)
                    {
                        lnkAnterior.Text = dsResultado.Tables[0].Rows[IndiceSite -1][colEndereco].ToString();                        
                    }
                } else {
                    lnkProximo.Text = "";
                }
                int PosAnt = int.Parse(dsResultado.Tables[0].Rows[IndiceSite][colUltPosic].ToString());

                if (PosAnt == IndiceSite)
                {
                    picSobe.Visible = false;
                    picDesce.Visible = false;
                }
                else
                {
                    if (PosAnt > IndiceSite)
                    {
                        picSobe.Visible = true;
                        picDesce.Visible = false;
                    }
                    else
                    {
                        picSobe.Visible = false;
                        picDesce.Visible = true;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cabô", "Cabô");
                try
                {
                    this.Close();
                    Ret = false;
                }
                catch (Exception) { }                
            }
            progressBar.Value = IndiceSite;
            return Ret;
        }

        private void SetaInf(int Ind, Boolean Prox)
        {
            String Mens = "";
            int iDesat = int.Parse(dsResultado.Tables[0].Rows[Ind][coldesatualizado].ToString());
            if (iDesat == 9)
            {
                Mens = "Nove vezes sem atualização";
            }
            else
            {
                int iNadaInt = int.Parse(dsResultado.Tables[0].Rows[Ind][colseminteressante].ToString());
                if (iNadaInt == 19)
                {
                    Mens = "19 vezes sem interessante";
                }
            }
            if (Mens.Length == 0)
            {
                Mens = dsResultado.Tables[0].Rows[Ind][colDtUltVis].ToString();
            }

            if (Prox==false)
            {
                lbInfProx.Text = Mens;
            } else
            {                
                lbInf.Text = Mens;
                lbInfProxAnt.Text = lbPonto.Text;
                lbPonto.Text = dsResultado.Tables[0].Rows[Ind][colpontos].ToString();
            }
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Não atualizado
            Registra(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // atualizado mas nada de interessante
            Registra(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Atualizado e uma coisa interessante
            Registra(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Mais de uma coisa interessante
            Registra(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Novo site
            CadSite FCadSite = new CadSite();
            FCadSite.ShowDialog();
            dsResultado = new DataSet();
            CarregaXML();
        }

        private void Registra(int pontos)
        {
            Boolean apagar = false;            
            if (pontos>0)
            {
                int Sitepontos = int.Parse(dsResultado.Tables[0].Rows[IndiceSite][colpontos].ToString());
                Sitepontos += pontos;
                dsResultado.Tables[0].Rows[IndiceSite][colpontos] = Sitepontos.ToString();
                dsResultado.Tables[0].Rows[IndiceSite][coldesatualizado] = "0";
                if (pontos<2)
                {
                    // ATUALIZADO MAS SEM TER INTERESSANTE
                    int iNadaInt = int.Parse(dsResultado.Tables[0].Rows[IndiceSite][colseminteressante].ToString()) + 1;
                    if (iNadaInt==20)
                        apagar = true;
                    else
                        dsResultado.Tables[0].Rows[IndiceSite][colseminteressante] = iNadaInt.ToString();
                } else
                    // INTERERESSANTES
                    dsResultado.Tables[0].Rows[IndiceSite][colseminteressante] = "0";
            } else
            {
                // DESATUALIZADO
                int iDesat = int.Parse(dsResultado.Tables[0].Rows[IndiceSite][coldesatualizado].ToString())+1;
                if (iDesat == 10)
                    apagar = true;
                else
                    dsResultado.Tables[0].Rows[IndiceSite][coldesatualizado] = iDesat.ToString();
            }
            if (apagar == true)
                Apagar();
            else
            {
                dsResultado.Tables[0].Rows[IndiceSite][colDtUltVis] = sHoje;
                // dsResultado.Tables[0].Rows[IndiceSite][colDtUltVis] = DateTime.Today.ToShortDateString();
                
                dsResultado.WriteXml(pathXML);
                IndiceSite++;
            }

            if (Fechar)
            {
                this.Close();
            }
            else
            {
                Mostrar();
                if (linkLabel.Text.Length > 0)
                {
                    System.Diagnostics.Process.Start(linkLabel.Text);
                }
                timer1.Enabled = true;
            }
        }

        private void Apagar()
        {
            dsResultado.Tables[0].Rows.RemoveAt(IndiceSite);
            dsResultado.WriteXml(pathXML);
            NrSites--;
            progressBar.Maximum = NrSites;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Apagar();
            Mostrar();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (JaAtivou==false)
            {
                JaAtivou = true;
                try
                {
                    int h = Screen.PrimaryScreen.Bounds.Height;
                    Form1.ActiveForm.Top = h - 190;
                    // Form1.ActiveForm.Top = h - 150;

                }
                catch (Exception) { }
            }            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            this.WindowState = FormWindowState.Minimized;
        }

        private void llProximo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(lnkProximo.Text);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(lnkAnterior.Text);
        }

        private void chFechar_Click(object sender, EventArgs e)
        {
            Fechar = true;
        }
    }
}
