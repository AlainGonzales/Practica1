namespace Practica1
{
    public partial class FormIndex : Form
    {
        ListaEnlazada listaEstudiantes = new ListaEnlazada();

        public FormIndex()
        {
            InitializeComponent();
        }
        private void btn_registrar_Click(object sender, EventArgs e)
        {
            FormRegistrarContacto registrarContacto = new FormRegistrarContacto(listaEstudiantes, listViewEstudiantes);
            registrarContacto.ShowDialog();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string nombre = txt_buscar.Text.Trim();
            if (string.IsNullOrWhiteSpace(nombre))
            {
                //MessageBox.Show("El campo de b�squeda no puede estar vac�o.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                listaEstudiantes.listar(listViewEstudiantes);
                return;
            }

            List<Estudiante> resultados = listaEstudiantes.buscarPorNombre(nombre);

            if (resultados.Count == 0)
            {
                MessageBox.Show("No se encontraron estudiantes con ese nombre.", "Sin coincidencias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            listViewEstudiantes.Items.Clear();
            
            foreach (Estudiante est in resultados)
            {
                ListViewItem item = new ListViewItem(est.id.ToString());
                item.SubItems.Add(est.nombre);
                item.SubItems.Add(est.apellido);
                item.SubItems.Add(est.telefono);
                item.SubItems.Add(est.correo);

                listViewEstudiantes.Items.Add(item);
            }

        }
    }
}



