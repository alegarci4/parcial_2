namespace parcial_2
{
    partial class FormJugadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJugadores));
            label1 = new Label();
            textBoxNombre = new TextBox();
            label2 = new Label();
            textBoxNivel = new TextBox();
            button1 = new Button();
            buttonAgregar = new Button();
            buttonEliminar = new Button();
            dataGridViewJugadores = new DataGridView();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewJugadores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 24);
            label1.Name = "label1";
            label1.Size = new Size(78, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(100, 22);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(131, 27);
            textBoxNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(322, 24);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 2;
            label2.Text = "Nivel ";
            // 
            // textBoxNivel
            // 
            textBoxNivel.Location = new Point(386, 22);
            textBoxNivel.Name = "textBoxNivel";
            textBoxNivel.Size = new Size(131, 27);
            textBoxNivel.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 483);
            button1.Name = "button1";
            button1.Size = new Size(123, 48);
            button1.TabIndex = 6;
            button1.Text = "Menú Principal";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonAgregar
            // 
            buttonAgregar.BackColor = Color.LawnGreen;
            buttonAgregar.Location = new Point(484, 122);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(145, 39);
            buttonAgregar.TabIndex = 7;
            buttonAgregar.Text = "Agregar jugador ";
            buttonAgregar.UseVisualStyleBackColor = false;
            buttonAgregar.Click += buttonAgregar_Click_1;
            // 
            // buttonEliminar
            // 
            buttonEliminar.BackColor = Color.Red;
            buttonEliminar.Location = new Point(484, 177);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(145, 36);
            buttonEliminar.TabIndex = 8;
            buttonEliminar.Text = "Eliminar Jugador ";
            buttonEliminar.UseVisualStyleBackColor = false;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // dataGridViewJugadores
            // 
            dataGridViewJugadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewJugadores.Location = new Point(16, 122);
            dataGridViewJugadores.Name = "dataGridViewJugadores";
            dataGridViewJugadores.RowHeadersWidth = 51;
            dataGridViewJugadores.Size = new Size(444, 329);
            dataGridViewJugadores.TabIndex = 9;
            dataGridViewJugadores.CellContentClick += dataGridViewJugadores_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(458, 330);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 223);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // FormJugadores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(641, 555);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridViewJugadores);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonAgregar);
            Controls.Add(button1);
            Controls.Add(textBoxNivel);
            Controls.Add(label2);
            Controls.Add(textBoxNombre);
            Controls.Add(label1);
            Name = "FormJugadores";
            Text = "FormJugadores";
            ((System.ComponentModel.ISupportInitialize)dataGridViewJugadores).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxNombre;
        private Label label2;
        private TextBox textBoxNivel;
        private Button button1;
        private Button buttonAgregar;
        private Button buttonEliminar;
        private DataGridView dataGridViewJugadores;
        private PictureBox pictureBox1;
    }
}