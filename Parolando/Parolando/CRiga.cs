using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parolando
{
    internal class CRiga
    {
        public int point;
        public string[] row;
        public int[] moltiplicator;
        

        
        public CRiga()
        {
            Random r = new Random();
            Random r2 = new Random();
            point = 0;
            moltiplicator = new int[8];
            for(int i = 0; i < 8; i++)
            {
                moltiplicator[i] = 0;
            }
            moltiplicator[r.Next(0, 8)] = r2.Next(2, 5);
            row = new string[8];
            for(int i = 0;i < 8;i++)
            {
                if (moltiplicator[i] == 0)
                {
                    row[i] = "-";
                }
                else
                {
                    row[i] = moltiplicator[i].ToString();
                }
                
            }

        }
        
    }
}
