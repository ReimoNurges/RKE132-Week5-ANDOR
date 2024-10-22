int math, biology, chem;

Console.WriteLine("Sisesta mata tulemus: ");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Sisesta bioloogia tulemus: ");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Sisestage keemia tulemus: ");
chem = Int32.Parse(Console.ReadLine());

if ((math >= 90 && biology >= 90) || (math >= 90 && chem >= 90) || (biology >= 90 && chem >= 90))
{
    Console.WriteLine("Concrats");
}
else
{
    Console.WriteLine("oops");

}
