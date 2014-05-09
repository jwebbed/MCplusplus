using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Irony.Parsing;

namespace MCPPGrammar
{
    public class MCPPGrammar : Irony.Parsing.Grammar
    {
        public MCPPGrammar()
        {
            this.MarkReservedWords("module", "input", "output", "assign");
        }
    }
}
