﻿//double nota1 = 8;
//double nota2 = 8.0;
//double nota3 = 6.8;
//double mediaNota = (nota1 + nota2 + nota3) / 3;
//if (mediaNota >= 7)
//{
//    Console.WriteLine($"Média {mediaNota:F2}: Aprovado");
//}
//else if(mediaNota >= 5 && mediaNota < 7)
//{
//    Console.WriteLine($"Média {mediaNota:F2}: Recuperação");
//}
//else
//{
//    Console.WriteLine($"Média {mediaNota:F2}: Aprovado");
//}

Console.WriteLine("Digite uma vogal: ");
string? letra = Console.ReadLine();
if (letra == "a" || letra == "A")
{
    Console.WriteLine($"Você digitou a vogal: {letra}");
}
else if (letra == "e" || letra == "E")
{
    Console.WriteLine($"Você digitou a vogal: {letra}");
}
else if (letra == "i" || letra == "I")
{
    Console.WriteLine($"Você digitou a vogal: {letra}");
}
else if (letra == "o" || letra == "O")
{
    Console.WriteLine($"Você digitou a vogal: {letra}");
}
else if (letra == "u" || letra == "U")
{
    Console.WriteLine($"Você digitou a vogal: {letra}");
}
else
{
    Console.WriteLine($"A letra {letra} não é uma vogal.");
}