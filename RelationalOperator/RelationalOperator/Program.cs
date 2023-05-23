// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int value1 = 19;
int value2 = 8;
int value3 = -3;

/* == is equal
   != is diff
   > greater
   < less
*/

Console.WriteLine("los valores de value1, value2, value3 son: " + value1 + " " + value2 + " " + value3);

bool result0 = value1 == value2;
bool result1 = value3 == value1;
Console.WriteLine("The result of value1 == value2 is: " + result0 + " and the result of value3 == value1 is: " + result1);

bool result2 = value1 != value2;
bool result3 = value3 != value1;
Console.WriteLine("The result of value1 != value2 is: " + result2 + " and the result of value3 != value1 is: " + result3);


bool result4 = value1 >= value2;
bool result5 = value3 >= value1;
Console.WriteLine("The result of value1 >= value2 is: " + result4 + " and the result of value3 >= value1 is: " + result5);


bool result6 = value1 <= value2;
bool result7 = value3 <= value1;
Console.WriteLine("The result of value1 <= value2 is: " + result6 + " and the result of value3 <= value1 is: " + result7);