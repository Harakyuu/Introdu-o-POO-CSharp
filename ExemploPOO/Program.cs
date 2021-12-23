using System;
using System.Collections.Generic;
using System.IO;
using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "C:\\workspace\\TrabalhandoComArquivos";

            var caminhoPathCombine = Path.Combine(caminho, "PastaTeste1");

            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");

            var caminhoArquivoTeste = Path.Combine(caminho, "arquivo-teste.txt");

            var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo-teste-backup.txt");

            var novoCaminhoArquivo = Path.Combine(caminho, "PastaTeste2", "arquivo-teste-stream.txt");

            var listaString = new List<string> {"Linha 1", "Linha 2", "Linha 3"};

            var listaStringContinuacao = new List<string> {"Linha 4", "Linha 5", "Linha 6"};
            
            FileHelper helper11 = new FileHelper();
            helper11.DeletarArquivo(caminhoArquivoTesteCopia);
            
            
            FileHelper helper10 = new FileHelper();
            helper10.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);

            
            FileHelper helper9 = new FileHelper();
            helper9.MoverArquivo(caminhoArquivo, novoCaminhoArquivo, false);


            FileHelper helper8 = new FileHelper();
            helper8.LerArquivoStream(caminhoArquivo);


            FileHelper helper7 = new FileHelper();
            helper7.CriarArquivoTextoStream(caminhoArquivo, listaString);
            helper7.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);
            
            FileHelper helper6 = new FileHelper();
            helper6.CriarArquivoTextoStream(caminhoArquivo, listaString);


            FileHelper helper5 = new FileHelper();
            helper5.CriarArquivoTexto(caminhoArquivo, "Olá, teste de escrita de arquivo!");


            FileHelper helper4 = new FileHelper();
            helper4.ApagarDiretorio(caminhoPathCombine, true);

            
            FileHelper helper3 = new FileHelper();
            System.Console.WriteLine("Criando Diretório: " + caminhoPathCombine);
            helper3.CriarDiretorio(caminhoPathCombine);


            FileHelper helper2 = new FileHelper();
            helper2.ListarArquivos(caminho);
            
            
            FileHelper helper1 = new FileHelper();
            helper1.ListarDiretorios(caminho);
            
            
            ICalculadora calc2 = new Calculadora();
            System.Console.WriteLine(calc2.Somar(10, 20));
            
            
            Computador comp = new Computador();
            System.Console.WriteLine(comp.ToString());

            
            Corrente conta = new Corrente();
            conta.Creditar(100);
            conta.ExibirSaldo();            

            Calculadora calc1 = new Calculadora();
            System.Console.WriteLine("Resultado da primeira soma: " + calc1.Somar(10, 10));
            System.Console.WriteLine("Resultado da segunda soma: " + calc1.Somar(10, 10, 10));
            

            Aluno p2 = new Aluno();
            
            p2.Nota = 10;
            p2.Nome = "Bob";
            p2.Idade = 20;

            p2.Apresentar();

            Professor p3 = new Professor();
            
            p3.Salario = 2000;
            p3.Nome = "Joey";
            p3.Idade = 25;

            p2.Apresentar();
            
            
            //Valores Válidos
            Retangulo r1 = new Retangulo();
            r1.DefinirMedidas(30, 30);
            
            Console.WriteLine($"Área: {r1.ObterArea()}");

            //Valores Inválidos
            Retangulo r2 = new Retangulo();
            r2.DefinirMedidas(0, 0);
            
            Console.WriteLine($"Área: {r2.ObterArea()}");
            
            
            Pessoa p1 = new Pessoa();

            p1.Nome = "Bob";
            p1.Idade = 20;

            p1.Apresentar();
        }
    }
}
