using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsPilha
{
    class NohPilha
    {
        // atributos
        private char data; // pilha de inteiros 
        private NohPilha nextNoh; // autoreferencia

        // metodos 
        public NohPilha() // construtor default
        {
            data = '0';
            nextNoh = null;
        }

        public NohPilha(char valor)
        {
            data = valor;
            nextNoh = null;
        }

        public NohPilha(char valor, NohPilha noh)
        {
            data = valor;
            nextNoh = noh;
        }

        public int getData()
        {
            return data;
        }

        public void setData(char valor)
        {
            data = valor;
        }

        public NohPilha getNext()
        {
            return nextNoh;
        }

        public void setNext(NohPilha newNoh)
        {
            nextNoh = newNoh;
        }

    } // fim da classe NohPilha
}

