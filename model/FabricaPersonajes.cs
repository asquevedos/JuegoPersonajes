public class FabricaPersonaje : Fabrica
{
    public Personaje crearPersonaje(String tipo)
    {
        Personaje p = null;
        if(tipo=="Mago")
        {
            Inventario inventarioMago= new Inventario();
            Arma arma4= new Arma("Baculo de Gandalf", 100, 10, 10,"Baculo");
            Arma arma5= new Arma("Espada", 100, 6, 10,"Espada");
            List<Arma> armasMago=new List<Arma>();
            armasMago.Add(arma4);
            armasMago.Add(arma5);
            p = new Mago("Gandalf", 1.80, 80, "Masculino", 100, 100, 100,null,null,inventarioMago,120);

        }

        return p;
    }
}