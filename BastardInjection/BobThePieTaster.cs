using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BastardInjection.Interface;
using ForeignValidationEngine;

namespace BastardInjection
{
    public class BobThePieTaster : IEvaluator
    {
        private readonly IValidationEngine _engine;
        private readonly Pie _pie;

        public BobThePieTaster(IValidationEngine engine, Pie pie)
        {
            if (engine == null)
                throw new ArgumentNullException("engine");

            _engine = engine;
            _pie = pie;
        }

        public BobThePieTaster(Pie pie): this(new ProperBritishTasteEngine(new BritishPieStandardAgencyEval()), pie)
        {

        }

        public bool Likes()
        {
            return _engine.Evaluate(_pie);
        }
    }
}
