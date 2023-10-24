public class Inventario
{

    public List<Arma> armas = new List<Arma>();
    public List<Armadura> armaduras=new List<Armadura>();
    public List<Pocion> pociones=new List<Pocion>();

    public Inventario(List<Arma> armas, List<Armadura> armaduras, List<Pocion> pociones)
    {
        this.armas = armas;
        this.armaduras = armaduras;
        this.pociones = pociones;
    }
    public Inventario()
    {}

}
