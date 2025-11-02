double massa, altura, imc;
Console.WriteLine("-- Calculadora IMC --/n");
Console.Write("Digite seu peso em kg...:" );
massa = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite sua altura em m..:");
altura = Convert.ToDouble(Console.ReadLine());

imc = massa / Math.Pow(altura, 2);

Console.WriteLine($"Seu IMC é {imc:N2} kg/m²");

