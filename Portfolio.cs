using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualFundsPartition
{
    public class Portfolio
    {
        private double total_money;
        private Dictionary<string, FundPartition> partitions_map;
        private static int protfolio_count = 0;
        private const double DEVIATION = 0.00001;
        public Portfolio()
        {
            total_money = 0;
            partitions_map = new Dictionary<string, FundPartition>();
            Name = "protfolio" + protfolio_count++;
        }

        public Portfolio(string json_snapshot_str) :
            this(JsonSerializer.Deserialize<PortfolioSnapshot>(json_snapshot_str))
        { }

        public Portfolio(PortfolioSnapshot portfolio_snapshot)
        {
            partitions_map = new Dictionary<string, FundPartition>();
            foreach (var fund in portfolio_snapshot.FundsList)
            {
                if (fund.Money < 0) { throw new ArgumentOutOfRangeException("Unable create fund with negative balance"); }
                total_money += fund.Money;
            }

            foreach (var fund in portfolio_snapshot.FundsList)
            {
                partitions_map.Add(fund.Name,
    new FundPartition(fund.Name, fund.Money / total_money));
            }

            Name = (portfolio_snapshot.Name == null) ? ("protfolio" + protfolio_count++) : portfolio_snapshot.Name;
        }

        public Portfolio(string[] name_list, double[] money_list, string protfolio_name = null)
        {
            partitions_map = new Dictionary<string, FundPartition>();

            if (name_list.Length != money_list.Length)
            {
                throw new ArgumentException("name list must be matched to money list");
            }

            foreach (var m in money_list)
            {
                if (m < 0) { throw new ArgumentOutOfRangeException("Unable create fund with negative balance"); }
                total_money += m;
            }

            for (int i = 0; i < name_list.Length; i++)
            {
                partitions_map.Add(name_list[i],
                    new FundPartition(name_list[i], money_list[i] / total_money));
            }
            Name = (protfolio_name == null) ? ("protfolio" + protfolio_count++) : protfolio_name;
        }

        public Portfolio((string, double)[] funds, string protfolio_name = null)
        {
            partitions_map = new Dictionary<string, FundPartition>();

            foreach (var fund in funds)
            {
                if (fund.Item2 < 0) { throw new ArgumentOutOfRangeException("Unable create fund with negative balance"); }
                total_money += fund.Item2;
            }

            foreach (var fund in funds)
            {
                partitions_map.Add(fund.Item1,
    new FundPartition(fund.Item1, fund.Item2 / total_money));
            }
            Name = (protfolio_name == null) ? ("protfolio" + protfolio_count++) : protfolio_name;
        }

        public void UpdateTotalBalance(double new_balace)
        {
            if (new_balace < 0)
            {
                throw new ArgumentOutOfRangeException("Total balance cannot be negative");
            }
            total_money = new_balace;
        }

        public void AddFund(string name, double money)
        {
            if (money < 0) { throw new ArgumentOutOfRangeException("Unable create fund with negative balance"); }
            double new_total_money = total_money + money;
            foreach (var item in partitions_map)
            {
                var current_money = item.Value.Percents * total_money;
                item.Value.Percents = current_money / new_total_money;
            }

            partitions_map.Add(name, new FundPartition(name, money / new_total_money));
            total_money = new_total_money;
        }

        public void RemoveFund(string name)
        {
            var fund_to_remove = partitions_map[name];
            // TODO: check if exists partitions_map[name]
            var current_balance = fund_to_remove.Percents * total_money;
            AddToFund(name, -current_balance);
            partitions_map.Remove(name);
        }

        public void AddToFund(string name, double money_to_add)
        {
            var current_balance = partitions_map[name].Percents * total_money;
            // TODO: check if exists partitions_map[name]
            var new_balance = current_balance + money_to_add;
            if (new_balance < 0) { throw new ArgumentOutOfRangeException("Fund can't be with negative balance"); }
            var new_total_money = total_money + money_to_add;

            foreach (var item in partitions_map)
            {
                var current_money = item.Value.Percents * total_money;
                if (item.Value == partitions_map[name])
                {
                    current_money = new_balance;
                }
                item.Value.Percents = current_money / new_total_money;
            }
            total_money = new_total_money;
        }

        public PortfolioSnapshot Snapshot
        {
            get
            {
                PortfolioSnapshot portfolio_snapshot = new PortfolioSnapshot(this.Name);

                foreach (var item in partitions_map)
                {
                    PortfolioSnapshot.Fund fund = new PortfolioSnapshot.Fund(item.Value.Name,
                        item.Value.Percents * total_money);
                    portfolio_snapshot.FundsList.Add(fund);
                }

                return portfolio_snapshot;
            }
        }

        public string JsonStringRepresentation
        {
            get
            {
                var snapshot = Snapshot;
                return JsonSerializer.Serialize(snapshot);
            }
        }

        public string[][] StringTable
        {
            get
            {
                string[][] table = new string[partitions_map.Count][];
                uint index = 0;
                foreach (var item in partitions_map)
                {
                    table[index] = new string[3];
                    table[index][0] = item.Key;
                    table[index][1] = string.Format("{0:C2}", item.Value.Percents * total_money);
                    table[index][2] = string.Format("{0:P2}", item.Value.Percents);
                    index++;
                }

                return table;
            }
        }

        public string Name { get; set; }
        public double TotalBalance { get { return total_money; } }

        private class FundPartition
        {
            private double percents;
            private string name;

            public FundPartition(string name, double percents)
            {
                Name = name;
                Percents = percents;
            }
            public double Percents
            {
                get { return percents; }
                set
                {
                    if (value < 0 - DEVIATION || value > 1 + DEVIATION) { throw new ArgumentOutOfRangeException(); }
                    percents = value;
                }
            }
            public string Name { get { return name; } set { name = value; } }

        }
    }
}
