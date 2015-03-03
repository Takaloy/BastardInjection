using BastardInjection.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BastardInjection
{
    public class BritishPieStandardAgencyEval : IPieStandardEvaluator
    {
        public bool Fulfils(Pie pie)
        {
            if (pie is BritishBeefPie)
                return true;

            return false;
        }
    }
}
