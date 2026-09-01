using System;
using DIP;

INotificacion email = new Email();
Servicio servicioEmail = new Servicio(email);

servicioEmail.EnviarMensaje("Hola desde C#");

INotificacion sms = new SMS();
Servicio servicioSMS = new Servicio(sms);

servicioSMS.EnviarMensaje("Hola por SMS");