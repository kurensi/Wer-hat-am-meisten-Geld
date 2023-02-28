// See https://aka.ms/new-console-template for more information
Console.Write("Person 1 Geld: ");
Int32 x = Convert.ToInt32(Console.ReadLine());
Console.Write("Person 2 Geld: ");
Int32 y = Convert.ToInt32(Console.ReadLine());
Console.Write("Person 3 Geld");
Int32 z = Convert.ToInt32(Console.ReadLine());
try
{
    if (x >= y && y >= z)
        Console.WriteLine($"Die Person 1 hat am meisten Geld: {x}");
    else if (y >= z && z >= y)
        Console.WriteLine($"Die Person 2 hat am meisten geld : {y}");
    else if (z >= x && x >= y)
        Console.WriteLine($"Die Person 3 hat am meisten geld : {z}");

}

catch (Exception e)
{ 
    Console.WriteLine(e.Message); 
}
Console.ReadKey();