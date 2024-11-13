// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

List<string> listaDeNomes = new List<string> {"Wanderson", "Jeane", "Ryan"};
listaDeNomes.Add("Maria");

Console.WriteLine("Nomes na lista:");
for (int i = 0; i < listaDeNomes.Count; i++)
{
     Console.WriteLine(listaDeNomes[i]);
}

Console.WriteLine("\nVerificação de existencia do nome Ryan:")
string nomeParaVerificar = "Ryan";
if(listaDeNomes.Contains(nomeParaVerificar))
{
    Console.WriteLine($"{nomeParaVerificar} está na lista.");
}
else
{
    Console.WriteLine($"{nomeParaVerificar} não está na lista.");
}

Console.WriteLine("\nApós remover Wanderson");
string nomeParaRemover= "Wanderson";
bool foiRemovido = listaDeNomes.Remove(nomeParaRemover);
{
    Console.WriteLine($"{nomeParaRemover} foi removido da lista.")
}
else
{
    Console.WriteLine($"{nomeParaRemover} não foi removido da lista.")
}

Console.WriteLine("\nNomes na lista após a remoção: ");
for (int i = 0; i < listaDeNomes.Count; i++)
{
    Console.WriteLine(listaDeNomes[i]);
}
