
using Aula14AtividadeBanco;



Cliente c1 = new Cliente("Jonatas", "jjmarcelus@gmail.com", "12333", 1500, true, true );
Cliente c2 = new Cliente("marcelus", "marcelus@gmail.com", "123344", 2000, true, false );

ContaBancaria cb1 = new ContaBancaria(1500, true, true);
ContaBancaria cb2 = new ContaBancaria(2850.99,true, false);

c1.mostra();
c1.contaBancaria.mostra();

c2.mostra();
c2.contaBancaria.mostra();

Console.ReadKey();

