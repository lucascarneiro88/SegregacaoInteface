using System;
using SegregacaoInterface;

public class SmsNotificacao : ISmsNotificacao
{
    public void EnviarSMS(string numeroTelefone)
    {
        Console.WriteLine("Enviando SMS para: " + numeroTelefone);
    }
}