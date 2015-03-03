using BastardInjection.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BastardInjection
{
    public interface IPieStandardEvaluator
    {
        bool Fulfils(Pie pie);
    }
}
