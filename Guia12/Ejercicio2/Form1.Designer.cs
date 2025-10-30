namespace Ejercicio2
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
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            btnCerrarCamion = new Button();
            listBox2 = new ListBox();
            button5 = new Button();
            button6 = new Button();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(13, 36);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(152, 184);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(171, 36);
            button1.Name = "button1";
            button1.Size = new Size(83, 45);
            button1.TabIndex = 1;
            button1.Text = "Cargar Camion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnCrearCamion_Click;
            // 
            // button2
            // 
            button2.Location = new Point(171, 87);
            button2.Name = "button2";
            button2.Size = new Size(83, 42);
            button2.TabIndex = 2;
            button2.Text = "Cargar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnCargarCamion_Click;
            // 
            // button3
            // 
            button3.Location = new Point(171, 135);
            button3.Name = "button3";
            button3.Size = new Size(83, 41);
            button3.TabIndex = 3;
            button3.Text = "Descargar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnCerrarCamion
            // 
            btnCerrarCamion.Location = new Point(171, 182);
            btnCerrarCamion.Name = "btnCerrarCamion";
            btnCerrarCamion.Size = new Size(83, 41);
            btnCerrarCamion.TabIndex = 4;
            btnCerrarCamion.Text = "Cerrar Camión";
            btnCerrarCamion.UseVisualStyleBackColor = true;
            btnCerrarCamion.Click += btnCerrarCamion_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(347, 36);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(152, 154);
            listBox2.TabIndex = 5;
            // 
            // button5
            // 
            button5.Location = new Point(505, 45);
            button5.Name = "button5";
            button5.Size = new Size(91, 45);
            button5.TabIndex = 6;
            button5.Text = "Recibir Camion";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(505, 98);
            button6.Name = "button6";
            button6.Size = new Size(91, 44);
            button6.TabIndex = 7;
            button6.Text = "Descargar";
            button6.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(75, -3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(272, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(45, 23);
            textBox1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 235);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(listBox2);
            Controls.Add(btnCerrarCamion);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnCerrarCamion;
        private ListBox listBox2;
        private Button button5;
        private Button button6;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private SaveFileDialog saveFileDialog1;
    }
}
