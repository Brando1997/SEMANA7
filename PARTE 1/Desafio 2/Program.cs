using System;

public interface INotificable
{
    void Notifica(string mensaje);
}

public class NotificacionEmail : INotificable
{
    public string DireccionCorreo { get; set; }

    public void Notifica(string mensaje)
    {
        Console.WriteLine($"Enviando correo electrónico a {DireccionCorreo}: {mensaje}");
    }
}

public class NotificacionWhatsapp : INotificable
{
    public string NumeroTelefono { get; set; }

    public void Notifica(string mensaje)
    {
        Console.WriteLine($"Enviando mensaje por WhatsApp al número {NumeroTelefono}: {mensaje}");
    }
}

public class NotificacionSMS : INotificable
{
    public string NumeroTelefono { get; set; }

    public void Notifica(string mensaje)
    {
        Console.WriteLine($"Enviando SMS al número {NumeroTelefono}: {mensaje}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        NotificacionEmail notificacionEmail = new NotificacionEmail();
        notificacionEmail.DireccionCorreo = "ingenieria@tarea.com";

        NotificacionWhatsapp notificacionWhatsapp = new NotificacionWhatsapp();
        notificacionWhatsapp.NumeroTelefono = "12345678";

        NotificacionSMS notificacionSMS = new NotificacionSMS();
        notificacionSMS.NumeroTelefono = "12345678";

        notificacionEmail.Notifica("Este es un mensaje de prueba por correo electrónico.");
        notificacionWhatsapp.Notifica("Este es un mensaje de prueba por WhatsApp.");
        notificacionSMS.Notifica("Este es un mensaje de prueba por SMS.");
    }
}