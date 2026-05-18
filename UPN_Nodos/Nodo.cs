namespace Practica1
{
    internal class Nodo
    {
        private Estudiante _valor;
        private Nodo _siguiente;

        public Estudiante valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

        public Nodo siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }

        public Nodo()
        {
            _valor = null;
            _siguiente = null;
        }

        public Nodo(Estudiante nuevo_estudiante)
        {
            _valor = nuevo_estudiante;
            _siguiente = null;
        }

        public Nodo(Estudiante nuevo_estudiante, Nodo nuevo_siguiente)
        {
            _valor = nuevo_estudiante;
            _siguiente = nuevo_siguiente;
        }
    }
}
