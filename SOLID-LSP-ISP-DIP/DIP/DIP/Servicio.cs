using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    public class Servicio
    {
        private INotificacion notificacion;

        public Servicio(INotificacion notificacion)
        {
            this.notificacion = notificacion;
        }

        public void EnviarMensaje(string mensaje)
        {
            notificacion.Enviar(mensaje);
        }
    }
}
