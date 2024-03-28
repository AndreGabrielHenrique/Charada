class Adivinhacao
{
    public string sep=new string('-',134);
    public string palavrasecreta;
    public string descricao;
    public string descobrirpalavrasecreta;
    public int tentativa=5;
    public void AdivinharPalavraSecreta()
    {
        System.Console.WriteLine("Diga a palavra secreta");
        palavrasecreta=Console.ReadLine();
        System.Console.WriteLine("Descreva a palavra secreta");
        descricao=Console.ReadLine();
        Console.Clear();
        System.Console.WriteLine("Descrição da palavra secreta:");
        System.Console.WriteLine(descricao);
        System.Console.WriteLine(sep);
    }
}