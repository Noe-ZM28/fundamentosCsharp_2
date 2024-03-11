namespace fundamentosCsharp_2
{
    partial class Form_data
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
            textBox_id = new TextBox();
            button_search_info = new Button();
            button_add_info = new Button();
            button_delete_info = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            dataGridView_data = new DataGridView();
            textBox_Sonido = new TextBox();
            label1 = new Label();
            textBox_Tamaño = new TextBox();
            label2 = new Label();
            textBox_Nombre = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox_Velocidad = new TextBox();
            textBox_Familia = new TextBox();
            label5 = new Label();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_data).BeginInit();
            SuspendLayout();
            // 
            // textBox_id
            // 
            textBox_id.Location = new Point(3, 3);
            textBox_id.Name = "textBox_id";
            textBox_id.Size = new Size(84, 23);
            textBox_id.TabIndex = 1;
            // 
            // button_search_info
            // 
            button_search_info.Location = new Point(93, 3);
            button_search_info.Name = "button_search_info";
            button_search_info.Size = new Size(75, 23);
            button_search_info.TabIndex = 0;
            button_search_info.Text = "Buscar";
            button_search_info.UseVisualStyleBackColor = true;
            button_search_info.Click += button_search_info_Click;
            // 
            // button_add_info
            // 
            button_add_info.Location = new Point(555, 73);
            button_add_info.Name = "button_add_info";
            button_add_info.Size = new Size(75, 23);
            button_add_info.TabIndex = 2;
            button_add_info.Text = "Añadir";
            button_add_info.UseVisualStyleBackColor = true;
            button_add_info.Click += button_add_info_Click;
            // 
            // button_delete_info
            // 
            button_delete_info.Location = new Point(174, 3);
            button_delete_info.Name = "button_delete_info";
            button_delete_info.Size = new Size(75, 23);
            button_delete_info.TabIndex = 4;
            button_delete_info.Text = "Eliminar";
            button_delete_info.UseVisualStyleBackColor = true;
            button_delete_info.Click += button_delete_info_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(textBox_id);
            flowLayoutPanel1.Controls.Add(button_search_info);
            flowLayoutPanel1.Controls.Add(button_delete_info);
            flowLayoutPanel1.Location = new Point(257, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(257, 30);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(dataGridView_data);
            flowLayoutPanel2.Location = new Point(12, 115);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(677, 157);
            flowLayoutPanel2.TabIndex = 6;
            // 
            // dataGridView_data
            // 
            dataGridView_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_data.Location = new Point(3, 3);
            dataGridView_data.Name = "dataGridView_data";
            dataGridView_data.Size = new Size(674, 150);
            dataGridView_data.TabIndex = 0;
            dataGridView_data.CellDoubleClick += dataGridView_data_CellDoubleClick;
            // 
            // textBox_Sonido
            // 
            textBox_Sonido.Location = new Point(131, 73);
            textBox_Sonido.Name = "textBox_Sonido";
            textBox_Sonido.Size = new Size(100, 23);
            textBox_Sonido.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(159, 55);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 8;
            label1.Text = "Sonido";
            // 
            // textBox_Tamaño
            // 
            textBox_Tamaño.Location = new Point(237, 73);
            textBox_Tamaño.Name = "textBox_Tamaño";
            textBox_Tamaño.Size = new Size(100, 23);
            textBox_Tamaño.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(259, 55);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 10;
            label2.Text = "Tamaño";
            // 
            // textBox_Nombre
            // 
            textBox_Nombre.Location = new Point(343, 73);
            textBox_Nombre.Name = "textBox_Nombre";
            textBox_Nombre.Size = new Size(100, 23);
            textBox_Nombre.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(367, 55);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 12;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(476, 55);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 13;
            label4.Text = "Velocidad";
            // 
            // textBox_Velocidad
            // 
            textBox_Velocidad.Location = new Point(449, 73);
            textBox_Velocidad.Name = "textBox_Velocidad";
            textBox_Velocidad.Size = new Size(100, 23);
            textBox_Velocidad.TabIndex = 14;
            // 
            // textBox_Familia
            // 
            textBox_Familia.Location = new Point(25, 73);
            textBox_Familia.Name = "textBox_Familia";
            textBox_Familia.Size = new Size(100, 23);
            textBox_Familia.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 55);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 16;
            label5.Text = "Familia";
            // 
            // Form_data
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 277);
            Controls.Add(label5);
            Controls.Add(textBox_Familia);
            Controls.Add(textBox_Velocidad);
            Controls.Add(label4);
            Controls.Add(button_add_info);
            Controls.Add(label3);
            Controls.Add(textBox_Nombre);
            Controls.Add(label2);
            Controls.Add(textBox_Tamaño);
            Controls.Add(label1);
            Controls.Add(textBox_Sonido);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Name = "Form_data";
            Text = "CRUD";
            Load += Form1_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_search_info;
        private TextBox textBox_id;
        private Button button_add_info;
        private Button button_delete_info;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private DataGridView dataGridView_data;
        private TextBox textBox_Sonido;
        private Label label1;
        private TextBox textBox_Tamaño;
        private Label label2;
        private TextBox textBox_Nombre;
        private Label label3;
        private Label label4;
        private TextBox textBox_Velocidad;
        private TextBox textBox_Familia;
        private Label label5;
    }
}
