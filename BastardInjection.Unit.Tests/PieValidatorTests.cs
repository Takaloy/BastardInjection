using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;
using NUnit.Framework;
using BastardInjection.Interface;

namespace BastardInjection.Unit.Tests
{
    [TestFixture]
    public class PieValidatorTests
    {
        [TestCase(true)]
        [TestCase(false)]
        public void ValidatorConsultsEngineForTastinessOfPie(bool expectation)
        {
            var engine = Substitute.For<IValidationEngine>();
            var pie = Substitute.For<Pie>();
            engine.Evaluate(Arg.Any<Pie>()).Returns(expectation);

            var validator = new BobThePieTaster(engine, pie);

            Assert.AreEqual(expectation, validator.Likes());
        }
    }
}
