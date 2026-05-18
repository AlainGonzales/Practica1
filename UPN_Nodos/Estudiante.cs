namespace Practica1
{
    internal class Estudiante
    {
        private static int _contadorID = 0; // contador global

        private int _id;
        private string _nombre;
        private string _apellido;
        private string _telefono;
        private string _correo;

        public int id { get { return _id; } private set { _id = value; } }
        public string nombre { get { return _nombre; } set { _nombre = value; } }
        public string apellido { get { return _apellido; } set { _apellido = value; } }
        public string telefono { get { return _telefono; } set { _telefono = value; } }
        public string correo { get { return _correo; } set { _correo = value; } }

        public Estudiante()
        {
            _id = ++_contadorID; // Incremento el contador y lo asigno a _id
        }

        public override string ToString()
        {
            return $"ID: {_id}, Nombre: {nombre} {apellido}, Tel: {telefono}, Email: {correo}";
        }
    }

}
