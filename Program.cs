using static System.Console;

double n1, n2, n3, n4, media;
string nome;
WriteLine("nota 0-100");
WriteLine("Digite o seu nome :");
nome = ReadLine();

WriteLine("Digite a primeira nota:");
n1 = Convert.ToDouble(ReadLine());
WriteLine("Digite a segunda nota:");
n2 = Convert.ToDouble(ReadLine());
WriteLine("Digite a terceira nota:");
n3 = Convert.ToDouble(ReadLine());
WriteLine("Digite a quarta nota");
n4 = Convert.ToDouble(ReadLine());

media = (n1 + n2 + n3 + n4)/4;
if(media >= 60)
{
    WriteLine($"Parabéns {nome}, você foi aprovado!");
     WriteLine($"Sua media foi {media}.");
}
else
{
    WriteLine("Sua nota esta abaixo de média!");
    WriteLine($"Sua nota foi {media}.");
}


