using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    class Dice
    {
        private int Lados { get; set; }

        public Dice() { }

        public Dice(int lados)
        {
            Lados = lados;
        }

        //Atributos


        //Métodos
        public int Rolar()
        {
            //Retorna o valor da rolagem do dado.
            return new Random().Next(1, Lados+1);
        }
    }
}
