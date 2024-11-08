using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroParcial1Hepp
{
    [Serializable]
    public class DniIncorrectoException : ApplicationException
        {
            public DniIncorrectoException() { }
            public DniIncorrectoException(string message) : base(message) { }
        }
    
}
