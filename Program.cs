// See https://aka.ms/new-console-template for more information
//Armas de Legolas
Arma arma1 = new Arma("Daga", 100, 10, 10,"Daga");
Arma arma2 = new Arma("Arco rompe viento", 100, 1, 10,"Arco");
Arma arma3 = new Arma("Espada", 100, 6, 10,"Espada");
List<Arma> armasLegonas=new List<Arma>();
armasLegonas.Add(arma1);
armasLegonas.Add(arma2);
armasLegonas.Add(arma3);

//Armas de Gandalf
Arma arma4= new Arma("Baculo de Gandalf", 100, 10, 10,"Baculo");
Arma arma5= new Arma("Espada", 100, 6, 10,"Espada");
List<Arma> armasGandalf=new List<Arma>();
armasGandalf.Add(arma4);
armasGandalf.Add(arma5);      

Personaje mago = new Mago("Gandalf", 1.80, 80, "Masculino", 100, 100, 100,armasGandalf,120);
mago.cambiarArma("Baculo de Gandalf");


Personaje arquero2= new Arquero("Legolas", 1.80, 80, "Masculino", 100, 100, 100, armasLegonas,5);
Personaje arquero1= new Arquero("Robin Hood", 1.80, 80, "Masculino", 100, 100, 30,armasLegonas,6 );


mago.atacar(arquero2);
mago.cambiarArma("Espada");
mago.atacar(arquero2);


arquero2.atacar(mago);
arquero1.atacar(mago);
mago.atacar(arquero1);
mago.atacar(arquero2);
mago.atacar(arquero1);
mago.atacar(arquero1);
//
arquero1.atacar(mago);
mago.atacar(arquero2);
mago.atacar(arquero2);
mago.atacar(arquero1);
mago.atacar(arquero2);
mago.atacar(arquero2);
mago.atacar(arquero2);

//Console.WriteLine(mago);