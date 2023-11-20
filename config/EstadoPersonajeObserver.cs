public class EstadoPersonajeObserver : IObserver
{
    public void update(ISubject subject)
    {
        if (subject is Personaje personaje)
        {
            Console.WriteLine($"El personaje {personaje.nombre} ha cambiado su salud a {personaje.salud} puntos.");
            
            // Realizar acciones adicionales
        }
    }
}