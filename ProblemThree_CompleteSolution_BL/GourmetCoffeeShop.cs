using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    public class GourmetCoffeeShop : GourmetShop, ITaxCompute
    {
        public GourmetCoffeeShop(int iCode, string iName, Dictionary<int,double> iPrice):base(iCode,iName)
        {
            ItemCode = iCode;
            ItemName = iName;
            ItemPrice = iPrice;
        }

        public  double TotalBillValue { get => TotalBillValue; set => TotalBillValue = value; }

        public override double PayPerPiece(int quantity)
        {
            TotalBillValue = quantity * ItemPrice.ElementAt(1).Value;
            return TaxOnTotalBill();

        }

        public override double PayPerWeight(int weight)
        {
            TotalBillValue = weight * ItemPrice.ElementAt(2).Value;
            return TaxOnTotalBill();
        }

        public double TaxOnTotalBill()
        {
            return TotalBillValue + (TotalBillValue * 0.75);
        }

    }
}
