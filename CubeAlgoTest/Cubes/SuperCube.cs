using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeAlgoTest.Cubes {
    
    public class SuperCube : Cube {

        #region Constructors

        protected SuperCube(Vector3 position, double width, double height, double length) {
            m_position = position;
            m_width = width;
            m_height = height;
            m_length = length;
            m_cublings = m_tmpCublings = new Cubling[3, 3, 3];
            m_timer = 0;
        }

        public static SuperCube CreateInstance(Vector3 position, double width, double height, double length) {
            return new SuperCube(position, width, height, length);
        }

        #endregion

        #region Declarations

        private Cubling[, ,] m_cublings;
        private Cubling[, ,] m_tmpCublings;
        private double m_timer;

        #endregion

        #region Properties

        public Cubling[, ,] Cublings {
            get { return m_cublings; }
            set { m_cublings = value; }
        }

        #endregion

        #region Functions

        public void PrepareShift() {
            Random r = new Random();
            
            // First lets determine how many shifts we are to perform (not too many of course)
            int nShifts = r.Next(1, 6);
            int currentShift = 0;

            Cubling[, ,] tmp = m_cublings;

            while (currentShift < nShifts) {
                int fromRow = r.Next(0, 3);
                int fromCol = r.Next(0, 3);
                int fromAis = r.Next(0, 3);

                int toRow = r.Next(0, 3);
                int toCol = r.Next(0, 3);
                int toAis = r.Next(0, 3);

                Cubling from = m_cublings[fromRow, fromCol, fromAis];
                Cubling to = m_cublings[toRow, toCol, toAis];

                tmp[toRow, toCol, toAis] = from;
                tmp[fromRow, fromCol, fromAis] = to;

                ++currentShift;
            }

            m_tmpCublings = tmp;
            m_timer = 0;
        }

        /* 
         * Parameter need to be a timer of some description.
         * The purpose of this function is to move our Cublings
         * over time until they match the positions in the temp
         * cublings array.
         */
        public void PerformShift(/* Timer timer */) {
            //m_timer += timer.Milliseconds;

            for (int i = 0; i < 3; ++i) {
                for (int j = 0; j < 3; ++j) {
                    for (int k = 0; k < 3; ++k) {
                        if (m_cublings[i, j, k].Position != m_tmpCublings[i, j, k].Position) { 
                            // Move them based on time and a speed value
                        }
                    }
                }
            }
        }

        #endregion
    }
}
