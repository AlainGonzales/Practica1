using System.Diagnostics;

namespace Practica1
{
    public partial class FormRegistrarContacto : Form
    {
        private ListaEnlazada _listaEstudiantes;
        private ListView _listView;

        internal FormRegistrarContacto(ListaEnlazada lista, ListView listView)
        {
            InitializeComponent();
            _listaEstudiantes = lista;
            _listView = listView;
        }


        private void btn_guardar_Click(object sender, EventArgs e)
        {
            // Validación básica
            if (string.IsNullOrWhiteSpace(txt_nombre.Text))
            {
                MessageBox.Show("El campo Nombre es obligatorio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrWhiteSpace(txt_apellido.Text))
            {
                MessageBox.Show("El campo Apellido es obligatorio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrWhiteSpace(txt_telefono.Text))
            {
                MessageBox.Show("El campo Teléfono es obligatorio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txt_telefono.Text.Length != 9)
            {
                MessageBox.Show("El teléfono debe tener 9 dígitos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrWhiteSpace(txt_correo.Text))
            {
                MessageBox.Show("El campo Correo es obligatorio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            Estudiante estudiante = new Estudiante
            {
                nombre = txt_nombre.Text,
                apellido = txt_apellido.Text,
                telefono = txt_telefono.Text,
                correo = txt_correo.Text
            };


            // Insertar en la lista compartida
            _listaEstudiantes.insertarAlFinal(estudiante);

            // Actualizar el ListView en FormIndex
            _listaEstudiantes.listar(_listView);

            // Cerrar el formulario
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
