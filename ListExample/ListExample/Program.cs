// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<string> gameStop = new List<string>();

gameStop.Add("Halo infinite");
gameStop.Add("League of legends");
gameStop.Add("Csgo2");
gameStop.Add("Plants vs zombies");

for (int i = 0; i < gameStop.Count; i++)
{
    Console.WriteLine(gameStop[i]);
}

//gameStop.Remove("Plants vs zombies");
gameStop.RemoveAt(3);

for (int i = 0; i < gameStop.Count; i++)
{
    Console.WriteLine(gameStop[i]);
}
