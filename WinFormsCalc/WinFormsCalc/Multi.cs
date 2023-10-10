using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsCalc
{
    public class Multi
    {
        public int num_1;
        public int num_2;

        public Multi(int num_1, int num_2)
        {
            this.num_1 = num_1;
            this.num_2 = num_2;
        }

        public int Num_1 { get => num_1; set => num_1 = value; }
        public int Num_2 { get => num_2; set => num_2 = value; }

        public int CalcMult()
        {
            int multi;
            multi = num_1 * num_2;
            return multi;

        }//FIM DA CLASSE
    }
}
