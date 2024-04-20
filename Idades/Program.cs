//2 - faça um programa que receba a idade de 10 pessoas e mostra a quantidade de maiores e menores de idades.

int idade, maiores = 0, menores = 0;

Console.WriteLine("Digite 10 idades e veja a quantidade maiores e menores de idade");

for (int i = 1; i <= 10; i++)
{
    Console.Write($"Digite a {i}ª idade");
    idade = int.Parse( Console.ReadLine() );
    
    if ( idade < 18)
    {
        menores++;
    }
    else
    {
        maiores++;
    }
}

Console.WriteLine("Quantidade de menores de idade: " + menores);
Console.WriteLine("Quantidade de maiores de idade: " + maiores);

Console.WriteLine("Pressione Enter para encerrar...");

Console.ReadLine();
