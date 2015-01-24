using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CubeAlgoTest.Cubes;

namespace CubeAlgoTest {
    
    class Program {
    
        static void Main(string[] args) {
            SuperCube superCube = SuperCube.CreateInstance(
                new Vector3 { 
                    X = -2f, 
                    Y = 2f, 
                    Z = 0f }, 
                    200, 200, 200);

            Cubling c0 = new Cubling(superCube, 0, 1, 1);

            Console.WriteLine(c0.Width.ToString());

            Console.ReadKey();
        }
    }
}
