using System;

public class MyMethods
{

    /*
     public void plus(int a, int b) //Metodo personalizado que no devuelve valores
    {
        int result = a + b;
        Console.WriteLine("El resultado es: " + result);
    }
    
    public int plus(int a, int b) //metodo personalizado que devuelve un valor tipo int
    {
        int result = a + b;
        return result;
    }
    */
    public float plus(float a, float b) //metodo personalizado que devuelve un valor tipo float
    {
        float result = a / b;
        return result;
    }
    public static void Main()
    {
        MyMethods suma = new MyMethods();

        int var1 = Convert.ToInt32(Console.ReadLine());
        int var2 = Convert.ToInt32(Console.ReadLine());


        //suma.plus(var1, var2);
        float result = suma.plus(var1, var2);
        Console.WriteLine("El resultado es: " + result);
    }
}