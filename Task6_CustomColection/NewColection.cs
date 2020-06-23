using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_CustomColection
{
    class NewColection: IEnumerable
    {
        public int division { get; } = 1; 
        public int rangeMin { get; } 
        public int rangeMax { get; }

        private int[] CustomColection = new int[100];

        public NewColection(int div)
        {
            InitializationNewColection();
            division = div;
        }
        public NewColection(int rMin=0, int rMax=100)
        {
            InitializationNewColection();
            rangeMin = rMin;
            rangeMax = rMax;
        }
        private void InitializationNewColection()
        {
            Random random = new Random();
            for (int i = 0; i < 100; i++)
                CustomColection[i] = random.Next(-100, 100);
        }
        public IEnumerator GetEnumerator()
        {
            foreach (int x in CustomColection)
            {
                if ((x % division == 0) && (rangeMin < x) && (x < rangeMax))
                    yield return x;
            }
        }

    }
}
