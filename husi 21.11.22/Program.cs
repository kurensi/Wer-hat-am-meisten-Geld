//Eingabe
Console.Write($"Geben sie eine Zahl zwischen 10 und 20 ein: ");
int x=Convert.ToInt32(Console.ReadLine());
while (true) {
    if(x >= 10 && x < 20)
   Console.Write($"{x} ist korrekt");
    Console.ReadKey();
    continue;
    else
    {
        Console.WriteLine($"Die eingabe war falsch");
    }
  
}
