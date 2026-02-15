
namespace VirtualFundsPartition
{
    partial class CreatePortfolioDialog
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.money_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portfoilio_name_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ok_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.file_path_textbox = new System.Windows.Forms.TextBox();
            this.choose_file_dialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name_column,
            this.money_column});
            this.dataGridView1.Location = new System.Drawing.Point(85, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(246, 246);
            this.dataGridView1.TabIndex = 0;
            // 
            // name_column
            // 
            this.name_column.HeaderText = "Fund name";
            this.name_column.Name = "name_column";
            // 
            // money_column
            // 
            this.money_column.HeaderText = "money";
            this.money_column.Name = "money_column";
            // 
            // portfoilio_name_textbox
            // 
            this.portfoilio_name_textbox.Location = new System.Drawing.Point(167, 76);
            this.portfoilio_name_textbox.Name = "portfoilio_name_textbox";
            this.portfoilio_name_textbox.Size = new System.Drawing.Size(164, 20);
            this.portfoilio_name_textbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Portfolio Name:";
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(86, 354);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(75, 23);
            this.ok_button.TabIndex = 3;
            this.ok_button.Text = "ok";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_button.Location = new System.Drawing.Point(256, 354);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 4;
            this.cancel_button.Text = "cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Database file:";
            // 
            // file_path_textbox
            // 
            this.file_path_textbox.Location = new System.Drawing.Point(167, 50);
            this.file_path_textbox.Name = "file_path_textbox";
            this.file_path_textbox.Size = new System.Drawing.Size(164, 20);
            this.file_path_textbox.TabIndex = 5;
            this.file_path_textbox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.file_path_textbox_MouseDoubleClick);
            // 
            // choose_file_dialog
            // 
            this.choose_file_dialog.FileOk += new System.ComponentModel.CancelEventHandler(this.choose_file_dialog_FileOk);
            // 
            // CreatePortfolioDialog
            // 
            this.AcceptButton = this.ok_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel_button;
            this.ClientSize = new System.Drawing.Size(417, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.file_path_textbox);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.portfoilio_name_textbox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CreatePortfolioDialog";
            this.Text = "Create Portfolio Dialog";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn money_column;
        private System.Windows.Forms.TextBox portfoilio_name_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox file_path_textbox;
        private System.Windows.Forms.SaveFileDialog choose_file_dialog;
    }
}