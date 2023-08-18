
using System;
public class EmailNotificacao : IEmailNotificacao
{
    public void EnviarEmail(string caminhoArquivo)
    {
        Console.WriteLine("Enviando e-mail com anexo: " + caminhoArquivo);
    }
}