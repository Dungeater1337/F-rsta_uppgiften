using System;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Skriv in en bas för rektanglen");
        int bas = int.Parse(Console.ReadLine());
        Console.WriteLine("Bra! Skriv nu in höjden för rektanglen");
        int höjd = int.Parse(Console.ReadLine());

        int area = AREA(bas, höjd);
        Console.WriteLine("Arean blev " + area + " kvadratmeter");


    }

    static int AREA(int bas, int höjd)
    {

        int area = bas * höjd;
        return area;
    }
}
