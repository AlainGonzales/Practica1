namespace Practica1
{
    internal class ListaEnlazada
    {
        private Nodo _raiz;


        public ListaEnlazada()
        {
            this._raiz = null;
        }

        public Nodo raiz
        {
            get { return this._raiz; }
            set { this._raiz = value; }
        }

        public bool vacia()
        {
            return this._raiz == null;            
        }

        public void insertarAlInicio(Estudiante dato)
        {
            Nodo nuevo = new Nodo(dato);
            nuevo.siguiente = _raiz;
            _raiz = nuevo;
        }

        public void insertarAlFinal(Estudiante dato)
        {
            Nodo nuevo = new Nodo(dato);

            if (_raiz == null)
            {
                _raiz = nuevo;
            }
            else
            {
                Nodo actual = _raiz;
                while (actual.siguiente != null)
                {
                    actual = actual.siguiente;
                }
                actual.siguiente = nuevo;
            }
        }
        
        // Método para listar estudiantes en un ListView (usa columnas)
        public void listar(ListView listView)
        {
            listView.Items.Clear(); // Limpiar antes de agregar
            Nodo actual = _raiz;
            
            while (actual != null)
            {
                Estudiante est = actual.valor;

                ListViewItem item = new ListViewItem(est.id.ToString());
                item.SubItems.Add(est.nombre);
                item.SubItems.Add(est.apellido);
                item.SubItems.Add(est.telefono);
                item.SubItems.Add(est.correo);

                listView.Items.Add(item);
                actual = actual.siguiente;
            }
        }


        public Nodo buscarPorID(int ID)
        {
            Nodo actual = _raiz;
            while (actual != null)
            {
                if (actual.valor.id == ID)
                    return actual;

                actual = actual.siguiente;
            }
            return null;
        }
        
        public List<Estudiante> buscarPorNombre(string nombre)
        {
            List<Estudiante> encontrados = new List<Estudiante>();

            Nodo actual = _raiz;
            while (actual != null)
            {
                if (actual.valor.nombre.ToLower().Contains(nombre.ToLower()))
                    encontrados.Add(actual.valor);
                
                actual = actual.siguiente;
            }
            return encontrados;
        }
    }
}
