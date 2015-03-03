using BastardInjection;
using BastardInjection.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeignValidationEngine
{
    public class AmericanTasteBudEngine : IValidationEngine
    {
        public bool Evaluate(Pie pie)
        {
            if (pie is StargazyPie)
                return false;

            return true;
        }
    }
}
