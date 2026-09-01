public interface IUsuario
{ 
    void EliminarUsuario();

    string ObtenerNombre();
    string ObtenerCorreo();
    int ObtenerEdad();

    void CambiarNombre(string nuevoNombre);
    void CambiarCorreo(string nuevoCorreo);
    void CambiarEdad(int nuevaEdad);

    void ActivarUsuario();
    void DesactivarUsuario();
    bool Actividad();

    void CambiarContrasena(string nuevaContrasena);
    bool VerificarContrasena(string contrasena);

    void MostrarInformacion();
    string MayorEdad();

    void EnviarMensaje(IUsuario usuario,string mensaje);
}
