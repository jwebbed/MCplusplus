using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MClib
{
    public class MCCircuit : IMCObject
    {
        private List<MCWire> _inputs;
        private List<MCWire> _outputs;

        public List<MCWire> inputs { get { return this._inputs; } }
        public List<MCWire> outputs { get { return this._outputs; } }
        public MCCircuit(List<MCWire> inputs, List<MCWire> outputs)
        {
            this._inputs = inputs;
            this._outputs = outputs;
        }

        #region NYI

        void generateCircuit()
        {
            throw new NotImplementedException();
        }
        void optimize()
        {
            throw new NotImplementedException();
        }

        public MCCircuit connect(IMCObject a, IMCObject b)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
