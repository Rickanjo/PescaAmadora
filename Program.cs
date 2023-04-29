// See https://aka.ms/new-console-template for more information
Console.WriteLine("--- Pesca Amadora ---");

Console.Write("Informe o peso (kg): ");
double peso = double.Parse(Console.ReadLine()!);

Console.Write("Águas [c]ontinentais ou [m]arinhas: ");
char local = char.Parse(Console.ReadLine()!.ToUpper());

double limite = local == 'C' ? 10.0 :15.0;
double excesso = peso - limite;

const double multaBase = 1000.00;
const double multaKgExcedido = 20.00;

string lical = Convert.ToString(local);

ConsoleColor corExede = ConsoleColor.Red;
if (lical !="C" && lical !="m") {
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("\nlocal não identificado");
Console.ResetColor();
}
if (excesso <= 0) {
    Console.WriteLine("Pescaria dentro dos limites legais. ");
} else {
    double multa = multaBase + excesso * multaKgExcedido;
    Console.Write($"\nPescaria ");
    Console.ForegroundColor = corExede;
    Console.Write("excede");
    Console.ResetColor();
    Console.WriteLine(" os limites legais em {excesso:F1} kg ");
    Console.WriteLine($"Sujeito a multa de R$ {multa:F2}.");
}