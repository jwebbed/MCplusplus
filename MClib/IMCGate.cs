using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MClib
{
    public enum MCBlock { }

    public class Schematic
    {
        private MCBlock[, ,] map;

        public Schematic(int x, int y, int z)
        {
            this.map = new MCBlock[x, y, z];
        }

        public MCBlock this[int index1, int index2, int index3]
        {
            get
            {
                return this.map[index1, index2, index3];
            }
            set
            {
                this.map[index1, index2, index3] = value;
            }
        }
    }

    public interface IMCGate : IMCObject
    {
        Schematic getSchematics();
    }


}
