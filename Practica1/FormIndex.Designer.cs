namespace Practica1
{
    partial class FormIndex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIndex));
            txt_buscar = new TextBox();
            btn_buscar = new Button();
            listViewEstudiantes = new ListView();
            columnId = new ColumnHeader();
            columnName = new ColumnHeader();
            columnApellido = new ColumnHeader();
            columnTelefono = new ColumnHeader();
            columnCorreo = new ColumnHeader();
            btn_registrar = new Button();
            SuspendLayout();
            // 
            // txt_buscar
            // 
            txt_buscar.Location = new Point(12, 12);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(405, 23);
            txt_buscar.TabIndex = 0;
            // 
            // btn_buscar
            // 
            btn_buscar.Location = new Point(515, 12);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(97, 23);
            btn_buscar.TabIndex = 1;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // listViewEstudiantes
            // 
            listViewEstudiantes.BorderStyle = BorderStyle.None;
            listViewEstudiantes.Columns.AddRange(new ColumnHeader[] { columnId, columnName, columnApellido, columnTelefono, columnCorreo });
            listViewEstudiantes.FullRowSelect = true;
            listViewEstudiantes.GridLines = true;
            listViewEstudiantes.Location = new Point(12, 41);
            listViewEstudiantes.Name = "listViewEstudiantes";
            listViewEstudiantes.Size = new Size(600, 745);
            listViewEstudiantes.TabIndex = 2;
            listViewEstudiantes.UseCompatibleStateImageBehavior = false;
            listViewEstudiantes.View = View.Details;
            // 
            // columnId
            // 
            columnId.Text = "Id";
            columnId.Width = 40;
            // 
            // columnName
            // 
            columnName.Text = "Nombre";
            columnName.Width = 130;
            // 
            // columnApellido
            // 
            columnApellido.Text = "Apellido";
            columnApellido.Width = 150;
            // 
            // columnTelefono
            // 
            columnTelefono.Text = "Teléfono";
            columnTelefono.TextAlign = HorizontalAlignment.Right;
            columnTelefono.Width = 80;
            // 
            // columnCorreo
            // 
            columnCorreo.Text = "Correo";
            columnCorreo.Width = 200;
            // 
            // btn_registrar
            // 
            btn_registrar.Image = (Image)resources.GetObject("btn_registrar.Image");
            btn_registrar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_registrar.Location = new Point(315, 813);
            btn_registrar.Name = "btn_registrar";
            btn_registrar.Size = new Size(75, 23);
            btn_registrar.TabIndex = 3;
            btn_registrar.Text = "Agregar";
            btn_registrar.TextAlign = ContentAlignment.MiddleRight;
            btn_registrar.UseVisualStyleBackColor = true;
            btn_registrar.Click += btn_registrar_Click;
            // 
            // FormIndex
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 910);
            Controls.Add(btn_registrar);
            Controls.Add(listViewEstudiantes);
            Controls.Add(btn_buscar);
            Controls.Add(txt_buscar);
            Name = "FormIndex";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Directorio de Estudiantes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_buscar;
        private Button btn_buscar;
        private ListView listViewEstudiantes;
        private Button btn_registrar;
        private ColumnHeader columnName;
        private ColumnHeader columnApellido;
        private ColumnHeader columnTelefono;
        private ColumnHeader columnCorreo;
        private ColumnHeader columnId;
    }
}
