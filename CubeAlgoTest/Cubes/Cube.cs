using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeAlgoTest.Cubes {
    
    public abstract class Cube {

        #region Declarations

        protected Vector3 m_position;
        protected double m_width, m_height, m_length;

        #endregion

        #region Properties

        public double Width {
            get { return m_width; }
        }

        public double Height {
            get { return m_height; }
        }

        public double Length {
            get { return m_length; }
        }

        public Vector3 Position {
            get { return m_position; }
            set { m_position = value; }
        }

        #endregion
    }
}
