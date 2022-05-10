namespace Lab4_SQL
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Insert = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Scalar = new System.Windows.Forms.Button();
            this.Procedure = new System.Windows.Forms.Button();
            this.Transaction = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.Location = new System.Drawing.Point(172, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(626, 451);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(12, 12);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(75, 23);
            this.Insert.TabIndex = 1;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(12, 41);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 2;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(12, 70);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Scalar
            // 
            this.Scalar.Location = new System.Drawing.Point(12, 99);
            this.Scalar.Name = "Scalar";
            this.Scalar.Size = new System.Drawing.Size(75, 23);
            this.Scalar.TabIndex = 4;
            this.Scalar.Text = "Scalar";
            this.Scalar.UseVisualStyleBackColor = true;
            this.Scalar.Click += new System.EventHandler(this.Scalar_Click);
            // 
            // Procedure
            // 
            this.Procedure.Location = new System.Drawing.Point(12, 128);
            this.Procedure.Name = "Procedure";
            this.Procedure.Size = new System.Drawing.Size(75, 23);
            this.Procedure.TabIndex = 5;
            this.Procedure.Text = "Procedure";
            this.Procedure.UseVisualStyleBackColor = true;
            this.Procedure.Click += new System.EventHandler(this.Procedure_Click);
            // 
            // Transaction
            // 
            this.Transaction.Location = new System.Drawing.Point(12, 157);
            this.Transaction.Name = "Transaction";
            this.Transaction.Size = new System.Drawing.Size(75, 23);
            this.Transaction.TabIndex = 6;
            this.Transaction.Text = "Transaction";
            this.Transaction.UseVisualStyleBackColor = true;
            this.Transaction.Click += new System.EventHandler(this.Transaction_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Transaction);
            this.Controls.Add(this.Procedure);
            this.Controls.Add(this.Scalar);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Scalar;
        private System.Windows.Forms.Button Transaction;
        private System.Windows.Forms.Button Procedure;
    }
}

