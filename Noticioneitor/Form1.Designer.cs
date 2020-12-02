namespace Noticioneitor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.button6 = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lbInf = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lnkProximo = new System.Windows.Forms.LinkLabel();
            this.lnkAnterior = new System.Windows.Forms.LinkLabel();
            this.lbInfProx = new System.Windows.Forms.Label();
            this.picSobe = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.picDesce = new System.Windows.Forms.PictureBox();
            this.chFechar = new System.Windows.Forms.CheckBox();
            this.lbPonto = new System.Windows.Forms.Label();
            this.lbInfProxAnt = new System.Windows.Forms.Label();
            this.lbPontoAnt = new System.Windows.Forms.Label();
            this.lbInAntAnt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSobe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDesce)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "0";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(174, 64);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(255, 64);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "3";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(336, 64);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Novo";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // linkLabel
            // 
            this.linkLabel.Location = new System.Drawing.Point(12, 27);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(295, 18);
            this.linkLabel.TabIndex = 6;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "linkLabel1";
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(417, 64);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "Apagar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 93);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(543, 23);
            this.progressBar.TabIndex = 8;
            // 
            // lbInf
            // 
            this.lbInf.BackColor = System.Drawing.SystemColors.Control;
            this.lbInf.Location = new System.Drawing.Point(414, 27);
            this.lbInf.Name = "lbInf";
            this.lbInf.Size = new System.Drawing.Size(138, 18);
            this.lbInf.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lnkProximo
            // 
            this.lnkProximo.Location = new System.Drawing.Point(12, 45);
            this.lnkProximo.Name = "lnkProximo";
            this.lnkProximo.Size = new System.Drawing.Size(318, 18);
            this.lnkProximo.TabIndex = 10;
            this.lnkProximo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llProximo_LinkClicked);
            // 
            // lnkAnterior
            // 
            this.lnkAnterior.Location = new System.Drawing.Point(12, 9);
            this.lnkAnterior.Name = "lnkAnterior";
            this.lnkAnterior.Size = new System.Drawing.Size(318, 18);
            this.lnkAnterior.TabIndex = 11;
            this.lnkAnterior.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lbInfProx
            // 
            this.lbInfProx.Location = new System.Drawing.Point(342, 45);
            this.lbInfProx.Name = "lbInfProx";
            this.lbInfProx.Size = new System.Drawing.Size(150, 18);
            this.lbInfProx.TabIndex = 12;
            // 
            // picSobe
            // 
            this.picSobe.Image = ((System.Drawing.Image)(resources.GetObject("picSobe.Image")));
            this.picSobe.Location = new System.Drawing.Point(313, 21);
            this.picSobe.Name = "picSobe";
            this.picSobe.Size = new System.Drawing.Size(32, 24);
            this.picSobe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSobe.TabIndex = 13;
            this.picSobe.TabStop = false;
            this.picSobe.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "sobe.png");
            this.imageList1.Images.SetKeyName(1, "desce.png");
            // 
            // picDesce
            // 
            this.picDesce.Image = ((System.Drawing.Image)(resources.GetObject("picDesce.Image")));
            this.picDesce.Location = new System.Drawing.Point(313, 21);
            this.picDesce.Name = "picDesce";
            this.picDesce.Size = new System.Drawing.Size(32, 24);
            this.picDesce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDesce.TabIndex = 14;
            this.picDesce.TabStop = false;
            this.picDesce.Visible = false;
            // 
            // chFechar
            // 
            this.chFechar.Appearance = System.Windows.Forms.Appearance.Button;
            this.chFechar.AutoSize = true;
            this.chFechar.Location = new System.Drawing.Point(498, 64);
            this.chFechar.Name = "chFechar";
            this.chFechar.Size = new System.Drawing.Size(57, 23);
            this.chFechar.TabIndex = 15;
            this.chFechar.Text = "Encerrar";
            this.chFechar.UseVisualStyleBackColor = true;
            this.chFechar.Click += new System.EventHandler(this.chFechar_Click);
            // 
            // lbPonto
            // 
            this.lbPonto.BackColor = System.Drawing.SystemColors.Control;
            this.lbPonto.Location = new System.Drawing.Point(351, 27);
            this.lbPonto.Name = "lbPonto";
            this.lbPonto.Size = new System.Drawing.Size(31, 18);
            this.lbPonto.TabIndex = 16;
            // 
            // lbInfProxAnt
            // 
            this.lbInfProxAnt.BackColor = System.Drawing.SystemColors.Control;
            this.lbInfProxAnt.Location = new System.Drawing.Point(351, 9);
            this.lbInfProxAnt.Name = "lbInfProxAnt";
            this.lbInfProxAnt.Size = new System.Drawing.Size(30, 18);
            this.lbInfProxAnt.TabIndex = 17;
            // 
            // lbPontoAnt
            // 
            this.lbPontoAnt.BackColor = System.Drawing.SystemColors.Control;
            this.lbPontoAnt.Location = new System.Drawing.Point(388, 27);
            this.lbPontoAnt.Name = "lbPontoAnt";
            this.lbPontoAnt.Size = new System.Drawing.Size(31, 18);
            this.lbPontoAnt.TabIndex = 18;
            // 
            // lbInAntAnt
            // 
            this.lbInAntAnt.BackColor = System.Drawing.SystemColors.Control;
            this.lbInAntAnt.Location = new System.Drawing.Point(388, 9);
            this.lbInAntAnt.Name = "lbInAntAnt";
            this.lbInAntAnt.Size = new System.Drawing.Size(31, 18);
            this.lbInAntAnt.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 124);
            this.Controls.Add(this.lbInAntAnt);
            this.Controls.Add(this.lbPontoAnt);
            this.Controls.Add(this.lbInfProxAnt);
            this.Controls.Add(this.lbPonto);
            this.Controls.Add(this.chFechar);
            this.Controls.Add(this.picDesce);
            this.Controls.Add(this.picSobe);
            this.Controls.Add(this.lbInfProx);
            this.Controls.Add(this.lnkAnterior);
            this.Controls.Add(this.lnkProximo);
            this.Controls.Add(this.lbInf);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoticioNeitor";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSobe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDesce)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lbInf;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.LinkLabel lnkProximo;
        private System.Windows.Forms.LinkLabel lnkAnterior;
        private System.Windows.Forms.Label lbInfProx;
        private System.Windows.Forms.PictureBox picSobe;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox picDesce;
        private System.Windows.Forms.CheckBox chFechar;
        private System.Windows.Forms.Label lbPonto;
        private System.Windows.Forms.Label lbInfProxAnt;
        private System.Windows.Forms.Label lbPontoAnt;
        private System.Windows.Forms.Label lbInAntAnt;
    }
}

