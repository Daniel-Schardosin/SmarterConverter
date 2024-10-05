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
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.Reflection.Metadata;

namespace SmartConvert.UserC
{
    public partial class Conversorpdf : UserControl
    {

        String DiretorioEscolhido;
        String[] ArquivosPDF;
        Boolean Erro = false;
        String PastaDesaida;

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
            string fontPath = System.IO.Path.Combine(Application.StartupPath, "Fonts/SF-Pro", "SF-Pro-Display-BoldItalic.otf");
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
                    ArquivosPDF = Directory.GetFiles(DiretorioEscolhido, "*.pdf");
                    listBox1.Items.Clear();

                    if (ArquivosPDF.Length > 0)
                    {
                        this.guna2Button2.Visible = true;
                       
                    }
                    else
                    {
                        MessageBox.Show("Nenhum arquivo no formato PDF foi encontrado!");
                    }



                    foreach (string File in ArquivosPDF)
                    {
                        listBox1.Items.Add(System.IO.Path.GetFileName(File));
                    }
                }
            }

        }

        private void guna2Button2_Click(object sender, EventArgs e)

        {

            foreach (String pdfpath in ArquivosPDF)
            {

                try
                {
                    String text = ExtrairTextoPDF(pdfpath);


                    String PastadeSaida = System.IO.Path.Combine(DiretorioEscolhido, "Saída");

                    if (Directory.Exists(PastadeSaida))
                    {
                        String NomeArquivo = System.IO.Path.GetFileNameWithoutExtension(pdfpath) + ".txt";
                        NomeArquivo = NomeArquivo.ToLower();
                        String GravaSaida = System.IO.Path.Combine(PastadeSaida, NomeArquivo);
                        File.WriteAllText(GravaSaida, text);
                        PastaDesaida = PastadeSaida;


                    }
                    else
                    {
                        Directory.CreateDirectory(PastadeSaida);
                        String NomeArquivo = System.IO.Path.GetFileNameWithoutExtension(pdfpath) + ".txt";
                        NomeArquivo = NomeArquivo.ToLower();
                        String GravaSaida = System.IO.Path.Combine(PastadeSaida, NomeArquivo);
                        File.WriteAllText(GravaSaida, text);
                        PastaDesaida = PastadeSaida;
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao converter o arquivo {System.IO.Path.GetFileName(pdfpath)}:{ex.Message}");
                    Erro = true;
                }
                
            }
            if (Erro == false)
            {
               MessageBox.Show("Conversão concluída!");
                Process.Start("explorer.exe", PastaDesaida);

            }

        }
        private string ExtrairTextoPDF(string path)
        {
            try
            {
                using (PdfReader reader = new PdfReader(path))
                {
                    StringWriter output = new StringWriter();
                    for (int i = 1; i <= reader.NumberOfPages; i++)
                    {
                        output.WriteLine(PdfTextExtractor.GetTextFromPage(reader, i));
                    }
                    return output.ToString();
                }
            }
            catch (iTextSharp.text.exceptions.InvalidPdfException ex)
            {
                throw new Exception("O arquivo não é um PDF válido ou está corrompido.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao ler o arquivo PDF.", ex);
            }

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            SelecDirectory();
        }

       
    }
}
