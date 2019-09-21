using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceSample
{
    public class Program
    {
       interface ISort
        {
            void Ascend(int[] array);
        }

        public class xxx:ISort
        {
            public void Ascend(int[] array)
            {
                throw new NotImplementedException();
            }
        }
    }
}
