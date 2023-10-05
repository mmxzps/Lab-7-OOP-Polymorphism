namespace Lab_7_OOP_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometri cirkel1 = new Cirkel();
            Console.WriteLine($"Arean Cirkel: {cirkel1.Area():F2}");
            Console.WriteLine();

            Geometri parallellg = new Parallellogram();
            Console.WriteLine($"Arean Parallellogram: {parallellg.Area():F2}");
            Console.WriteLine();

            Geometri fyrkant = new Fyrkant();
            Console.WriteLine($"Arean Fyrkant: {fyrkant.Area():F2}");
            Console.WriteLine();

            Geometri rektangel = new Rektangel();
            Console.WriteLine($"Arean Rektangel: {rektangel.Area():F2}");
            Console.WriteLine();

            Geometri ellips = new Ellips();
            Console.WriteLine($"Arean Ellips {ellips.Area():F2}");
        }
    }
}