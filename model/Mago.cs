public class Mago : Personaje
{
    public int mana { get; set; }

    public Mago(string nombre, double altura, double peso, string genero, int edad, int energia, int salud, Arma armaActual,Armadura armaduraActual,Inventario inventario,int mana) : base(nombre, altura, peso, genero, edad, energia, salud,armaActual,armaduraActual,inventario)
    {
        this.mana = mana;
    }
    public Mago() : base()
    { }

    public override void atacar(Personaje p)
    {
        if (this.salud > 0)
        {
            if (this.mana >= 10)
            {
                Console.WriteLine(this.nombre + " Ataca a " + p.nombre);
                this.mana -= 10;
                this.armaActual.usar(p);
            
            }
            else
            {
                Console.WriteLine("no hay mana");
            }
        }
        else
        {
            Console.WriteLine("Estas muerto");
        }
    }
    public override void defender()
    {
        Console.WriteLine("generar escudo magico");
    }

    public override void mover()
    {
        Console.WriteLine("Moviendo con magia");
    }

    public override void aprender()
    {
        base.aprender();
    }




}