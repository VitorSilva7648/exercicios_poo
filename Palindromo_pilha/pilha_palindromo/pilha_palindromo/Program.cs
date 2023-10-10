using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pilha_palindromo;

static void Main(string[] args)
{
    Pilha pilha = new Pilha();


    TextReader leitor = System.Console.In;
    TextWriter escritor = System.Console.Out;
    float aux = 1;
    while (aux != 0)
    {
        Console.WriteLine("Escolha uma opção do menu :\n");
        Console.WriteLine(" [1] - Inserir elemento na pilha");
        Console.WriteLine(" [2] - Remover elemento da pilha");
        Console.WriteLine(" [3] - Imprimir todos elementos da pilha");
        Console.WriteLine(" [4] - Sair");

        string op = leitor.ReadLine();

        switch (op)
        {
            case "1":
                Console.Write("Digite o elemento a ser inserido:\n");
                String elemento = leitor.ReadLine();
                string palavra = elemento;
                pilha.push(palavra);
                Console.Clear();
                break;

            case "2":
                Console.Write("Um elemento  foi removido");
                Console.WriteLine("Removeu o " + pilha.pop());
                Console.Clear();
                break;

            case "3":
                Console.Write("A pilha encontra-se na seguinte disposição :\n");
                pilha.print();
                Console.ReadLine();
                Console.Clear();
                break;

            case "4":
                aux = 0;
                Console.Clear();
                break;
            default:
                Console.Write("Favor selecionar uma das opções mostradas no menu\n");
                break;
        }


    }


} // fim do static void Main
   