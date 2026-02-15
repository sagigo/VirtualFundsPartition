using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualFundsPartition
{
    public partial class MainWindow : Form
    {

        private Portfolio portfolio;

        enum Operation : int
        {
            ADD_TO_PORTFOLIO,
            ADD_TO_FUND,
            CREATE_FUND,
            DELETE_FUND
        };

        private string[] combox_items ={
            "add to portfolio\'s total balance",
            "add to selected fund\'s balance",
            "create new fund",
            "delete selected fund"};

        public MainWindow()
        {
            InitializeComponent();
            operation_combox.Items.AddRange(combox_items);
            portfolio = null;
        }

        private void create_new_button_Click(object sender, EventArgs e)
        {
            CreatePortfolioDialog dialog = new CreatePortfolioDialog();
            dialog.ShowDialog();

            if (dialog.DialogResult == DialogResult.OK)
            {
                database_textbox.Text = dialog.SelectedPath;
                portfolio = dialog.CreatedPortfolio;
                LoadToViewer();
            }
        }

        private void LoadToViewer()
        {
            main_data_viewer.Rows.Clear();
            if (portfolio == null)
            {
                // raise error
                return;
            }

            foreach (var row in portfolio.StringTable)
            {
                main_data_viewer.Rows.Add(row);
            }

            total_balance_textbox.Text = string.Format("{0:C2}", portfolio.TotalBalance);
            portfolio_name_label.Text = portfolio.Name;
            update_groupbox.Visible = true;
        
        }

        private void SaveDataBase()
        {
            try
            {
                File.WriteAllText(database_textbox.Text,
                   portfolio.JsonStringRepresentation);
            }
            catch (IOException)
            {
                MessageBox.Show("Error: Coult not save DB for given path",
        "File error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void open_database_button_Click(object sender, EventArgs e)
        {
            open_file_dialog.ShowDialog();
            if (open_file_dialog.CheckFileExists)
            {
                database_textbox.Text = open_file_dialog.FileName;
                var json_string = File.ReadAllText(open_file_dialog.FileName);
                portfolio = new Portfolio(json_string);
                LoadToViewer();
            }
        }

        private void add_money_button_Click(object sender, EventArgs e)
        {
            string selected_fund = ((Operation)operation_combox.SelectedIndex == Operation.ADD_TO_FUND)
                ?
                main_data_viewer[0, main_data_viewer.SelectedCells[0].RowIndex].Value.ToString()
                :
                "all portfolio";

            var dialog_result = MessageBox.Show(string.Format("Are you sure you want to add {0:C2} to {1}?", money_to_add_numeric.Value, selected_fund),
                "aprove operation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog_result == DialogResult.Yes)
            {
                if ((Operation)operation_combox.SelectedIndex == Operation.ADD_TO_FUND)
                {
                    portfolio.AddToFund(selected_fund, (double)money_to_add_numeric.Value);
                }
                else if ((Operation)operation_combox.SelectedIndex == Operation.ADD_TO_PORTFOLIO)
                {
                    portfolio.UpdateTotalBalance(portfolio.TotalBalance + (double)money_to_add_numeric.Value);
                }

                LoadToViewer();
                SaveDataBase();
            }
        }

        private void delete_fund_button_Click(object sender, EventArgs e)
        {
            string selected_fund = main_data_viewer[0, main_data_viewer.SelectedCells[0].RowIndex].Value.ToString();

            var dialog_result = MessageBox.Show(string.Format("Are you sure you delete fund {0} forever?",
                selected_fund),
    "aprove operation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog_result == DialogResult.Yes)
            {
                portfolio.RemoveFund(selected_fund);
            }
            LoadToViewer();
            SaveDataBase();
        }
        private void add_fund_button_Click(object sender, EventArgs e)
        {
            var dialog_result = MessageBox.Show(string.Format("Are you sure you want create this new fund?"),
"aprove operation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog_result == DialogResult.Yes)
            {
                portfolio.AddFund(new_name_textbox.Text, (double)inital_money_numeric.Value);
            }
            LoadToViewer();
            SaveDataBase();
        }


        private void HideAllPanels()
        {
            add_balance_panel.Visible = false;
            create_new_panel.Visible = false;
            delete_panel.Visible = false;
        }
        private void operation_combox_SelectedIndexChanged(object sender, EventArgs e)
        {
            HideAllPanels();
            switch ((Operation)operation_combox.SelectedIndex)
            {
                case Operation.ADD_TO_PORTFOLIO:
                case Operation.ADD_TO_FUND:
                    add_balance_panel.Visible = true;
                    break;

                case Operation.CREATE_FUND:
                    create_new_panel.Visible = true;
                    break;

                case Operation.DELETE_FUND:
                    delete_panel.Visible = true;
                    break;

                default:
                    break;
            }
        }
    }
}
