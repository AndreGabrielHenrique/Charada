/*Crie um programa em que um usuário informe uma palavra segredo, e depois uma descrição do segredo.
Em seguida limpe a tela e mostre ao usuário somente a descriacao do segredo.
O usuário terá 5 tentativas para descobrir a palavra correta, Ignore letras maiúsculas ou minúsculas na resposta.
Caso as tentativas se esgotem informe que o jogo acabou e encerro o looping*/
using System.Diagnostics;

string sep=new string('-',134);
string palavrasecreta,descricao,descobrirpalavrasecreta;
int tentativa=5;
System.Console.WriteLine("Diga a palavra secreta");
palavrasecreta=Console.ReadLine();
System.Console.WriteLine("Descreva a palavra secreta");
descricao=Console.ReadLine();
Console.Clear();
System.Console.WriteLine("Descrição da palavra secreta:");
System.Console.WriteLine(descricao);
System.Console.WriteLine(sep);
while(tentativa>0)
{
System.Console.WriteLine("Descubra a palavra secreta");
descobrirpalavrasecreta=Console.ReadLine();
    if(palavrasecreta==descobrirpalavrasecreta)
    {
        System.Console.WriteLine("Acertou a palavra correta.");
        System.Console.WriteLine(sep);
        break;
    }
    else
    {
        tentativa--;
        if(tentativa>0)
        {
            System.Console.WriteLine($"Errou, tem mais {tentativa} tentativas.");
            System.Console.WriteLine(sep);
        }
        else
        {
            System.Console.WriteLine("Tentativas esgotadas, tente na próxima vez.");
            System.Console.WriteLine(sep);
        }
    }
}