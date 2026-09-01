using interfaces;

ClaseContradata persona1 = new ClaseContradata("Juan","juan@gmail.com",20,"1234");
ClaseContradata persona2 = new ClaseContradata("Pepe","pepe@gmail.com",17,"AFE8D(93TA4FDS4)(/(");

Console.WriteLine("Nombre: " + persona1.ObtenerNombre());
Console.WriteLine("Correo: " + persona1.ObtenerCorreo());
Console.WriteLine("Edad: " + persona1.ObtenerEdad());

persona1.CambiarNombre("Juancho");
persona1.CambiarCorreo("juancho@gmail.com");
persona1.CambiarEdad(21);
persona1.ActivarUsuario();

Console.WriteLine("¿Está activo?: " + persona1.Actividad());
Console.WriteLine(persona1.MayorEdad());

persona1.MostrarInformacion();
persona1.CambiarContrasena("abcd");

Console.WriteLine("¿Contraseña correcta?: " + persona1.VerificarContrasena("abcd"));
Console.WriteLine("¿Contraseña incorrecta?: " + persona1.VerificarContrasena("1234"));

persona1.DesactivarUsuario();

Console.WriteLine("¿Está activo después de desactivar?: " + persona1.Actividad());

persona1.EliminarUsuario();
persona1.MostrarInformacion();

Console.WriteLine("\nMENSAJES\n");

persona1.EnviarMensaje(persona2, "Oe mano, que lo que, ¿vos pones las lucas?");
Console.WriteLine("\n");
persona2.EnviarMensaje(persona1, "Las pelotas, pagalelo usted, ¿vos, que crees que yo soy rico o que?");

