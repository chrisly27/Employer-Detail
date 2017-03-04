namespace Assignment
{
    partial class DisplayRec
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
            this.btnShowAllRecord = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblStatement = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.lstEmployees = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnShowAllRecord
            // 
            this.btnShowAllRecord.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllRecord.Location = new System.Drawing.Point(569, 463);
            this.btnShowAllRecord.Name = "btnShowAllRecord";
            this.btnShowAllRecord.Size = new System.Drawing.Size(161, 72);
            this.btnShowAllRecord.TabIndex = 28;
            this.btnShowAllRecord.Text = "Show All Record";
            this.btnShowAllRecord.UseVisualStyleBackColor = true;
            this.btnShowAllRecord.Click += new System.EventHandler(this.btnShowAllRecord_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(402, 463);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(161, 72);
            this.btnRemove.TabIndex = 27;
            this.btnRemove.Text = "Remove Record";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(15, 602);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(161, 72);
            this.btnMenu.TabIndex = 26;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblStatement
            // 
            this.lblStatement.BackColor = System.Drawing.Color.DarkGray;
            this.lblStatement.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatement.Location = new System.Drawing.Point(402, 13);
            this.lblStatement.Name = "lblStatement";
            this.lblStatement.Size = new System.Drawing.Size(328, 226);
            this.lblStatement.TabIndex = 25;
            this.lblStatement.Text = "View More Detail";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(402, 294);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(328, 36);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(402, 252);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(328, 36);
            this.txtSearch.TabIndex = 23;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRecord.Location = new System.Drawing.Point(402, 360);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(161, 72);
            this.btnAddRecord.TabIndex = 22;
            this.btnAddRecord.Text = "Add New Record";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // lstEmployees
            // 
            this.lstEmployees.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEmployees.FormattingEnabled = true;
            this.lstEmployees.ItemHeight = 24;
            this.lstEmployees.Location = new System.Drawing.Point(15, 13);
            this.lstEmployees.Name = "lstEmployees";
            this.lstEmployees.Size = new System.Drawing.Size(377, 580);
            this.lstEmployees.TabIndex = 21;
            this.lstEmployees.SelectedIndexChanged += new System.EventHandler(this.lstEmployees_SelectedIndexChanged);
            // 
            // DisplayEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 687);
            this.ControlBox = false;
            this.Controls.Add(this.btnShowAllRecord);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblStatement);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAddRecord);
            this.Controls.Add(this.lstEmployees);
            this.Name = "DisplayEmp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Display Records";
            this.Load += new System.EventHandler(this.DisplayEmp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowAllRecord;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblStatement;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.ListBox lstEmployees;
    }
}