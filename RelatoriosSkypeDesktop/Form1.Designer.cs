namespace RelatoriosSkypeDesktop
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bGenerete = new System.Windows.Forms.Button();
            this.gReport = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conversaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tFrom = new System.Windows.Forms.TextBox();
            this.lFrom = new System.Windows.Forms.Label();
            this.lTo = new System.Windows.Forms.Label();
            this.tTo = new System.Windows.Forms.TextBox();
            this.tStartDate = new System.Windows.Forms.TextBox();
            this.lStartDate = new System.Windows.Forms.Label();
            this.lEndDate = new System.Windows.Forms.Label();
            this.tEndDate = new System.Windows.Forms.TextBox();
            this.ldate = new System.Windows.Forms.Label();
            this.lServer = new System.Windows.Forms.Label();
            this.tServer = new System.Windows.Forms.TextBox();
            this.lDatabase = new System.Windows.Forms.Label();
            this.tDatabase = new System.Windows.Forms.TextBox();
            this.lUsername = new System.Windows.Forms.Label();
            this.tUsername = new System.Windows.Forms.TextBox();
            this.lPassword = new System.Windows.Forms.Label();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.lError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conversaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bGenerete
            // 
            this.bGenerete.Location = new System.Drawing.Point(738, 166);
            this.bGenerete.Name = "bGenerete";
            this.bGenerete.Size = new System.Drawing.Size(75, 23);
            this.bGenerete.TabIndex = 0;
            this.bGenerete.Text = "Generate";
            this.bGenerete.UseVisualStyleBackColor = true;
            this.bGenerete.Click += new System.EventHandler(this.bGenerate_Click);
            // 
            // gReport
            // 
            this.gReport.AllowUserToAddRows = false;
            this.gReport.AllowUserToDeleteRows = false;
            this.gReport.AutoGenerateColumns = false;
            this.gReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.fromDataGridViewTextBoxColumn,
            this.toDataGridViewTextBoxColumn,
            this.messageDataGridViewTextBoxColumn});
            this.gReport.DataSource = this.conversaBindingSource;
            this.gReport.Location = new System.Drawing.Point(12, 219);
            this.gReport.Name = "gReport";
            this.gReport.ReadOnly = true;
            this.gReport.Size = new System.Drawing.Size(801, 210);
            this.gReport.TabIndex = 1;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 55;
            // 
            // fromDataGridViewTextBoxColumn
            // 
            this.fromDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fromDataGridViewTextBoxColumn.DataPropertyName = "From";
            this.fromDataGridViewTextBoxColumn.HeaderText = "From";
            this.fromDataGridViewTextBoxColumn.Name = "fromDataGridViewTextBoxColumn";
            this.fromDataGridViewTextBoxColumn.ReadOnly = true;
            this.fromDataGridViewTextBoxColumn.Width = 55;
            // 
            // toDataGridViewTextBoxColumn
            // 
            this.toDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.toDataGridViewTextBoxColumn.DataPropertyName = "To";
            this.toDataGridViewTextBoxColumn.HeaderText = "To";
            this.toDataGridViewTextBoxColumn.Name = "toDataGridViewTextBoxColumn";
            this.toDataGridViewTextBoxColumn.ReadOnly = true;
            this.toDataGridViewTextBoxColumn.Width = 45;
            // 
            // messageDataGridViewTextBoxColumn
            // 
            this.messageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.messageDataGridViewTextBoxColumn.DataPropertyName = "Message";
            this.messageDataGridViewTextBoxColumn.HeaderText = "Message";
            this.messageDataGridViewTextBoxColumn.Name = "messageDataGridViewTextBoxColumn";
            this.messageDataGridViewTextBoxColumn.ReadOnly = true;
            this.messageDataGridViewTextBoxColumn.Width = 75;
            // 
            // conversaBindingSource
            // 
            this.conversaBindingSource.DataSource = typeof(RelatoriosSkype.Models.Conversa);
            // 
            // tFrom
            // 
            this.tFrom.Location = new System.Drawing.Point(80, 36);
            this.tFrom.Name = "tFrom";
            this.tFrom.Size = new System.Drawing.Size(498, 20);
            this.tFrom.TabIndex = 2;
            // 
            // lFrom
            // 
            this.lFrom.AutoSize = true;
            this.lFrom.Location = new System.Drawing.Point(21, 39);
            this.lFrom.Name = "lFrom";
            this.lFrom.Size = new System.Drawing.Size(30, 13);
            this.lFrom.TabIndex = 3;
            this.lFrom.Text = "From";
            // 
            // lTo
            // 
            this.lTo.AutoSize = true;
            this.lTo.Location = new System.Drawing.Point(21, 79);
            this.lTo.Name = "lTo";
            this.lTo.Size = new System.Drawing.Size(20, 13);
            this.lTo.TabIndex = 4;
            this.lTo.Text = "To";
            // 
            // tTo
            // 
            this.tTo.Location = new System.Drawing.Point(80, 75);
            this.tTo.Name = "tTo";
            this.tTo.Size = new System.Drawing.Size(498, 20);
            this.tTo.TabIndex = 5;
            // 
            // tStartDate
            // 
            this.tStartDate.Location = new System.Drawing.Point(674, 36);
            this.tStartDate.Name = "tStartDate";
            this.tStartDate.Size = new System.Drawing.Size(139, 20);
            this.tStartDate.TabIndex = 6;
            this.tStartDate.Text = "2017-01-01";
            this.tStartDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lStartDate
            // 
            this.lStartDate.AutoSize = true;
            this.lStartDate.Location = new System.Drawing.Point(600, 39);
            this.lStartDate.Name = "lStartDate";
            this.lStartDate.Size = new System.Drawing.Size(58, 13);
            this.lStartDate.TabIndex = 7;
            this.lStartDate.Text = "Start Date¹";
            // 
            // lEndDate
            // 
            this.lEndDate.AutoSize = true;
            this.lEndDate.Location = new System.Drawing.Point(600, 79);
            this.lEndDate.Name = "lEndDate";
            this.lEndDate.Size = new System.Drawing.Size(55, 13);
            this.lEndDate.TabIndex = 8;
            this.lEndDate.Text = "End Date¹";
            // 
            // tEndDate
            // 
            this.tEndDate.Location = new System.Drawing.Point(674, 76);
            this.tEndDate.Name = "tEndDate";
            this.tEndDate.Size = new System.Drawing.Size(139, 20);
            this.tEndDate.TabIndex = 9;
            this.tEndDate.Text = "2017-12-31";
            this.tEndDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ldate
            // 
            this.ldate.AutoSize = true;
            this.ldate.Location = new System.Drawing.Point(671, 109);
            this.ldate.Name = "ldate";
            this.ldate.Size = new System.Drawing.Size(142, 13);
            this.ldate.TabIndex = 11;
            this.ldate.Text = "¹ Date format: AAAA-MM-DD";
            // 
            // lServer
            // 
            this.lServer.AutoSize = true;
            this.lServer.Location = new System.Drawing.Point(21, 128);
            this.lServer.Name = "lServer";
            this.lServer.Size = new System.Drawing.Size(84, 13);
            this.lServer.TabIndex = 12;
            this.lServer.Text = "Server\\Instance";
            // 
            // tServer
            // 
            this.tServer.Location = new System.Drawing.Point(111, 125);
            this.tServer.Name = "tServer";
            this.tServer.Size = new System.Drawing.Size(179, 20);
            this.tServer.TabIndex = 13;
            // 
            // lDatabase
            // 
            this.lDatabase.AutoSize = true;
            this.lDatabase.Location = new System.Drawing.Point(21, 166);
            this.lDatabase.Name = "lDatabase";
            this.lDatabase.Size = new System.Drawing.Size(53, 13);
            this.lDatabase.TabIndex = 14;
            this.lDatabase.Text = "Database";
            // 
            // tDatabase
            // 
            this.tDatabase.Location = new System.Drawing.Point(111, 161);
            this.tDatabase.Name = "tDatabase";
            this.tDatabase.Size = new System.Drawing.Size(179, 20);
            this.tDatabase.TabIndex = 15;
            // 
            // lUsername
            // 
            this.lUsername.AutoSize = true;
            this.lUsername.Location = new System.Drawing.Point(338, 128);
            this.lUsername.Name = "lUsername";
            this.lUsername.Size = new System.Drawing.Size(55, 13);
            this.lUsername.TabIndex = 16;
            this.lUsername.Text = "Username";
            // 
            // tUsername
            // 
            this.tUsername.Location = new System.Drawing.Point(399, 128);
            this.tUsername.Name = "tUsername";
            this.tUsername.Size = new System.Drawing.Size(179, 20);
            this.tUsername.TabIndex = 17;
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Location = new System.Drawing.Point(338, 166);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(53, 13);
            this.lPassword.TabIndex = 18;
            this.lPassword.Text = "Password";
            // 
            // tPassword
            // 
            this.tPassword.Location = new System.Drawing.Point(399, 163);
            this.tPassword.Name = "tPassword";
            this.tPassword.Size = new System.Drawing.Size(179, 20);
            this.tPassword.TabIndex = 19;
            this.tPassword.UseSystemPasswordChar = true;
            // 
            // lError
            // 
            this.lError.AutoSize = true;
            this.lError.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lError.ForeColor = System.Drawing.Color.Red;
            this.lError.Location = new System.Drawing.Point(108, 198);
            this.lError.Name = "lError";
            this.lError.Size = new System.Drawing.Size(29, 13);
            this.lError.TabIndex = 20;
            this.lError.Text = "lErro";
            this.lError.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(834, 441);
            this.Controls.Add(this.lError);
            this.Controls.Add(this.tPassword);
            this.Controls.Add(this.lPassword);
            this.Controls.Add(this.tUsername);
            this.Controls.Add(this.lUsername);
            this.Controls.Add(this.tDatabase);
            this.Controls.Add(this.lDatabase);
            this.Controls.Add(this.tServer);
            this.Controls.Add(this.lServer);
            this.Controls.Add(this.ldate);
            this.Controls.Add(this.tEndDate);
            this.Controls.Add(this.lEndDate);
            this.Controls.Add(this.lStartDate);
            this.Controls.Add(this.tStartDate);
            this.Controls.Add(this.tTo);
            this.Controls.Add(this.lTo);
            this.Controls.Add(this.lFrom);
            this.Controls.Add(this.tFrom);
            this.Controls.Add(this.gReport);
            this.Controls.Add(this.bGenerete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(850, 480);
            this.MinimumSize = new System.Drawing.Size(850, 480);
            this.Name = "Form1";
            this.Text = "Skype reporter";
            ((System.ComponentModel.ISupportInitialize)(this.gReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conversaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bGenerete;
        private System.Windows.Forms.DataGridView gReport;
        private System.Windows.Forms.BindingSource conversaBindingSource;
        private System.Windows.Forms.TextBox tFrom;
        private System.Windows.Forms.Label lFrom;
        private System.Windows.Forms.Label lTo;
        private System.Windows.Forms.TextBox tTo;
        private System.Windows.Forms.TextBox tStartDate;
        private System.Windows.Forms.Label lStartDate;
        private System.Windows.Forms.Label lEndDate;
        private System.Windows.Forms.TextBox tEndDate;
        private System.Windows.Forms.Label ldate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lServer;
        private System.Windows.Forms.TextBox tServer;
        private System.Windows.Forms.Label lDatabase;
        private System.Windows.Forms.TextBox tDatabase;
        private System.Windows.Forms.Label lUsername;
        private System.Windows.Forms.TextBox tUsername;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.Label lError;
    }
}

