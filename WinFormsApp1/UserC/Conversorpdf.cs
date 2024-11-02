using System;
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
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace SmartConvert.UserC
{
    public partial class Conversorpdf : UserControl
    {
        String DiretorioEscolhido;
        String[] ArquivosPDF;
        Boolean Erro = false;
        String PastaDeSaida;
        Boolean validador = false;

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
                if (control.Controls.Count > 0)
                {
                    ApplyFontToControls2(control);
                }
            }
        }

        private PrivateFontCollection _fontCollection;

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
                        foreach (string File in ArquivosPDF)
                        {
                            listBox1.Items.Add(System.IO.Path.GetFileName(File));
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nenhum arquivo no formato PDF foi encontrado!");
                    }

                   
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (!validador)
            {
                foreach (String pdfpath in ArquivosPDF)
                {
                    try
                    {
                        String text = ExtrairTextoPDF(pdfpath);

                        String pastaDeSaida = System.IO.Path.Combine(DiretorioEscolhido, "Saída");

                        if (!Directory.Exists(pastaDeSaida))
                        {
                            Directory.CreateDirectory(pastaDeSaida);
                        }

                        String nomeArquivo = System.IO.Path.GetFileNameWithoutExtension(pdfpath) + ".txt";
                        String gravaSaida = System.IO.Path.Combine(pastaDeSaida, nomeArquivo.ToLower());
                        File.WriteAllText(gravaSaida, text);
                        PastaDeSaida = pastaDeSaida;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao converter o arquivo {System.IO.Path.GetFileName(pdfpath)}: {ex.Message}");
                        Erro = true;
                    }
                }

                if (!Erro)
                {
                    validador = true;
                    MessageBox.Show("Conversão concluída!");
                    AbrirDiretorioSaida(PastaDeSaida);
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Está convertendo os mesmos arquivos. Deseja continuar?", "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

                validador = result != DialogResult.Yes;
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
            validador = false;
        }

        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        private void AbrirDiretorioSaida(string pastaDeSaida)
        {
            if (!IsExplorerOpenInDirectory(pastaDeSaida))
            {
                Process.Start("explorer.exe", pastaDeSaida);
            }
            else
            {
                var hwnd = FindWindow("CabinetWClass", System.IO.Path.GetFileName(pastaDeSaida));
                if (hwnd != IntPtr.Zero)
                {
                    SetForegroundWindow(hwnd);
                }
            }
        }

        private bool IsExplorerOpenInDirectory(string path)
        {
            path = System.IO.Path.GetFullPath(path).TrimEnd(System.IO.Path.DirectorySeparatorChar).ToLowerInvariant();

            foreach (var proc in Process.GetProcessesByName("explorer"))
            {
                try
                {
                    if (proc.MainModule.FileName.ToLowerInvariant() == "c:\\windows\\explorer.exe" &&
                        proc.MainWindowTitle.ToLowerInvariant().Contains(System.IO.Path.GetFileName(path)))
                    {
                        return true;
                    }
                }
                catch
                {
                    continue;
                }
            }
            return false;
        }
    }
}
