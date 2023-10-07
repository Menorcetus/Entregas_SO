namespace Cliente
{
    partial class Form1
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
            NombreLab = new Label();
            NombreText = new TextBox();
            groupBox1 = new GroupBox();
            Enviar = new Button();
            Alto = new RadioButton();
            Longitud = new RadioButton();
            Nombre = new RadioButton();
            AlturaText = new TextBox();
            AltruaLab = new Label();
            Conexion = new Button();
            button1 = new Button();
            Palindromo = new RadioButton();
            Mayus = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // NombreLab
            // 
            NombreLab.AutoSize = true;
            NombreLab.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NombreLab.ForeColor = SystemColors.ControlText;
            NombreLab.ImageAlign = ContentAlignment.MiddleRight;
            NombreLab.Location = new Point(26, 43);
            NombreLab.Name = "NombreLab";
            NombreLab.Size = new Size(108, 35);
            NombreLab.TabIndex = 0;
            NombreLab.Text = "Nombre";
            // 
            // NombreText
            // 
            NombreText.Location = new Point(130, 53);
            NombreText.Margin = new Padding(3, 4, 3, 4);
            NombreText.Name = "NombreText";
            NombreText.Size = new Size(260, 27);
            NombreText.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveBorder;
            groupBox1.Controls.Add(Enviar);
            groupBox1.Controls.Add(Mayus);
            groupBox1.Controls.Add(Palindromo);
            groupBox1.Controls.Add(Alto);
            groupBox1.Controls.Add(Longitud);
            groupBox1.Controls.Add(Nombre);
            groupBox1.Controls.Add(AlturaText);
            groupBox1.Controls.Add(AltruaLab);
            groupBox1.Controls.Add(NombreText);
            groupBox1.Controls.Add(NombreLab);
            groupBox1.Location = new Point(99, 152);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(443, 474);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Peticion";
            // 
            // Enviar
            // 
            Enviar.Location = new Point(133, 395);
            Enviar.Margin = new Padding(3, 4, 3, 4);
            Enviar.Name = "Enviar";
            Enviar.Size = new Size(161, 52);
            Enviar.TabIndex = 3;
            Enviar.Text = "Enviar";
            Enviar.UseVisualStyleBackColor = true;
            Enviar.Click += Enviar_Click;
            // 
            // Alto
            // 
            Alto.AutoSize = true;
            Alto.Location = new Point(133, 219);
            Alto.Margin = new Padding(3, 4, 3, 4);
            Alto.Name = "Alto";
            Alto.Size = new Size(136, 24);
            Alto.TabIndex = 2;
            Alto.TabStop = true;
            Alto.Text = "Dime si soy alto";
            Alto.UseVisualStyleBackColor = true;
            // 
            // Longitud
            // 
            Longitud.AutoSize = true;
            Longitud.Location = new Point(133, 185);
            Longitud.Margin = new Padding(3, 4, 3, 4);
            Longitud.Name = "Longitud";
            Longitud.Size = new Size(240, 24);
            Longitud.TabIndex = 2;
            Longitud.TabStop = true;
            Longitud.Text = "Dime la longitud de mi nombre";
            Longitud.UseVisualStyleBackColor = true;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(133, 152);
            Nombre.Margin = new Padding(3, 4, 3, 4);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(223, 24);
            Nombre.TabIndex = 2;
            Nombre.TabStop = true;
            Nombre.Text = "Dime si mi nombre es bonito";
            Nombre.UseVisualStyleBackColor = true;
            // 
            // AlturaText
            // 
            AlturaText.Location = new Point(130, 92);
            AlturaText.Margin = new Padding(3, 4, 3, 4);
            AlturaText.Name = "AlturaText";
            AlturaText.Size = new Size(260, 27);
            AlturaText.TabIndex = 1;
            // 
            // AltruaLab
            // 
            AltruaLab.AutoSize = true;
            AltruaLab.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            AltruaLab.ForeColor = SystemColors.ControlText;
            AltruaLab.ImageAlign = ContentAlignment.MiddleRight;
            AltruaLab.Location = new Point(26, 81);
            AltruaLab.Name = "AltruaLab";
            AltruaLab.Size = new Size(81, 35);
            AltruaLab.TabIndex = 0;
            AltruaLab.Text = "Altura";
            // 
            // Conexion
            // 
            Conexion.Location = new Point(99, 45);
            Conexion.Margin = new Padding(3, 4, 3, 4);
            Conexion.Name = "Conexion";
            Conexion.Size = new Size(202, 68);
            Conexion.TabIndex = 7;
            Conexion.Text = "Conectar";
            Conexion.UseVisualStyleBackColor = true;
            Conexion.Click += Connexion_Click;
            // 
            // button1
            // 
            button1.Location = new Point(327, 45);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(215, 68);
            button1.TabIndex = 8;
            button1.Text = "Desconectar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Palindromo
            // 
            Palindromo.AutoSize = true;
            Palindromo.Location = new Point(133, 251);
            Palindromo.Margin = new Padding(3, 4, 3, 4);
            Palindromo.Name = "Palindromo";
            Palindromo.Size = new Size(252, 24);
            Palindromo.TabIndex = 2;
            Palindromo.TabStop = true;
            Palindromo.Text = "Dime si el nombre es palindromo";
            Palindromo.UseVisualStyleBackColor = true;
            // 
            // Mayus
            // 
            Mayus.AutoSize = true;
            Mayus.Location = new Point(133, 283);
            Mayus.Margin = new Padding(3, 4, 3, 4);
            Mayus.Name = "Mayus";
            Mayus.Size = new Size(240, 24);
            Mayus.TabIndex = 2;
            Mayus.TabStop = true;
            Mayus.Text = "Escribe el nombre en maysculas";
            Mayus.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 691);
            Controls.Add(button1);
            Controls.Add(Conexion);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label NombreLab;
        private TextBox NombreText;
        private GroupBox groupBox1;
        private Button Enviar;
        private RadioButton Alto;
        private RadioButton Longitud;
        private RadioButton Nombre;
        private TextBox AlturaText;
        private Label AltruaLab;
        private Button Conexion;
        private Button button1;
        private RadioButton Mayus;
        private RadioButton Palindromo;
    }
}