
using EJEMPLO_CLASE_2.CLASE.CLASE_HIJO;

Nintendo sw = new Nintendo();

sw.EsPortatil = true;
sw.AnioLanzamiento = 2017;
sw.Marca = "Nintendo Switch";

string resultado = sw.MostrarDetallesNintendo();
Console.WriteLine(resultado);

PlayStation ps = new PlayStation();
ps.EsPortatil = false;
ps.AnioLanzamiento = 2020;
ps.Marca = "Playstation 5";

string resultado2 = ps.MostrarDetallesPS();
Console.WriteLine(resultado2);

XBOX xb = new XBOX();
xb.AnioLanzamiento = 2020;
xb.Marca = "XBOX SERIES S";

string resultado3 = xb.MostrarDetallesXB();
Console.WriteLine(resultado3);