namespace parcial_2
{
    partial class FormInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInventario));
            label1 = new Label();
            comboBoxRarezas = new ComboBox();
            dataGridViewInventario = new DataGridView();
            buttonMenu = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(52, 24);
            label1.Name = "label1";
            label1.Size = new Size(286, 24);
            label1.TabIndex = 0;
            label1.Text = "Busca por su tipo de rareza";
            // 
            // comboBoxRarezas
            // 
            comboBoxRarezas.BackColor = Color.Thistle;
            comboBoxRarezas.FormattingEnabled = true;
            comboBoxRarezas.Location = new Point(344, 24);
            comboBoxRarezas.Name = "comboBoxRarezas";
            comboBoxRarezas.Size = new Size(193, 28);
            comboBoxRarezas.TabIndex = 1;
            comboBoxRarezas.SelectedIndexChanged += comboBoxRarezas_SelectedIndexChanged;
            // 
            // dataGridViewInventario
            // 
            dataGridViewInventario.BackgroundColor = Color.SlateBlue;
            dataGridViewInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInventario.GridColor = Color.MediumPurple;
            dataGridViewInventario.Location = new Point(52, 79);
            dataGridViewInventario.Name = "dataGridViewInventario";
            dataGridViewInventario.RowHeadersWidth = 51;
            dataGridViewInventario.Size = new Size(459, 275);
            dataGridViewInventario.TabIndex = 2;
            dataGridViewInventario.CellContentClick += dataGridViewInventario_CellContentClick;
            // 
            // buttonMenu
            // 
            buttonMenu.BackColor = Color.CornflowerBlue;
            buttonMenu.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMenu.ForeColor = Color.White;
            buttonMenu.Location = new Point(17, 377);
            buttonMenu.Name = "buttonMenu";
            buttonMenu.Size = new Size(136, 40);
            buttonMenu.TabIndex = 3;
            buttonMenu.Text = "Menú principal";
            buttonMenu.UseVisualStyleBackColor = false;
            buttonMenu.Click += buttonMenu_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // FormInventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(559, 450);
            Controls.Add(pictureBox1);
            Controls.Add(buttonMenu);
            Controls.Add(dataGridViewInventario);
            Controls.Add(comboBoxRarezas);
            Controls.Add(label1);
            Name = "FormInventario";
            Text = "FormInventario";
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxRarezas;
        private DataGridView dataGridViewInventario;
        private Button buttonMenu;
        private PictureBox pictureBox1;
    }
}