using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CubeAlgoTest.Cubes;
using CubeAlgoTest.Metrics;

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

            Block block = new Block { Height = 10, Width = 10, Length = 10 };
            Console.WriteLine(block.Volume.ToString());

            Console.ReadKey();
        }
    }
}
