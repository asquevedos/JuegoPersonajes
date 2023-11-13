public class AggressiveStrategy : IEstrategiaCombate
{
    public void execute(Personaje personaje, Personaje enemigo)
    {
         
        personaje.atacar(enemigo);
    }
}