using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ClassLibrary.xUnit.UnitTests._2_MS_Fakes
{
    public class TaxCalculatorUnitTests
    {
        private readonly TaxCalculator _taxCalculator;
        public TaxCalculatorUnitTests()
        {
            var database = new BLL.ClassLibrary.Fakes.StubIDatabase();
        }
    }
}
