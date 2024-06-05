using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Biblioteca.Arquivo {
    public class GerenciadorArquivo {

        public static void GravarArquivo(string nome, string texto) {

            //Cria o caminho do arquivo atribuindo um nome que vem por parametro no metodo.
            string caminho = "C:\\Users\\CARLOS\\Documents\\" + nome + ".txt";

            //Verifica se o arquivo do caminho ja existe
            if (File.Exists(caminho)) {
                //Se existir o arquivo, passa o caminho para o File.AppendText (abre o arquivo), instancia o StreamWriter (passando o arquivo aberto) e depois adiciona o texto novo no arquivo existente.
                using (StreamWriter wr = File.AppendText(caminho)) {
                    wr.WriteLine(texto);
                }
            }
            else {
                //Se não existe um arquivo com o "nome" passado por parametro, instancia o StreamWriter e passa o caminho como parametro para criar um novo arquivo.
                using (StreamWriter wr = new StreamWriter(caminho)) {
                    wr.WriteLine(texto);
                }
            }
        }

        public static string[] LerArquivo(string nome) {

            //Cria uma string com o mesmo caminho do metodo GravaArquivo, (ou seja pega o mesmo arquivo), retorna o File.ReadAllLines com o caminho por parametro (faz a leitura do arquivo). 
            string caminho = "C:\\Users\\CARLOS\\Documents\\" + nome + ".txt";
            return File.ReadAllLines(caminho);

        }
    }
}
