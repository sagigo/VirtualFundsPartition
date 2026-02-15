using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualFundsPartition
{
    public class PortfolioSnapshot
    {
        public PortfolioSnapshot()
        {
            FundsList = new List<Fund>();
        }

        public PortfolioSnapshot(string main_name)
        {
            Name = main_name;
            FundsList = new List<Fund>();
        }
        public struct Fund
        {
            public Fund(string name, double money)
            {
                Name = name;
                Money = money;
            }
            public string Name { get; set; }
            public double Money { get; set; }
        }
        public string Name { get; set; }
        public List<Fund> FundsList { get; set; }

    }
}
