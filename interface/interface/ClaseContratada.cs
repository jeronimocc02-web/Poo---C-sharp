namespace interfaces
{
    public class ClaseContradata : IUsuario
    {
        private string Nombre;
        private string Correo;
        private int Edad;
        private string Contrasena;
        private bool Activo;

        public ClaseContradata(string nombre, string correo, int edad, string contrasena)
        {
            Nombre = nombre;
            Correo = correo;
            Edad = edad;
            Contrasena = contrasena;
            Activo = false;
        }
        public ClaseContradata(string nombre, string correo, int edad, string contrasena, bool activo)
        {
            Nombre = nombre;
            Correo = correo;
            Edad = edad;
            Contrasena = contrasena;
            Activo = activo;
        }

        public void EliminarUsuario()
        {
            Nombre = "";
            Correo = "";
            Edad = 0;
            Contrasena = "";
            Activo = false;
        }

        public string ObtenerNombre()
        {
            return Nombre;
        }

        public string ObtenerCorreo()
        {
            return Correo;
        }

        public int ObtenerEdad()
        {
            return Edad;
        }

        public void CambiarNombre(string nuevonombre)
        {
            Nombre = nuevonombre;
            Console.WriteLine("Se actualizo el nombre\n");
        }

        public void CambiarCorreo(string nuevocorreo)
        {
            Correo = nuevocorreo;
            Console.WriteLine("Se actualizo correo\n");
        }

        public void CambiarEdad(int nuevaedad)
        {
            Edad = nuevaedad;
            Console.WriteLine("Se actualizo la edad\n");
        }

        public void ActivarUsuario()
        {
            Activo = true;
        }

        public void DesactivarUsuario()
        {
            Activo = false;
        }

        public bool Actividad()
        {
            return Activo;
        }

        public void CambiarContrasena(string nuevacontrasena)
        {
            Contrasena = nuevacontrasena;
        }

        public bool VerificarContrasena(string contrasena)
        {
            if (Contrasena != contrasena)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("Nombre: " + Nombre + "\nEdad: " + Edad + "\nCorreo: " + Correo + "\nEstado: " + Activo);
        }

        public string MayorEdad()
        {
            if (Edad >= 18)
            {
                return "Es mayor de edad";
            }
            else
            {
                return "Es menor de edad";
            }
        }

        public void EnviarMensaje(IUsuario usuario, string mensaje)
        {
            Console.WriteLine("Mensaje de " + Nombre + " para " + usuario.ObtenerNombre() + ":\n" + mensaje);
        }
    }
}
