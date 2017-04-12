using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankChallenges
{
    class Operators
    {
        double _cost;
        double _tipPercent;
        double _taxPercent;
        public int TotalCost { get; private set; }

        public Operators(double Cost, int TipPercent, int TaxPercent)
        {
            _cost = Cost;
            _tipPercent = Convert.ToDouble(TipPercent);
            _taxPercent = Convert.ToDouble(TaxPercent);
        }

        public void CalculateTotal()
        {
            double dTip = _cost * (_tipPercent / 100);
            double dTax = _cost * (_taxPercent / 100);
            double dTotalCost = _cost + dTip + dTax;

            TotalCost = Convert.ToInt32(Math.Round(dTotalCost, 0));
        }
    }
}
