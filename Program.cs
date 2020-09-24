using System;

namespace NomeCompleto_AT_Etec_
{
    class Program
    {
        static void Main(string[] args)
        {
        string NomeDoUsuario; 

        string SobreNomeDoUsuario;

        string NomeCompleto;

            Console.Write("Por Favor, digite seu nome: ");
            NomeDoUsuario = Console.ReadLine();

            Console.Write("Agora digite seu SobreNome: ");
            SobreNomeDoUsuario = Console.ReadLine();

            NomeCompleto = $"{NomeDoUsuario} {SobreNomeDoUsuario}";

            Console.Write($"Obrigado, {NomeCompleto}!! Precione em alguma tecla para finalizar");




        }
    }
}
