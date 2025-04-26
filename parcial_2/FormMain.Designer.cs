namespace parcial_2
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonJugadores = new Button();
            buttonInventario = new Button();
            buttonSalir = new Button();
            buttonExcel = new Button();
            buttonExcelBloque = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // buttonJugadores
            // 
            buttonJugadores.BackColor = Color.Salmon;
            buttonJugadores.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonJugadores.Location = new Point(272, 89);
            buttonJugadores.Margin = new Padding(4, 2, 4, 2);
            buttonJugadores.Name = "buttonJugadores";
            buttonJugadores.Size = new Size(236, 61);
            buttonJugadores.TabIndex = 0;
            buttonJugadores.Text = "Jugadores";
            buttonJugadores.UseVisualStyleBackColor = false;
            buttonJugadores.Click += buttonJugadores_Click;
            // 
            // buttonInventario
            // 
            buttonInventario.BackColor = Color.LightSalmon;
            buttonInventario.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonInventario.Location = new Point(272, 185);
            buttonInventario.Margin = new Padding(4, 2, 4, 2);
            buttonInventario.Name = "buttonInventario";
            buttonInventario.Size = new Size(236, 61);
            buttonInventario.TabIndex = 1;
            buttonInventario.Text = "Inventario";
            buttonInventario.UseVisualStyleBackColor = false;
            buttonInventario.Click += buttonInventario_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.BackColor = Color.OrangeRed;
            buttonSalir.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSalir.ForeColor = SystemColors.ButtonHighlight;
            buttonSalir.Location = new Point(14, 452);
            buttonSalir.Margin = new Padding(4, 2, 4, 2);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(128, 42);
            buttonSalir.TabIndex = 2;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = false;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // buttonExcel
            // 
            buttonExcel.BackColor = Color.Salmon;
            buttonExcel.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonExcel.Location = new Point(272, 285);
            buttonExcel.Margin = new Padding(4, 2, 4, 2);
            buttonExcel.Name = "buttonExcel";
            buttonExcel.Size = new Size(236, 61);
            buttonExcel.TabIndex = 3;
            buttonExcel.Text = "Transferir tabla Jugador a Excel";
            buttonExcel.UseVisualStyleBackColor = false;
            buttonExcel.Click += buttonExcel_Click;
            // 
            // buttonExcelBloque
            // 
            buttonExcelBloque.BackColor = Color.LightSalmon;
            buttonExcelBloque.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonExcelBloque.Location = new Point(272, 375);
            buttonExcelBloque.Margin = new Padding(4, 2, 4, 2);
            buttonExcelBloque.Name = "buttonExcelBloque";
            buttonExcelBloque.Size = new Size(236, 61);
            buttonExcelBloque.TabIndex = 4;
            buttonExcelBloque.Text = "Transferir tabla Bloque a Excel";
            buttonExcelBloque.UseVisualStyleBackColor = false;
            buttonExcelBloque.Click += buttonExcelBloque_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Bright", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(122, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(565, 33);
            label1.TabIndex = 5;
            label1.Text = "SISTEMA DE GESTIÓN DE MINECRAFT";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(68, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(694, 30);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(763, 514);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(buttonExcelBloque);
            Controls.Add(buttonExcel);
            Controls.Add(buttonSalir);
            Controls.Add(buttonInventario);
            Controls.Add(buttonJugadores);
            Font = new Font("Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 2);
            Margin = new Padding(4, 2, 4, 2);
            Name = "FormMain";
            Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonJugadores;
        private Button buttonInventario;
        private Button buttonSalir;
        private Button buttonExcel;
        private Button buttonExcelBloque;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}