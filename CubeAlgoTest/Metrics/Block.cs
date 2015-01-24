/***** Block *****/

#region Namespaces

namespace CubeAlgoTest.Metrics {

    #region Structures

    /*
     * Everything should be measured in blocks, keeping all objects uniform.
     * It will make object placement simpler and less painstaking.
     * 
     * USAGE:
     * Set the block size once. Then all cubes, objects will be created based
     * on this block and its dimensions.
     */
    public struct Block {

        #region Members

        public double Width,
                      Height,
                      Length;

        #endregion

        #region Properties

        public double Volume {
            get { return (Width * Height * Length); }
        }

        #endregion
    }

    #endregion
}

#endregion