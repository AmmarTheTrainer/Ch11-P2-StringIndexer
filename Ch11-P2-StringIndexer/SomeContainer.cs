using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11_P2_StringIndexer
{
    class SomeContainer
    {
        private int[,] my2DintArray = new int[10,10];

        public int this[int row , int col]
        {
            get => 0;
            set => my2DintArray[3,3] = value;
        }
    }
}
