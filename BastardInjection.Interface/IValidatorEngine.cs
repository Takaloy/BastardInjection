using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BastardInjection.Interface;

namespace BastardInjection
{
    public interface IValidationEngine
    {
        bool Evaluate(Pie pie);
    }
}
