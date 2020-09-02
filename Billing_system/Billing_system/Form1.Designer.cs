namespace Billing_system
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DATA_Abonent = new System.Windows.Forms.DataGridView();
            this.Add_abonent = new System.Windows.Forms.Button();
            this.Edit_abonent = new System.Windows.Forms.Button();
            this.Delete_abonent = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DATA_Abonent)).BeginInit();
            this.SuspendLayout();
            // 
            // DATA_Abonent
            // 
            this.DATA_Abonent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DATA_Abonent.Location = new System.Drawing.Point(16, 15);
            this.DATA_Abonent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DATA_Abonent.Name = "DATA_Abonent";
            this.DATA_Abonent.Size = new System.Drawing.Size(581, 396);
            this.DATA_Abonent.TabIndex = 0;
            this.DATA_Abonent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DATA_Abonent_CellContentClick);
            // 
            // Add_abonent
            // 
            this.Add_abonent.Location = new System.Drawing.Point(36, 443);
            this.Add_abonent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Add_abonent.Name = "Add_abonent";
            this.Add_abonent.Size = new System.Drawing.Size(147, 47);
            this.Add_abonent.TabIndex = 1;
            this.Add_abonent.Text = "Добавить абонента";
            this.Add_abonent.UseVisualStyleBackColor = true;
            this.Add_abonent.Click += new System.EventHandler(this.Add_abonent_Click);
            // 
            // Edit_abonent
            // 
            this.Edit_abonent.Location = new System.Drawing.Point(36, 507);
            this.Edit_abonent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Edit_abonent.Name = "Edit_abonent";
            this.Edit_abonent.Size = new System.Drawing.Size(147, 47);
            this.Edit_abonent.TabIndex = 2;
            this.Edit_abonent.Text = "Редактировать абонента";
            this.Edit_abonent.UseVisualStyleBackColor = true;
            this.Edit_abonent.Click += new System.EventHandler(this.Edit_abonent_Click_1);
            // 
            // Delete_abonent
            // 
            this.Delete_abonent.Location = new System.Drawing.Point(36, 572);
            this.Delete_abonent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Delete_abonent.Name = "Delete_abonent";
            this.Delete_abonent.Size = new System.Drawing.Size(147, 47);
            this.Delete_abonent.TabIndex = 3;
            this.Delete_abonent.Text = "Удалить абонента";
            this.Delete_abonent.UseVisualStyleBackColor = true;
            this.Delete_abonent.Click += new System.EventHandler(this.Delete_abonent_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 443);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Выписать счёт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 665);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Delete_abonent);
            this.Controls.Add(this.Edit_abonent);
            this.Controls.Add(this.Add_abonent);
            this.Controls.Add(this.DATA_Abonent);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DATA_Abonent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DATA_Abonent;
        private System.Windows.Forms.Button Add_abonent;
        private System.Windows.Forms.Button Edit_abonent;
        private System.Windows.Forms.Button Delete_abonent;
        private System.Windows.Forms.Button button1;
    }
}

