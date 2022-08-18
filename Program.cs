// See https://aka.ms/new-console-template for more information

float[] Oceny = {1.0f, 2.5f, 15.5f, 10.0f};
float Min=100.0f,Max=0.0f,Sum=0.00f,Avg=0.0f;
foreach(float item in Oceny)
{
    System.Console.WriteLine(item);
    if(item<Min){Min=item;}
    if(item>Max){Max=item;}
    Sum+=item;
}
Avg=Sum/Oceny.Count();
System.Console.WriteLine($"Najlepsza ocena to: {Max}");
System.Console.WriteLine($"Najgorsza ocena to: {Min}");
System.Console.WriteLine($"Suma ocen wynosi: {Sum}");
System.Console.WriteLine($"Srednia z {Oceny.Count()} ocen wynosi {Avg}");