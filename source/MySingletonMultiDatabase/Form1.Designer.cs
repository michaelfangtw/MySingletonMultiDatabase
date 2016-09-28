namespace MySingletonMultiDatabase
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dbname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Category = new System.Windows.Forms.Button();
            this.Conn = new System.Windows.Forms.Button();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pidCustomer = new System.Windows.Forms.Label();
            this.pidCategory = new System.Windows.Forms.Label();
            this.pidConn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dbname,
            this.count,
            this.login});
            this.dataGridView2.Location = new System.Drawing.Point(12, 358);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(772, 180);
            this.dataGridView2.TabIndex = 4;
            // 
            // dbname
            // 
            this.dbname.DataPropertyName = "dbname";
            this.dbname.HeaderText = "dbname";
            this.dbname.Name = "dbname";
            this.dbname.ReadOnly = true;
            // 
            // count
            // 
            this.count.DataPropertyName = "count";
            this.count.HeaderText = "count";
            this.count.Name = "count";
            this.count.ReadOnly = true;
            // 
            // login
            // 
            this.login.DataPropertyName = "login";
            this.login.HeaderText = "login";
            this.login.Name = "login";
            this.login.ReadOnly = true;
            // 
            // Customer
            // 
            this.Customer.Location = new System.Drawing.Point(13, 12);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(75, 23);
            this.Customer.TabIndex = 0;
            this.Customer.Text = "Customer";
            this.Customer.UseVisualStyleBackColor = true;
            this.Customer.Click += new System.EventHandler(this.Customer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(771, 237);
            this.dataGridView1.TabIndex = 1;
            // 
            // Category
            // 
            this.Category.Location = new System.Drawing.Point(323, 12);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(75, 23);
            this.Category.TabIndex = 2;
            this.Category.Text = "Category";
            this.Category.UseVisualStyleBackColor = true;
            this.Category.Click += new System.EventHandler(this.Category_Click);
            // 
            // Conn
            // 
            this.Conn.Location = new System.Drawing.Point(12, 329);
            this.Conn.Name = "Conn";
            this.Conn.Size = new System.Drawing.Size(75, 23);
            this.Conn.TabIndex = 3;
            this.Conn.Text = "Conn";
            this.Conn.UseVisualStyleBackColor = true;
            this.Conn.Click += new System.EventHandler(this.Conn_Click);
            // 
            // pidCustomer
            // 
            this.pidCustomer.AutoSize = true;
            this.pidCustomer.Location = new System.Drawing.Point(94, 20);
            this.pidCustomer.Name = "pidCustomer";
            this.pidCustomer.Size = new System.Drawing.Size(79, 15);
            this.pidCustomer.TabIndex = 5;
            this.pidCustomer.Text = "pidCustomer";
            // 
            // pidCategory
            // 
            this.pidCategory.AutoSize = true;
            this.pidCategory.Location = new System.Drawing.Point(404, 20);
            this.pidCategory.Name = "pidCategory";
            this.pidCategory.Size = new System.Drawing.Size(76, 15);
            this.pidCategory.TabIndex = 6;
            this.pidCategory.Text = "pidCategory";
            // 
            // pidConn
            // 
            this.pidConn.AutoSize = true;
            this.pidConn.Location = new System.Drawing.Point(93, 333);
            this.pidConn.Name = "pidConn";
            this.pidConn.Size = new System.Drawing.Size(55, 15);
            this.pidConn.TabIndex = 7;
            this.pidConn.Text = "pidConn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 559);
            this.Controls.Add(this.pidConn);
            this.Controls.Add(this.pidCategory);
            this.Controls.Add(this.pidCustomer);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.Conn);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Customer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Customer;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Category;
        private System.Windows.Forms.Button Conn;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbname;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label pidCustomer;
        private System.Windows.Forms.Label pidCategory;
        private System.Windows.Forms.Label pidConn;
    }
}

