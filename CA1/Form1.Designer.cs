namespace CA1
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
            this.lbArray = new System.Windows.Forms.Label();
            this.tbArray = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.lbF = new System.Windows.Forms.Label();
            this.tbF = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbArray
            // 
            this.lbArray.AutoSize = true;
            this.lbArray.Location = new System.Drawing.Point(13, 15);
            this.lbArray.Name = "lbArray";
            this.lbArray.Size = new System.Drawing.Size(33, 13);
            this.lbArray.TabIndex = 0;
            this.lbArray.Text = "array:";
            // 
            // tbArray
            // 
            this.tbArray.BackColor = System.Drawing.Color.White;
            this.tbArray.Location = new System.Drawing.Point(53, 12);
            this.tbArray.Name = "tbArray";
            this.tbArray.Size = new System.Drawing.Size(195, 20);
            this.tbArray.TabIndex = 1;
            this.tbArray.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbArray_KeyPress);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(16, 42);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 24);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.Color.White;
            this.btnRandom.Location = new System.Drawing.Point(127, 42);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(105, 24);
            this.btnRandom.TabIndex = 3;
            this.btnRandom.Text = "rand";
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // tbResult
            // 
            this.tbResult.BackColor = System.Drawing.Color.White;
            this.tbResult.Location = new System.Drawing.Point(68, 72);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(275, 20);
            this.tbResult.TabIndex = 5;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(12, 75);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(50, 13);
            this.lbResult.TabIndex = 4;
            this.lbResult.Text = "RESULT";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(238, 42);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(105, 24);
            this.btnFind.TabIndex = 6;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lbF
            // 
            this.lbF.AutoSize = true;
            this.lbF.Location = new System.Drawing.Point(260, 15);
            this.lbF.Name = "lbF";
            this.lbF.Size = new System.Drawing.Size(16, 13);
            this.lbF.TabIndex = 7;
            this.lbF.Text = "F:";
            // 
            // tbF
            // 
            this.tbF.BackColor = System.Drawing.Color.White;
            this.tbF.Location = new System.Drawing.Point(282, 12);
            this.tbF.Name = "tbF";
            this.tbF.Size = new System.Drawing.Size(61, 20);
            this.tbF.TabIndex = 8;
            this.tbF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbF_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(357, 110);
            this.Controls.Add(this.tbF);
            this.Controls.Add(this.lbF);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tbArray);
            this.Controls.Add(this.lbArray);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Task 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbArray;
        private System.Windows.Forms.TextBox tbArray;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lbF;
        private System.Windows.Forms.TextBox tbF;
    }
}

