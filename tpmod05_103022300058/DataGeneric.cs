using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmod05_103022300058
{
    class DataGeneric<T>
    {
        // Property data bertipe generic
        private T data;

        // Konstruktor dengan parameter data
        public DataGeneric(T data)
        {
            this.data = data;
        }

        // Method PrintData untuk mencetak nilai data
        public void PrintData()
        {
            Console.WriteLine("Data yang tersimpan adalah: " + data);
        }
    }
}
