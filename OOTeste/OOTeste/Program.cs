using OOTeste;

class Program
{
    static void Main(string[] args)
    {
        Mensagem msg1 = new Mensagem();

        msg1.TextoMensagem = "Hello, World!";
        msg1.ExibirMensagem();

        Mensagem msg2 = new Mensagem();
        msg2.TextoMensagem = "Segundo Objeto";
        msg2.ExibirMensagem();

        Mensagem msg3 = new Mensagem();
        msg3.TextoMensagem = "Terceiro Objeto";
        msg3.ExibirMensagem();
       
    }
}