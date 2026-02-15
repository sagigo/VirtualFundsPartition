
namespace VirtualFundsPartition
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.main_data_viewer = new System.Windows.Forms.DataGridView();
            this.name_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.money_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percent_column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.database_textbox = new System.Windows.Forms.TextBox();
            this.open_database_button = new System.Windows.Forms.Button();
            this.create_new_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.total_balance_textbox = new System.Windows.Forms.TextBox();
            this.open_file_dialog = new System.Windows.Forms.OpenFileDialog();
            this.portfolio_name_label = new System.Windows.Forms.Label();
            this.update_groupbox = new System.Windows.Forms.GroupBox();
            this.add_balance_panel = new System.Windows.Forms.Panel();
            this.add_money_button = new System.Windows.Forms.Button();
            this.money_to_add_numeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.delete_panel = new System.Windows.Forms.Panel();
            this.delete_fund_button = new System.Windows.Forms.Button();
            this.create_new_panel = new System.Windows.Forms.Panel();
            this.new_name_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.add_fund_button = new System.Windows.Forms.Button();
            this.inital_money_numeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.operation_combox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.main_data_viewer)).BeginInit();
            this.update_groupbox.SuspendLayout();
            this.add_balance_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.money_to_add_numeric)).BeginInit();
            this.delete_panel.SuspendLayout();
            this.create_new_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inital_money_numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // main_data_viewer
            // 
            this.main_data_viewer.AllowUserToAddRows = false;
            this.main_data_viewer.AllowUserToDeleteRows = false;
            this.main_data_viewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.main_data_viewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name_column,
            this.money_column,
            this.percent_column1});
            this.main_data_viewer.Location = new System.Drawing.Point(122, 115);
            this.main_data_viewer.Name = "main_data_viewer";
            this.main_data_viewer.ReadOnly = true;
            this.main_data_viewer.Size = new System.Drawing.Size(347, 264);
            this.main_data_viewer.TabIndex = 0;
            // 
            // name_column
            // 
            this.name_column.HeaderText = "Portfolio Name";
            this.name_column.Name = "name_column";
            this.name_column.ReadOnly = true;
            // 
            // money_column
            // 
            this.money_column.HeaderText = "Money";
            this.money_column.Name = "money_column";
            this.money_column.ReadOnly = true;
            // 
            // percent_column1
            // 
            this.percent_column1.HeaderText = "Percents";
            this.percent_column1.Name = "percent_column1";
            this.percent_column1.ReadOnly = true;
            // 
            // database_textbox
            // 
            this.database_textbox.Location = new System.Drawing.Point(122, 414);
            this.database_textbox.Name = "database_textbox";
            this.database_textbox.ReadOnly = true;
            this.database_textbox.Size = new System.Drawing.Size(225, 20);
            this.database_textbox.TabIndex = 1;
            // 
            // open_database_button
            // 
            this.open_database_button.Location = new System.Drawing.Point(353, 412);
            this.open_database_button.Name = "open_database_button";
            this.open_database_button.Size = new System.Drawing.Size(76, 23);
            this.open_database_button.TabIndex = 2;
            this.open_database_button.Text = "open file";
            this.open_database_button.UseVisualStyleBackColor = true;
            this.open_database_button.Click += new System.EventHandler(this.open_database_button_Click);
            // 
            // create_new_button
            // 
            this.create_new_button.Location = new System.Drawing.Point(254, 12);
            this.create_new_button.Name = "create_new_button";
            this.create_new_button.Size = new System.Drawing.Size(75, 78);
            this.create_new_button.TabIndex = 3;
            this.create_new_button.Text = "Create new portfolio";
            this.create_new_button.UseVisualStyleBackColor = true;
            this.create_new_button.Click += new System.EventHandler(this.create_new_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Balance:";
            // 
            // total_balance_textbox
            // 
            this.total_balance_textbox.Location = new System.Drawing.Point(201, 379);
            this.total_balance_textbox.Name = "total_balance_textbox";
            this.total_balance_textbox.ReadOnly = true;
            this.total_balance_textbox.Size = new System.Drawing.Size(100, 20);
            this.total_balance_textbox.TabIndex = 5;
            // 
            // portfolio_name_label
            // 
            this.portfolio_name_label.AutoSize = true;
            this.portfolio_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.portfolio_name_label.Location = new System.Drawing.Point(142, 89);
            this.portfolio_name_label.Name = "portfolio_name_label";
            this.portfolio_name_label.Size = new System.Drawing.Size(327, 24);
            this.portfolio_name_label.TabIndex = 6;
            this.portfolio_name_label.Text = "choose portfolio file or create new";
            // 
            // update_groupbox
            // 
            this.update_groupbox.Controls.Add(this.add_balance_panel);
            this.update_groupbox.Controls.Add(this.delete_panel);
            this.update_groupbox.Controls.Add(this.create_new_panel);
            this.update_groupbox.Controls.Add(this.operation_combox);
            this.update_groupbox.Location = new System.Drawing.Point(478, 114);
            this.update_groupbox.Name = "update_groupbox";
            this.update_groupbox.Size = new System.Drawing.Size(164, 265);
            this.update_groupbox.TabIndex = 7;
            this.update_groupbox.TabStop = false;
            this.update_groupbox.Text = "Update portfolio balance";
            this.update_groupbox.Visible = false;
            // 
            // add_balance_panel
            // 
            this.add_balance_panel.Controls.Add(this.add_money_button);
            this.add_balance_panel.Controls.Add(this.money_to_add_numeric);
            this.add_balance_panel.Controls.Add(this.label2);
            this.add_balance_panel.Location = new System.Drawing.Point(1, 71);
            this.add_balance_panel.Name = "add_balance_panel";
            this.add_balance_panel.Size = new System.Drawing.Size(145, 188);
            this.add_balance_panel.TabIndex = 1;
            this.add_balance_panel.Visible = false;
            // 
            // add_money_button
            // 
            this.add_money_button.Location = new System.Drawing.Point(30, 127);
            this.add_money_button.Name = "add_money_button";
            this.add_money_button.Size = new System.Drawing.Size(83, 40);
            this.add_money_button.TabIndex = 2;
            this.add_money_button.Text = "Add money";
            this.add_money_button.UseVisualStyleBackColor = true;
            this.add_money_button.Click += new System.EventHandler(this.add_money_button_Click);
            // 
            // money_to_add_numeric
            // 
            this.money_to_add_numeric.DecimalPlaces = 2;
            this.money_to_add_numeric.Location = new System.Drawing.Point(75, 27);
            this.money_to_add_numeric.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.money_to_add_numeric.Minimum = new decimal(new int[] {
            1410065408,
            2,
            0,
            -2147483648});
            this.money_to_add_numeric.Name = "money_to_add_numeric";
            this.money_to_add_numeric.Size = new System.Drawing.Size(70, 20);
            this.money_to_add_numeric.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "money to add:";
            // 
            // delete_panel
            // 
            this.delete_panel.Controls.Add(this.delete_fund_button);
            this.delete_panel.Location = new System.Drawing.Point(1, 71);
            this.delete_panel.Name = "delete_panel";
            this.delete_panel.Size = new System.Drawing.Size(145, 188);
            this.delete_panel.TabIndex = 3;
            this.delete_panel.Visible = false;
            // 
            // delete_fund_button
            // 
            this.delete_fund_button.Location = new System.Drawing.Point(30, 127);
            this.delete_fund_button.Name = "delete_fund_button";
            this.delete_fund_button.Size = new System.Drawing.Size(83, 40);
            this.delete_fund_button.TabIndex = 2;
            this.delete_fund_button.Text = "delete fund";
            this.delete_fund_button.UseVisualStyleBackColor = true;
            this.delete_fund_button.Click += new System.EventHandler(this.delete_fund_button_Click);
            // 
            // create_new_panel
            // 
            this.create_new_panel.Controls.Add(this.new_name_textbox);
            this.create_new_panel.Controls.Add(this.label4);
            this.create_new_panel.Controls.Add(this.add_fund_button);
            this.create_new_panel.Controls.Add(this.inital_money_numeric);
            this.create_new_panel.Controls.Add(this.label3);
            this.create_new_panel.Location = new System.Drawing.Point(1, 71);
            this.create_new_panel.Name = "create_new_panel";
            this.create_new_panel.Size = new System.Drawing.Size(145, 188);
            this.create_new_panel.TabIndex = 8;
            this.create_new_panel.Visible = false;
            // 
            // new_name_textbox
            // 
            this.new_name_textbox.Location = new System.Drawing.Point(71, 15);
            this.new_name_textbox.Name = "new_name_textbox";
            this.new_name_textbox.Size = new System.Drawing.Size(71, 20);
            this.new_name_textbox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fund name:";
            // 
            // add_fund_button
            // 
            this.add_fund_button.Location = new System.Drawing.Point(30, 127);
            this.add_fund_button.Name = "add_fund_button";
            this.add_fund_button.Size = new System.Drawing.Size(83, 40);
            this.add_fund_button.TabIndex = 2;
            this.add_fund_button.Text = "Add fund";
            this.add_fund_button.UseVisualStyleBackColor = true;
            this.add_fund_button.Click += new System.EventHandler(this.add_fund_button_Click);
            // 
            // inital_money_numeric
            // 
            this.inital_money_numeric.DecimalPlaces = 2;
            this.inital_money_numeric.Location = new System.Drawing.Point(75, 38);
            this.inital_money_numeric.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.inital_money_numeric.Minimum = new decimal(new int[] {
            1410065408,
            2,
            0,
            -2147483648});
            this.inital_money_numeric.Name = "inital_money_numeric";
            this.inital_money_numeric.Size = new System.Drawing.Size(70, 20);
            this.inital_money_numeric.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Initial balance:";
            // 
            // operation_combox
            // 
            this.operation_combox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operation_combox.FormattingEnabled = true;
            this.operation_combox.Location = new System.Drawing.Point(6, 33);
            this.operation_combox.Name = "operation_combox";
            this.operation_combox.Size = new System.Drawing.Size(152, 21);
            this.operation_combox.TabIndex = 0;
            this.operation_combox.SelectedIndexChanged += new System.EventHandler(this.operation_combox_SelectedIndexChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 446);
            this.Controls.Add(this.update_groupbox);
            this.Controls.Add(this.portfolio_name_label);
            this.Controls.Add(this.total_balance_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.create_new_button);
            this.Controls.Add(this.open_database_button);
            this.Controls.Add(this.database_textbox);
            this.Controls.Add(this.main_data_viewer);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.main_data_viewer)).EndInit();
            this.update_groupbox.ResumeLayout(false);
            this.add_balance_panel.ResumeLayout(false);
            this.add_balance_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.money_to_add_numeric)).EndInit();
            this.delete_panel.ResumeLayout(false);
            this.create_new_panel.ResumeLayout(false);
            this.create_new_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inital_money_numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView main_data_viewer;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn money_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn percent_column1;
        private System.Windows.Forms.TextBox database_textbox;
        private System.Windows.Forms.Button open_database_button;
        private System.Windows.Forms.Button create_new_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox total_balance_textbox;
        private System.Windows.Forms.OpenFileDialog open_file_dialog;
        private System.Windows.Forms.Label portfolio_name_label;
        private System.Windows.Forms.GroupBox update_groupbox;
        private System.Windows.Forms.ComboBox operation_combox;
        private System.Windows.Forms.Panel add_balance_panel;
        private System.Windows.Forms.NumericUpDown money_to_add_numeric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button add_money_button;
        private System.Windows.Forms.Panel create_new_panel;
        private System.Windows.Forms.TextBox new_name_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button add_fund_button;
        private System.Windows.Forms.NumericUpDown inital_money_numeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel delete_panel;
        private System.Windows.Forms.Button delete_fund_button;
    }
}