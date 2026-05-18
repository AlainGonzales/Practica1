namespace Practica1
{
    partial class FormRegistrarContacto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrarContacto));
            label5 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            pictureBox4 = new PictureBox();
            panel4 = new Panel();
            pictureBox5 = new PictureBox();
            txt_nombre = new TextBox();
            txt_apellido = new TextBox();
            txt_telefono = new TextBox();
            txt_correo = new TextBox();
            btn_guardar = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(136, 25);
            label5.TabIndex = 9;
            label5.Text = "Crear contacto";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(176, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 100);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(42, 239);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 26);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(42, 273);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 1);
            panel1.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(42, 328);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 1);
            panel2.TabIndex = 17;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(42, 293);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(26, 26);
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(42, 390);
            panel3.Name = "panel3";
            panel3.Size = new Size(350, 1);
            panel3.TabIndex = 20;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(42, 354);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(26, 26);
            pictureBox4.TabIndex = 19;
            pictureBox4.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(42, 451);
            panel4.Name = "panel4";
            panel4.Size = new Size(350, 1);
            panel4.TabIndex = 23;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(42, 415);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(26, 26);
            pictureBox5.TabIndex = 22;
            pictureBox5.TabStop = false;
            // 
            // txt_nombre
            // 
            txt_nombre.BackColor = Color.FromArgb(34, 36, 49);
            txt_nombre.BorderStyle = BorderStyle.None;
            txt_nombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_nombre.ForeColor = SystemColors.Window;
            txt_nombre.Location = new Point(74, 239);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.PlaceholderText = "Nombre";
            txt_nombre.Size = new Size(286, 26);
            txt_nombre.TabIndex = 3;
            // 
            // txt_apellido
            // 
            txt_apellido.BackColor = Color.FromArgb(34, 36, 49);
            txt_apellido.BorderStyle = BorderStyle.None;
            txt_apellido.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_apellido.ForeColor = SystemColors.Window;
            txt_apellido.Location = new Point(74, 293);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.PlaceholderText = "Apellido";
            txt_apellido.Size = new Size(286, 26);
            txt_apellido.TabIndex = 15;
            // 
            // txt_telefono
            // 
            txt_telefono.BackColor = Color.FromArgb(34, 36, 49);
            txt_telefono.BorderStyle = BorderStyle.None;
            txt_telefono.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_telefono.ForeColor = SystemColors.Window;
            txt_telefono.Location = new Point(74, 354);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.PlaceholderText = "Teléfono";
            txt_telefono.Size = new Size(286, 26);
            txt_telefono.TabIndex = 18;
            // 
            // txt_correo
            // 
            txt_correo.BackColor = Color.FromArgb(34, 36, 49);
            txt_correo.BorderStyle = BorderStyle.None;
            txt_correo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_correo.ForeColor = SystemColors.Window;
            txt_correo.Location = new Point(78, 415);
            txt_correo.Name = "txt_correo";
            txt_correo.PlaceholderText = "Correo";
            txt_correo.Size = new Size(286, 26);
            txt_correo.TabIndex = 21;
            // 
            // btn_guardar
            // 
            btn_guardar.FlatStyle = FlatStyle.Flat;
            btn_guardar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_guardar.ForeColor = Color.FromArgb(0, 120, 212);
            btn_guardar.Location = new Point(42, 520);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(350, 47);
            btn_guardar.TabIndex = 24;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(228, 13, 13);
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(406, 9);
            label1.Name = "label1";
            label1.Size = new Size(23, 25);
            label1.TabIndex = 25;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // FormRegistrarContacto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 49);
            ClientSize = new Size(441, 610);
            Controls.Add(label1);
            Controls.Add(btn_guardar);
            Controls.Add(panel4);
            Controls.Add(pictureBox5);
            Controls.Add(txt_correo);
            Controls.Add(panel3);
            Controls.Add(pictureBox4);
            Controls.Add(txt_telefono);
            Controls.Add(panel2);
            Controls.Add(pictureBox3);
            Controls.Add(txt_apellido);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(txt_nombre);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRegistrarContacto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Estudiante";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_nombre;
        private Label label5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox3;
        private TextBox txt_apellido;
        private Panel panel3;
        private PictureBox pictureBox4;
        private TextBox txt_telefono;
        private Panel panel4;
        private PictureBox pictureBox5;
        private TextBox txt_correo;
        private Button btn_guardar;
        private Label label1;
    }
}