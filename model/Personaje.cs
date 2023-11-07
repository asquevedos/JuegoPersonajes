public abstract class Personaje: IClonable<Personaje> 
{
    public string nombre { get; set; }
    public double altura{ get; set; }
    private double peso { get; set; }
    private string genero { get; set; }
    private int edad { get; set; }
    private int eregia { get; set; }
    public  int salud { get; set; }

    public Arma armaActual{get;set;}
    public Armadura armaduraActual{get;set;}

    public Inventario inventario;



    public Personaje()
    {}

    protected Personaje(string nombre, double altura, double peso, string genero, int edad, int eregia, int salud, Arma armaActual, Armadura armaduraActual, Inventario inventario)
    {
        this.nombre = nombre;
        this.altura = altura;
        this.peso = peso;
        this.genero = genero;
        this.edad = edad;
        this.eregia = eregia;
        this.salud = salud;
        this.armaActual = armaActual;
        this.armaduraActual = armaduraActual;
        this.inventario = inventario;
    }

    public abstract void atacar(Personaje personaje);
    public abstract void defender();
    public abstract void mover();

    public virtual void aprender()
    {
        Console.WriteLine("Aprendiendo");
    }
    public virtual void danio(int porcentajeDano)
    {
        this.salud -=porcentajeDano;
        if(this.salud<=0)
        {
            Console.WriteLine(this.nombre+ " está muerto");
        }
    }

    public virtual void cambiarArma(string nombreArma)
    {
        for(int i=0;i<=this.inventario.armas.Count;i++)
        {
            if(this.inventario.armas[i].nombre==nombreArma)
            {
                this.armaActual=this.inventario.armas[i];
                break;
            }
        }
    }

        public virtual void cambiarArmadura(string nombreArmadura)
    {
        for(int i=0;i<=this.inventario.armaduras.Count;i++)
        {
            if(this.inventario.armaduras[i].nombre==nombreArmadura)
            {
                this.armaduraActual=this.inventario.armaduras[i];
                break;
            }
        }
    }

    public void listarArmas()
    {
        int cont =0;
        Console.WriteLine("Por favor Ingrese la arma elegida");
        foreach(Arma arma in this.inventario.armas)
        {
            
            Console.WriteLine("Opción "+cont+" "+arma.nombre);
            cont++;
        }
    }

    
    public Personaje clonar()
    {
        return (Personaje)this.MemberwiseClone();
    }



}
