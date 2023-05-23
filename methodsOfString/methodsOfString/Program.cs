// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


string var1 = "Mi primer metodo de string";
string var2 = "My first method with string";

Console.WriteLine(var1 + " means " + var2);

//Now lets clone the var1 with the method clone
string var1clone = var1.Clone().ToString(); //How you can see, we need use "ToString" This is because ".Clone" is a exactly copy of var1 but in type objet

Console.WriteLine("var1 is " + var1 + "and var1 clone is: " + var1clone);

//Time for compare they with de method "Compareto()
Console.WriteLine(var2.CompareTo(var1));
Console.WriteLine(var1clone.CompareTo(var1));
Console.WriteLine("El metodo 'CompareTo()' devuelve un valor binario, 0 = true and 1 = false");

Console.WriteLine("the method '.Contains()' devuelve true si contiene los caracteres que espeficiquemos");
Console.WriteLine(var2.Contains("method"));

Console.WriteLine("El metodo 'EndsWith' es igual que el contains pero solo se fija en los ultimos caracteres");
Console.WriteLine(var1.EndsWith("ing"));

Console.WriteLine("StarWith: ");
Console.WriteLine(var1clone.StartsWith("M"));

Console.WriteLine(var2.Equals(var1)); //Similar al compareTo pero devuelve un valor booleano