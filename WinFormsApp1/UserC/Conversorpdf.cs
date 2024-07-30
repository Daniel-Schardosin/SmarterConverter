﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using WinFormsApp1;
using System.Diagnostics;

namespace SmartConvert.UserC
{
    public partial class Conversorpdf : UserControl
    {

        String DiretorioEscolhido;
        String[] ArquivosPDF;


        public Conversorpdf()
        {
            InitializeComponent();
            LoadCustomFont();
            ApplyFontToControls2(this);
            this.guna2Button2.Visible = false;
        }


        private void LoadCustomFont()
        {
            _fontCollection = new PrivateFontCollection();
            string fontPath = Path.Combine(Application.StartupPath, "Fonts/Pixel", "PixelifySans-Medium.ttf");
            _fontCollection.AddFontFile(fontPath);

            // Define a fonte padrão para o formulário
            this.Font = new Font(_fontCollection.Families[0], 15);
        }


        private void ApplyFontToControls2(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                control.Font = new Font(_fontCollection.Families[0], 11);
                // Recursivamente aplique a todos os controles filhos
                if (control.Controls.Count > 0)
                {
                    ApplyFontToControls2(control);
                }
            }

        }


        private PrivateFontCollection _fontCollection;




        private void Conversorpdf_Load(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SelecDirectory();

        }
        private void SelecDirectory()
        {
            using (FolderBrowserDialog DiretorioArquivos = new FolderBrowserDialog())
            {
                DiretorioArquivos.Description = "Selecione um diretório";
                DiretorioArquivos.ShowNewFolderButton = true;

                DialogResult Result = DiretorioArquivos.ShowDialog();

                if (Result == DialogResult.OK && !string.IsNullOrEmpty(DiretorioArquivos.SelectedPath))
                {
                    DiretorioEscolhido = DiretorioArquivos.SelectedPath;
                    guna2TextBox1.Text = DiretorioEscolhido;
                    this.guna2Button2.Visible = true;
                    ArquivosPDF = Directory.GetFiles(DiretorioEscolhido, "*.pdf");


                    listBox1.Items.Clear();

                    foreach (string File in ArquivosPDF)
                    {
                        listBox1.Items.Add(Path.GetFileName(File));   
                    }
                }
            }

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
