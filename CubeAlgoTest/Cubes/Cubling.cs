using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CubeAlgoTest.Cubes {
    
    public class Cubling : Cube {

        #region Constructors

        public Cubling(SuperCube parent, int row, int column, int aisle) {
            Row = row;
            Column = column;
            Aisle = aisle;
            parent.Cublings[Row, Column, Aisle] = this;
            m_width = parent.Width / 3;
            m_height = parent.Height / 3;
            m_length = parent.Length / 3;
            m_objects = new List<Object>();
        }

        #endregion

        #region Declarations

        // Change tpye to whatever type Unity uses for the Objects
        private List<Object> m_objects;

        #endregion

        #region Properties

        public int Row { get; set; }

        public int Column { get; set; }

        public int Aisle { get; set; }

        public Vector3 BallSpawnPosition { get; private set; }

        // Public accessor for our cubes Objects
        public List<Object> Objects {
            get { return m_objects; }
        }

        #endregion

        #region Functions

        public void SetObjects(string path) { 
            /*
             * If performance is slow,
             * turn on Async and implement Aysynchronous reading
             * along with required functions.
             */
            XmlReader xmlReader = XmlReader.Create(path, 
                new XmlReaderSettings { 
                    IgnoreWhitespace = true, 
                    CloseInput = true, 
                    DtdProcessing = DtdProcessing.Parse 
                });

            while (xmlReader.Read()) {
                /*
                 * Set the Cubes objects based on the XML data.
                 */
                //m_objects.Add(some_object);
            }
        }

        public void SetBallSpawnPosition(Vector3 position) {
            BallSpawnPosition = position;
        }

        #endregion
    }
}
