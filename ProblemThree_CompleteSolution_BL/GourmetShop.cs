using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    public abstract class GourmetShop
    {
        

        public int ItemCode { get => ItemCode; set => ItemCode = value; }
        public string ItemName { get => ItemName; set => ItemName = value; }
        public Dictionary<int, double> ItemPrice { get => ItemPrice; set => ItemPrice = value; }

        public GourmetShop(int iCode,string iName) {
            ItemCode = iCode;
            ItemName = iName;
        }

        public abstract double PayPerPiece(int quantity);
        public abstract double PayPerWeight(int weight);

    }
}