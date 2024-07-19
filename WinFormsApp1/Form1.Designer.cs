namespace WinFormsApp1
{
    partial class SmartConverter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            Minimizar = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 9;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(249, 98, 88);
            guna2Button1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(12, 12);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(19, 19);
            guna2Button1.TabIndex = 0;
            guna2Button1.Text = "X";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.BorderRadius = 20;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorColor = Color.Transparent;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.ShadowColor = SystemColors.GradientActiveCaption;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Button2
            // 
            guna2Button2.BorderRadius = 9;
            guna2Button2.CustomizableEdges = customizableEdges5;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.FromArgb(255, 185, 47);
            guna2Button2.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Location = new Point(37, 12);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button2.Size = new Size(19, 19);
            guna2Button2.TabIndex = 1;
            guna2Button2.Text = "Maximizar";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // Minimizar
            // 
            Minimizar.BorderRadius = 9;
            Minimizar.CustomizableEdges = customizableEdges3;
            Minimizar.DisabledState.BorderColor = Color.DarkGray;
            Minimizar.DisabledState.CustomBorderColor = Color.DarkGray;
            Minimizar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Minimizar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Minimizar.FillColor = Color.FromArgb(37, 203, 66);
            Minimizar.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Minimizar.ForeColor = Color.White;
            Minimizar.Location = new Point(62, 12);
            Minimizar.Name = "Minimizar";
            Minimizar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Minimizar.Size = new Size(19, 19);
            Minimizar.TabIndex = 2;
            Minimizar.Text = "Minimize";
            Minimizar.Click += guna2Button3_Click;
            // 
            // SmartConverter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 247, 246);
            ClientSize = new Size(939, 574);
            Controls.Add(Minimizar);
            Controls.Add(guna2Button2);
            Controls.Add(guna2Button1);
            Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SmartConverter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += SmartConverter_Load;
            Click += SmartConverter_Click;
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button Minimizar;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}
