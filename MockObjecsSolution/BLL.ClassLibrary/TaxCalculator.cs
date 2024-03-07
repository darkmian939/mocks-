using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ClassLibrary
{
    public class TaxCalculator
    {
        private readonly IDdatabase _database;
        public TaxCalculator(IDdatabase database) 
        {
            this._database = database;
        }

        public double CalculateTotalValueForPerson(double amount, int id) 
        {
            var tax = _database.GetTaxPercentageByPersonId(id);
            return Math.Round(amount * (1+tax),2);
        }


    }
}
