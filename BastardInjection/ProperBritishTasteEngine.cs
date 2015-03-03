using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BastardInjection
{
    public class ProperBritishTasteEngine : IValidationEngine
    {
        private readonly IPieStandardEvaluator _eval;

        public ProperBritishTasteEngine(IPieStandardEvaluator eval)
        {
            if (eval == null)
                throw new ArgumentNullException("eval");

            _eval = eval;
        }

        public bool Evaluate(Interface.Pie pie)
        {
            if (_eval.Fulfils(pie))
                return true;
                        
            return false;
        }
    }
}
