namespace _02_StrategyPattern
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Ok = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.label_Price = new System.Windows.Forms.Label();
            this.label_Num = new System.Windows.Forms.Label();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.textBox_Num = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label_Aggregate = new System.Windows.Forms.Label();
            this.label_Result = new System.Windows.Forms.Label();
            this.label_CaculMode = new System.Windows.Forms.Label();
            this.comboBox_Mode = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button_Ok
            // 
            this.button_Ok.Location = new System.Drawing.Point(219, 25);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(75, 23);
            this.button_Ok.TabIndex = 0;
            this.button_Ok.Text = "确定";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(219, 66);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(75, 23);
            this.button_Reset.TabIndex = 1;
            this.button_Reset.Text = "重置";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.Location = new System.Drawing.Point(24, 30);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(41, 12);
            this.label_Price.TabIndex = 2;
            this.label_Price.Text = "单价：";
            // 
            // label_Num
            // 
            this.label_Num.AutoSize = true;
            this.label_Num.Location = new System.Drawing.Point(24, 71);
            this.label_Num.Name = "label_Num";
            this.label_Num.Size = new System.Drawing.Size(41, 12);
            this.label_Num.TabIndex = 3;
            this.label_Num.Text = "数量：";
            // 
            // textBox_Price
            // 
            this.textBox_Price.Location = new System.Drawing.Point(90, 25);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(107, 21);
            this.textBox_Price.TabIndex = 4;
            this.textBox_Price.Text = "0.00";
            this.textBox_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_Num
            // 
            this.textBox_Num.Location = new System.Drawing.Point(90, 66);
            this.textBox_Num.Name = "textBox_Num";
            this.textBox_Num.Size = new System.Drawing.Size(107, 21);
            this.textBox_Num.TabIndex = 5;
            this.textBox_Num.Text = "0";
            this.textBox_Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.SystemColors.Window;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 12;
            this.listBox.Location = new System.Drawing.Point(42, 154);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(252, 100);
            this.listBox.TabIndex = 6;
            // 
            // label_Aggregate
            // 
            this.label_Aggregate.AutoSize = true;
            this.label_Aggregate.Location = new System.Drawing.Point(40, 269);
            this.label_Aggregate.Name = "label_Aggregate";
            this.label_Aggregate.Size = new System.Drawing.Size(41, 12);
            this.label_Aggregate.TabIndex = 7;
            this.label_Aggregate.Text = "总计：";
            // 
            // label_Result
            // 
            this.label_Result.AutoSize = true;
            this.label_Result.Font = new System.Drawing.Font("宋体", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Result.Location = new System.Drawing.Point(113, 288);
            this.label_Result.Name = "label_Result";
            this.label_Result.Size = new System.Drawing.Size(97, 40);
            this.label_Result.TabIndex = 8;
            this.label_Result.Text = "0.00";
            this.label_Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_CaculMode
            // 
            this.label_CaculMode.AutoSize = true;
            this.label_CaculMode.Location = new System.Drawing.Point(25, 112);
            this.label_CaculMode.Name = "label_CaculMode";
            this.label_CaculMode.Size = new System.Drawing.Size(65, 12);
            this.label_CaculMode.TabIndex = 10;
            this.label_CaculMode.Text = "计算方式：";
            // 
            // comboBox_Mode
            // 
            this.comboBox_Mode.FormattingEnabled = true;
            this.comboBox_Mode.Location = new System.Drawing.Point(90, 109);
            this.comboBox_Mode.Name = "comboBox_Mode";
            this.comboBox_Mode.Size = new System.Drawing.Size(107, 20);
            this.comboBox_Mode.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 346);
            this.Controls.Add(this.comboBox_Mode);
            this.Controls.Add(this.label_CaculMode);
            this.Controls.Add(this.label_Result);
            this.Controls.Add(this.label_Aggregate);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.textBox_Num);
            this.Controls.Add(this.textBox_Price);
            this.Controls.Add(this.label_Num);
            this.Controls.Add(this.label_Price);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button_Ok);
            this.Name = "Form1";
            this.Text = "商务收银系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.Label label_Num;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.TextBox textBox_Num;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label_Aggregate;
        private System.Windows.Forms.Label label_Result;
        private System.Windows.Forms.Label label_CaculMode;
        private System.Windows.Forms.ComboBox comboBox_Mode;
    }
}

