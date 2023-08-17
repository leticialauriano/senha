using System;

/*
    Faça um programa que receba uma senha e teste se ela é igual à 904087. Se a senha estiver correta escreva “Senha Correta e Acesso permitido”, do contrário, escreva a mensagem “Você não tem acesso ao sistema."
 */

namespace Senha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string SENHACORRETA = "904087";

            Console.WriteLine("--Programa Senha--\n");

            Console.Write("Informe sua senha:");
            string senha = Console.ReadLine();

            if (senha == SENHACORRETA)
            {
                Console.WriteLine("Senha Correta.");
                Console.WriteLine("Acesso permitido.");
            }
            else
                Console.WriteLine("Você não tem acesso ao sistema.");                
            
            Console.WriteLine("\n--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}
