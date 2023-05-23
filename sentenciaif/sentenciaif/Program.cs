//declaramos los valores que vamos a usar en el codigo
using System.Threading.Tasks.Dataflow;

bool huevo = false;
bool cilandro = false;

//iniciamos la historia del juego imprimiendo un par de mensajes
Console.WriteLine("Madre: Hijo ve a comprar huevo y cilandro por favor");
Console.WriteLine("Yo: bueno má, ahí voy...");
Console.WriteLine("\n *Llegas al almacen de tu barrio y te atiende un señor muy amablemente* \n Señor: Buenos días joven ¿que desea comprar hoy?");
Console.WriteLine("Yo: Hola señor, quiero comprar... \n opción 1: huevo y olvidarse del cilandro \n opción 2: cilandro y olvidarse del huevo \n opción 3: huevo y cilandro \n opción 4: un alfajor fulvito");
Console.WriteLine("Elije una opción: ");
int options = Convert.ToInt32(Console.ReadLine());

if (options == 1)
{
    huevo = true;
} else if (options == 2)
{
    cilandro = true;
} else if(options == 3)
{
    huevo = true;
    cilandro = true;
}

Console.WriteLine("*Luego de comprar vas a tu casa contento con el cumplimiento de tu tarea* \n *Al llegar te recibe tu madré y te pregunta si compraste lo que te pidio");
if (huevo == true && cilandro == true)
{
    Console.WriteLine("Good ending, trajiste todo y comieron felices toda la familia reunida");
} else if (huevo == true && cilandro != true)
{
    Console.WriteLine("Yo: Traje huevo má pero no había cilandro"); //te lo olvidaste pero te inventaste una buena excusa
    Console.WriteLine("Neutral ending: Comieron juntos pero no estaba tan rico");
} else if (huevo != true && cilandro == true) {
    Console.WriteLine("Yo: Si má pero no había huevo");
    Console.WriteLine("Madre: Te dije cilandro, esto es perejil igual que vos boludo");
    Console.WriteLine("bad ending: Te olvidaste de los huevos y trajiste el condimento incorrecto, conociste la chancla");

} else
{
    Console.WriteLine("Yo: No má no había nada y me compre un alfajorcito");
    Console.WriteLine("*Bad ending: Conociste la chancla");
}