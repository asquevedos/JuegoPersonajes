public class DefensiveStrategy : IEstrategiaCombate
{
    public void execute(Personaje personaje, Personaje enemigo)
    {
         personaje.defender();
    }
}