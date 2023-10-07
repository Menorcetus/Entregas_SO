namespace Ex_extra
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
            Transformador = new GroupBox();
            Enviar = new Button();
            Selector = new ComboBox();
            Temperatura = new NumericUpDown();
            Titulo = new Label();
            Conectar = new Button();
            Desconectar = new Button();
            Transformador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Temperatura).BeginInit();
            SuspendLayout();
            // 
            // Transformador
            // 
            Transformador.BackColor = SystemColors.AppWorkspace;
            Transformador.Controls.Add(Enviar);
            Transformador.Controls.Add(Selector);
            Transformador.Controls.Add(Temperatura);
            Transformador.Controls.Add(Titulo);
            Transformador.ForeColor = SystemColors.ControlText;
            Transformador.Location = new Point(90, 121);
            Transformador.Name = "Transformador";
            Transformador.Size = new Size(406, 185);
            Transformador.TabIndex = 0;
            Transformador.TabStop = false;
            Transformador.Text = "Transforamdor";
            // 
            // Enviar
            // 
            Enviar.Dock = DockStyle.Bottom;
            Enviar.Location = new Point(3, 131);
            Enviar.Name = "Enviar";
            Enviar.Size = new Size(400, 51);
            Enviar.TabIndex = 5;
            Enviar.Text = "Transformar";
            Enviar.UseVisualStyleBackColor = true;
            Enviar.Click += Enviar_Click;
            // 
            // Selector
            // 
            Selector.FormattingEnabled = true;
            Selector.Items.AddRange(new object[] { "Cº", "Fº" });
            Selector.Location = new Point(300, 58);
            Selector.Name = "Selector";
            Selector.Size = new Size(82, 28);
            Selector.TabIndex = 4;
            // 
            // Temperatura
            // 
            Temperatura.DecimalPlaces = 2;
            Temperatura.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            Temperatura.Location = new Point(195, 58);
            Temperatura.Name = "Temperatura";
            Temperatura.Size = new Size(80, 27);
            Temperatura.TabIndex = 2;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Titulo.Location = new Point(6, 50);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(155, 35);
            Titulo.TabIndex = 0;
            Titulo.Text = "Temperatura";
            // 
            // Conectar
            // 
            Conectar.Location = new Point(90, 34);
            Conectar.Name = "Conectar";
            Conectar.Size = new Size(177, 56);
            Conectar.TabIndex = 1;
            Conectar.Text = "Conectar";
            Conectar.UseVisualStyleBackColor = true;
            Conectar.Click += Conectar_Click;
            // 
            // Desconectar
            // 
            Desconectar.Location = new Point(329, 34);
            Desconectar.Name = "Desconectar";
            Desconectar.Size = new Size(167, 56);
            Desconectar.TabIndex = 2;
            Desconectar.Text = "Desconectar";
            Desconectar.UseVisualStyleBackColor = true;
            Desconectar.Click += Desconectar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 412);
            Controls.Add(Desconectar);
            Controls.Add(Conectar);
            Controls.Add(Transformador);
            Name = "Form1";
            Text = "Form1";
            Transformador.ResumeLayout(false);
            Transformador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Temperatura).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Transformador;
        private Label Titulo;
        private NumericUpDown Temperatura;
        private ComboBox Selector;
        private Button Enviar;
        private Button Conectar;
        private Button Desconectar;
    }
}