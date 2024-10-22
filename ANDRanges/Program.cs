// temp <= 0 - freezing cold
// temp > 0 and <= 10 - cold
// temp > 10 and <= 15 - chilly
// temp > 15 and <= 20 - warm

Console.WriteLine("Temp");
int temp = Int32.Parse(Console.ReadLine());


if  (temp >= 30)
{
    Console.WriteLine("boiling hot");
}
else if (temp >= 20 &&  temp < 30)
{
    Console.WriteLine("hot");

}
else if (temp >= 15 && temp < 20)
{
    Console.WriteLine("warm");

}
else if (temp >= 10 && temp < 15)
{
    Console.WriteLine("Chilly");

}
else if (temp > 0 && temp < 10)
{
    Console.WriteLine("cold");

}
else 
{
    Console.WriteLine("Freezing cold");

}