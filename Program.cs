﻿Adivinhacao charada=new Adivinhacao();
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