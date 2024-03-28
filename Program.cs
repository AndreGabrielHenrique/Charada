﻿/*Crie um programa em que um usuário informe uma palavra segredo, e depois uma descrição do segredo.
Em seguida limpe a tela e mostre ao usuário somente a descriacao do segredo.
O usuário terá 5 tentativas para descobrir a palavra correta, Ignore letras maiúsculas ou minúsculas na resposta.
Caso as tentativas se esgotem informe que o jogo acabou e encerro o looping*/
Adivinhacao charada=new Adivinhacao();
charada.AdivinharPalavraSecreta();
while(charada.tentativa>0)
{
    System.Console.WriteLine("Descubra a palavra secreta");
    charada.descobrirpalavrasecreta=Console.ReadLine();
    if(charada.palavrasecreta.ToLower()==charada.descobrirpalavrasecreta.ToLower())
    {
        System.Console.WriteLine("Acertou a palavra correta.");
        System.Console.WriteLine(charada.sep);
        break;
    }
    else
    {
        charada.tentativa--;
        if(charada.tentativa>0)
        {
            System.Console.WriteLine($"Errou, tem mais {charada.tentativa} tentativas.");
            System.Console.WriteLine(charada.sep);
        }
        else
        {
            System.Console.WriteLine("Tentativas esgotadas, tente na próxima vez.");
            System.Console.WriteLine(charada.sep);
        }
    }
}