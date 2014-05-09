using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MClib
{
    public enum WireDirection { input, output }
    public class MCWire
    {
        IMCObject _base_object;
        MCWire connected_wire;
        WireDirection dir;
        
        public MCWire(IMCObject obj, WireDirection dir)
        {
            this._base_object = obj;
            this.connected_wire = null;
            this.dir = dir;
        }

        bool isConnected()
        {
            return this.connected_wire != null;
        }
        void connectTo(MCWire wire)
        {
            this.connected_wire = wire;
        }
    }

    public interface IMCObject
    {
        List<MCWire> inputs { get; }
        List<MCWire> outputs { get; }
        MCCircuit connect(IMCObject a, IMCObject b);
    }
}
