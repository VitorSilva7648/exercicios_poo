﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilha_palindromo
{
    class Pilha
    {
        // atributos 
        private NohPilha topo;

        // metodos
        public Pilha()
        {
            topo = null; // não foi inserido elemento
        }

        public bool isEmpty()
        {
            if (topo == null)
                return true;
            else
                return false;
        }

        public void push(char insertItem)
        {
            if (isEmpty()) // true
                topo = new NohPilha(insertItem);
            else
            {

                NohPilha novoNoh = new NohPilha(insertItem);
                novoNoh.setNext(topo); // faz  o encadeamento

                topo = novoNoh; // o topo agora aponta para mim -- this
            }
        } // fim do método push



        public char pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Pilha Vazia");
                return '0';
            }
            else
            {
                int temp = topo.getData();
                topo = topo.getNext();
                return (char)temp;
            }

        }

        public void print()
        {
            if (isEmpty())
                Console.WriteLine("Pilha Vazia");
            else
            {
                Console.WriteLine("Status atual da Pilha:");
                NohPilha temp = topo;

                while (temp != null)
                {
                    Console.WriteLine("\n" + temp.getData());
                    temp = temp.getNext();
                } // fim do while
            } // fim do else 
        } // fim do método print

        internal void push(string? palavra)
        {
            throw new NotImplementedException();
        }
    } // fim da classe Pilha
}

