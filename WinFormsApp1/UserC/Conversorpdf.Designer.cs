namespace SmartConvert.UserC
{
    partial class Conversorpdf
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            guna2vSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            listBox1 = new ListBox();
            label1 = new Label();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 3;
            guna2Button1.CustomBorderColor = Color.FromArgb(24, 24, 23);
            guna2Button1.CustomBorderThickness = new Padding(3);
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Transparent;
            guna2Button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.FromArgb(24, 24, 23);
            guna2Button1.Location = new Point(27, 205);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(207, 38);
            guna2Button1.TabIndex = 0;
            guna2Button1.Text = "Localizar Arquivos";
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.BorderRadius = 4;
            guna2TextBox1.CustomizableEdges = customizableEdges3;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 9F);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(27, 37);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PasswordChar = '\0';
            guna2TextBox1.PlaceholderForeColor = Color.Black;
            guna2TextBox1.PlaceholderText = "C:\\";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2TextBox1.Size = new Size(693, 29);
            guna2TextBox1.TabIndex = 1;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.FromArgb(238, 234, 224);
            guna2Panel1.Controls.Add(guna2vSeparator1);
            guna2Panel1.Controls.Add(listBox1);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(guna2TextBox1);
            guna2Panel1.Controls.Add(guna2Button1);
            guna2Panel1.CustomizableEdges = customizableEdges5;
            guna2Panel1.Dock = DockStyle.Bottom;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Margin = new Padding(4);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel1.Size = new Size(748, 525);
            guna2Panel1.TabIndex = 2;
            guna2Panel1.Paint += guna2Panel1_Paint;
            // 
            // guna2vSeparator1
            // 
            guna2vSeparator1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            guna2vSeparator1.Location = new Point(0, 0);
            guna2vSeparator1.Name = "guna2vSeparator1";
            guna2vSeparator1.Size = new Size(10, 525);
            guna2vSeparator1.TabIndex = 4;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Teste de arquivo", "testes de arquivo 2 ", "Teste de arquivos 3", "Teste de arquivo", "testes de arquivo 2 ", "Teste de arquivos 3", "", "Teste de arquivo", "testes de arquivo 2 ", "Teste de arquivos 3", "", "Teste de arquivo", "testes de arquivo 2 ", "Teste de arquivos 3", "", "Teste de arquivo", "testes de arquivo 2 ", "Teste de arquivos 3", "", "Teste de arquivo", "testes de arquivo 2 ", "Teste de arquivos 3", "", "Teste de arquivo", "testes de arquivo 2 ", "Teste de arquivos 3", "Teste de arquivo", "testes de arquivo 2 ", "Teste de arquivos 3", "", "s" });
            listBox1.Location = new Point(27, 89);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(693, 90);
            listBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(24, 24, 23);
            label1.Location = new Point(27, 19);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 2;
            label1.Text = "Pasta";
            // 
            // Conversorpdf
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 234, 224);
            Controls.Add(guna2Panel1);
            Name = "Conversorpdf";
            Size = new Size(748, 525);
            Load += Conversorpdf_Load;
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label label1;
        private ListBox listBox1;
        private Guna.UI2.WinForms.Guna2VSeparator guna2vSeparator1;
    }
}
