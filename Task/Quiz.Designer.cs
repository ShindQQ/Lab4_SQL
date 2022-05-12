namespace Task
{
    partial class Quiz
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
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Task = new System.Windows.Forms.Button();
            this.SaveBrigades = new System.Windows.Forms.Button();
            this.SaveWorker = new System.Windows.Forms.Button();
            this.WB_Create = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView3
            // 
            this.dataGridView3.Location = new System.Drawing.Point(700, 57);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(338, 281);
            this.dataGridView3.TabIndex = 14;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            this.dataGridView3.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView3_UserAddedRow);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Location = new System.Drawing.Point(356, 57);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(338, 281);
            this.dataGridView2.TabIndex = 13;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView2_UserAddedRow);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(12, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(338, 281);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserAddedRow);
            // 
            // Task
            // 
            this.Task.Location = new System.Drawing.Point(12, 18);
            this.Task.Name = "Task";
            this.Task.Size = new System.Drawing.Size(75, 23);
            this.Task.TabIndex = 11;
            this.Task.Text = "Task";
            this.Task.UseVisualStyleBackColor = true;
            this.Task.Click += new System.EventHandler(this.Task_Click);
            // 
            // SaveBrigades
            // 
            this.SaveBrigades.Location = new System.Drawing.Point(12, 369);
            this.SaveBrigades.Name = "SaveBrigades";
            this.SaveBrigades.Size = new System.Drawing.Size(75, 23);
            this.SaveBrigades.TabIndex = 15;
            this.SaveBrigades.Text = "SaveBrigades";
            this.SaveBrigades.UseVisualStyleBackColor = true;
            this.SaveBrigades.Click += new System.EventHandler(this.SaveBrigades_Click);
            // 
            // SaveWorker
            // 
            this.SaveWorker.Location = new System.Drawing.Point(700, 369);
            this.SaveWorker.Name = "SaveWorker";
            this.SaveWorker.Size = new System.Drawing.Size(75, 23);
            this.SaveWorker.TabIndex = 16;
            this.SaveWorker.Text = "SaveWorker";
            this.SaveWorker.UseVisualStyleBackColor = true;
            this.SaveWorker.Click += new System.EventHandler(this.SaveWorker_Click);
            // 
            // WB_Create
            // 
            this.WB_Create.Location = new System.Drawing.Point(356, 369);
            this.WB_Create.Name = "WB_Create";
            this.WB_Create.Size = new System.Drawing.Size(75, 23);
            this.WB_Create.TabIndex = 17;
            this.WB_Create.Text = "WB_Create";
            this.WB_Create.UseVisualStyleBackColor = true;
            this.WB_Create.Click += new System.EventHandler(this.WB_Create_Click);
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 701);
            this.Controls.Add(this.WB_Create);
            this.Controls.Add(this.SaveWorker);
            this.Controls.Add(this.SaveBrigades);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Task);
            this.Name = "Quiz";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Task;
        private System.Windows.Forms.Button SaveBrigades;
        private System.Windows.Forms.Button SaveWorker;
        private System.Windows.Forms.Button WB_Create;
    }
}

