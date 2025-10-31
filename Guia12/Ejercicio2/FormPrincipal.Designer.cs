namespace Ejercicio2
{
    partial class FormPrincipal
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
            lbDarsenaConcesionaria = new ListBox();
            btnCrearCamion = new Button();
            button2 = new Button();
            button3 = new Button();
            btnCerrarCamion = new Button();
            lbItinerarioCamion = new ListBox();
            btnRecibirCamion = new Button();
            btnDescargarCamionRecibido = new Button();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lbDarsenaConcesionaria
            // 
            lbDarsenaConcesionaria.FormattingEnabled = true;
            lbDarsenaConcesionaria.ItemHeight = 21;
            lbDarsenaConcesionaria.Location = new Point(23, 63);
            lbDarsenaConcesionaria.Margin = new Padding(4);
            lbDarsenaConcesionaria.Name = "lbDarsenaConcesionaria";
            lbDarsenaConcesionaria.Size = new Size(194, 256);
            lbDarsenaConcesionaria.TabIndex = 0;
            // 
            // btnCrearCamion
            // 
            btnCrearCamion.Location = new Point(226, 63);
            btnCrearCamion.Margin = new Padding(4);
            btnCrearCamion.Name = "btnCrearCamion";
            btnCrearCamion.Size = new Size(107, 63);
            btnCrearCamion.TabIndex = 1;
            btnCrearCamion.Text = "Crear Camion";
            btnCrearCamion.UseVisualStyleBackColor = true;
            btnCrearCamion.Click += btnCrearCamion_Click;
            // 
            // button2
            // 
            button2.Location = new Point(226, 135);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(107, 59);
            button2.TabIndex = 2;
            button2.Text = "Cargar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnCargarCamion_Click;
            // 
            // button3
            // 
            button3.Location = new Point(226, 202);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(107, 57);
            button3.TabIndex = 3;
            button3.Text = "Descargar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnDescargaCamion_Click;
            // 
            // btnCerrarCamion
            // 
            btnCerrarCamion.Location = new Point(226, 268);
            btnCerrarCamion.Margin = new Padding(4);
            btnCerrarCamion.Name = "btnCerrarCamion";
            btnCerrarCamion.Size = new Size(107, 57);
            btnCerrarCamion.TabIndex = 4;
            btnCerrarCamion.Text = "Cerrar Camión";
            btnCerrarCamion.UseVisualStyleBackColor = true;
            btnCerrarCamion.Click += btnCerrarCamion_Click;
            // 
            // lbItinerarioCamion
            // 
            lbItinerarioCamion.FormattingEnabled = true;
            lbItinerarioCamion.ItemHeight = 21;
            lbItinerarioCamion.Location = new Point(18, 29);
            lbItinerarioCamion.Margin = new Padding(4);
            lbItinerarioCamion.Name = "lbItinerarioCamion";
            lbItinerarioCamion.Size = new Size(194, 298);
            lbItinerarioCamion.TabIndex = 5;
            // 
            // btnRecibirCamion
            // 
            btnRecibirCamion.Location = new Point(221, 42);
            btnRecibirCamion.Margin = new Padding(4);
            btnRecibirCamion.Name = "btnRecibirCamion";
            btnRecibirCamion.Size = new Size(117, 63);
            btnRecibirCamion.TabIndex = 6;
            btnRecibirCamion.Text = "Recibir Camion";
            btnRecibirCamion.UseVisualStyleBackColor = true;
            btnRecibirCamion.Click += btnRecibirCamion_Click;
            // 
            // btnDescargarCamionRecibido
            // 
            btnDescargarCamionRecibido.Location = new Point(221, 116);
            btnDescargarCamionRecibido.Margin = new Padding(4);
            btnDescargarCamionRecibido.Name = "btnDescargarCamionRecibido";
            btnDescargarCamionRecibido.Size = new Size(117, 62);
            btnDescargarCamionRecibido.TabIndex = 7;
            btnDescargarCamionRecibido.Text = "Descargar";
            btnDescargarCamionRecibido.UseVisualStyleBackColor = true;
            btnDescargarCamionRecibido.Click += btnDescargarCamionRecibido_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(38, 26);
            dateTimePicker1.Margin = new Padding(4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(295, 29);
            dateTimePicker1.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(357, 88);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(57, 29);
            textBox1.TabIndex = 9;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(lbDarsenaConcesionaria);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(btnCrearCamion);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(btnCerrarCamion);
            groupBox1.Location = new Point(12, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(441, 336);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cargas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(357, 63);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 10;
            label1.Text = "Capacidad";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbItinerarioCamion);
            groupBox2.Controls.Add(btnRecibirCamion);
            groupBox2.Controls.Add(btnDescargarCamionRecibido);
            groupBox2.Location = new Point(459, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(346, 336);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Descargas";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 340);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbDarsenaConcesionaria;
        private Button btnCrearCamion;
        private Button button2;
        private Button button3;
        private Button btnCerrarCamion;
        private ListBox lbItinerarioCamion;
        private Button btnRecibirCamion;
        private Button btnDescargarCamionRecibido;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
    }
}
