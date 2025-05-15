double altura, pesoIdeal;
string genero;

Console.Clear();
Console.Write("Digite sua altura em m..........: ");
altura = Convert.ToDouble(Console.ReadLine());

Console.Write("Sexo [M]asculino / [F]eminino...:");
genero = Console.ReadLine().ToUpper();

if (genero != "M" && genero != "F")
{
    Console.WriteLine("Digite [M] ou [F]");
    return;
}

pesoIdeal = 0;

if (genero == "M")
{
    pesoIdeal = altura * 72.7 - 58.0;
}
else if (genero == "F")
{
    pesoIdeal = altura * 62.1 - 44.7;
}

Console.WriteLine($"Seu peso ideal é: {pesoIdeal:F2} kg");
