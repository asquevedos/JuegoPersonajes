public class ConfiguracionJuego
{
    private static ConfiguracionJuego _instancia;
    public int Volumen { get; set; }
    public Tuple<int, int> Resolucion { get; set; }

    private ConfiguracionJuego()
    {
        Volumen = 50;
        Resolucion = new Tuple<int, int>(1920, 1080);
    }

    public static ConfiguracionJuego Instancia
    {
        get
        {
            if (_instancia == null)
            {
                _instancia = new ConfiguracionJuego();
            }
            return _instancia;
        }
    }
}