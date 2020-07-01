using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TelloLib;
using Newtonsoft.Json;

namespace _3D_Visualize
{
    class Program
    {
        public class TelloSpec
        {
            public Dictionary<string, List<float>> coords = new Dictionary<string, List<float>>();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }
    }
}
