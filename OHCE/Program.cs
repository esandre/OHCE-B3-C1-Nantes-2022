using OHCE;

var ohce = new Ohce(new HorlogeSystème());

Console.WriteLine(ohce.DemanderSalutations());
Console.WriteLine(ohce.Traiter(Console.ReadLine() ?? ""));