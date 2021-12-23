using System.Collections.Generic;
using System.IO;

namespace ExemploPOO.Helper
{
    public class FileHelper
    {
        public void ListarDiretorios(string caminho)
        {
            var retornaCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);

            foreach (var retorno in retornaCaminho)
            {
                System.Console.WriteLine(retorno);
            }
        }

        public void ListarArquivos(string caminho)
        {
            var retornaArquivos = Directory.GetFiles(caminho, "*", SearchOption.AllDirectories);

            foreach (var retorno in retornaArquivos)
            {
                System.Console.WriteLine(retorno);
            }
        }

        public void CriarDiretorio(string caminho)
        {
            var retorno = Directory.CreateDirectory(caminho);
            System.Console.WriteLine(retorno.FullName);
        }

        public void ApagarDiretorio(string caminho, bool apagarArquivo)
        {
            Directory.Delete(caminho, apagarArquivo);
        }

        public void CriarArquivoTexto(string caminho, string conteudo)
        {
            if (!File.Exists(caminho))
            {
                File.WriteAllText(caminho, conteudo);
            }
        }

        public  void CriarArquivoTextoStream(string caminho, List<string> conteudo)
        {
            using(var stream = File.CreateText(caminho))
            {
                foreach(var linha in conteudo)
                {
                stream.WriteLine(linha);
                }
            }
        }

        public void AdicionarTexto(string caminho, string conteudo)
        {
            File.AppendAllText(caminho, conteudo);
        }

        public  void AdicionarTextoStream(string caminho, List<string> conteudo)
        {
            using(var stream = File.AppendText(caminho))
            {
                foreach(var linha in conteudo)
                {
                stream.WriteLine(linha);
                }
            }
        }

        public void LerArquivo(string caminho)
        {
            var conteudo = File.ReadAllLines(caminho);

            foreach (var linha in conteudo)
            {
                System.Console.WriteLine(linha);
            }
        }

        public void LerArquivoStream(string caminho)
        {
            string linha = string.Empty;

            using(var stream = File.OpenText(caminho))
            {
                while ((linha = stream.ReadLine()) != null)
                {
                     System.Console.WriteLine(linha);
                }
            }
        }

        public void MoverArquivo(string caminho, string novoCaminho, bool sobrescrever)
        {
            File.Move(caminho, novoCaminho, sobrescrever);
        }

        public void CopiarArquivo(string caminho, string novoCaminho, bool sobrescrever)
        {
            File.Copy(caminho, novoCaminho, sobrescrever);
        }

        public void DeletarArquivo(string caminho)
        {
            File.Delete(caminho);
        }
    }
}