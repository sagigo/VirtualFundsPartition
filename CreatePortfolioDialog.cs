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
    public partial class CreatePortfolioDialog : Form
    {

        private Portfolio created_portfolio;
        private string selected_path;
        public CreatePortfolioDialog()
        {
            InitializeComponent();
            created_portfolio = null;
            selected_path = null;
        }

        private void file_path_textbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            choose_file_dialog.ShowDialog();
        }

        private void choose_file_dialog_FileOk(object sender, CancelEventArgs e)
        {
            file_path_textbox.Text = choose_file_dialog.FileName;
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            List<(string, double)> funds = new List<(string, double)>(); 
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                try
                {
                    funds.Add((dataGridView1[0, i].Value.ToString(),
                        double.Parse(dataGridView1[1, i].Value.ToString())));
                }
                catch (NullReferenceException)
                {
                    // pass
                }
                catch (FormatException)
                {
                    MessageBox.Show("Error: Invalid input: Make sure money consist a valid number",
                        "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (funds.Count < 0) 
            {
                MessageBox.Show("Error: Invalid input: List is empty",
                        "Empty list error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            created_portfolio = new Portfolio(funds.ToArray(), portfoilio_name_textbox.Text);
            try
            {
                File.WriteAllText(file_path_textbox.Text,
                   created_portfolio.JsonStringRepresentation);
            }
            catch (IOException)
            {
                MessageBox.Show("Error: Coult not create DB for given path",
        "File error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            selected_path = file_path_textbox.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public Portfolio CreatedPortfolio { get { return created_portfolio; } }
        public string SelectedPath { get { return selected_path; } }
    }
}
