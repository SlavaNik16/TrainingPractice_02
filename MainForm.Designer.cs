namespace TrainingPractice_02
{
    partial class MainForm
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
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.butStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCount
            // 
            this.txtCount.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCount.Location = new System.Drawing.Point(118, 55);
            this.txtCount.Multiline = true;
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(61, 42);
            this.txtCount.TabIndex = 0;
            this.txtCount.TextChanged += new System.EventHandler(this.txtCount_TextChanged);
            this.txtCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCount_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Укажите размер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(58, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "2 < ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(182, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = " < 17";
            // 
            // butStart
            // 
            this.butStart.BackColor = System.Drawing.Color.Cyan;
            this.butStart.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butStart.Location = new System.Drawing.Point(103, 111);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(88, 36);
            this.butStart.TabIndex = 4;
            this.butStart.Text = "Играть";
            this.butStart.UseVisualStyleBackColor = false;
            this.butStart.Click += new System.EventHandler(this.butStart_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 151);
            this.Controls.Add(this.butStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCount);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butStart;
    }
}

