using SegregacaoInterface;
using System;

namespace SegrecacaoInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEmailNotificacao emailNotificacao = new EmailNotificacao();
            ISmsNotificacao smsNotificacao = new SmsNotificacao();

            emailNotificacao.EnviarEmail("caminho/do/arquivo.txt");
            smsNotificacao.EnviarSMS("1234567890");
        }
    }
}
