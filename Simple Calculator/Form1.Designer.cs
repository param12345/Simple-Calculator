
namespace Simple_Calculator
{
    partial class Simple_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_FirstNum = new System.Windows.Forms.Label();
            this.FirstNum_Text = new System.Windows.Forms.TextBox();
            this.label_SecondNum = new System.Windows.Forms.Label();
            this.SecondNum_Text = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Label();
            this.Result_Text = new System.Windows.Forms.TextBox();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_FirstNum
            // 
            this.label_FirstNum.AutoSize = true;
            this.label_FirstNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label_FirstNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_FirstNum.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_FirstNum.Location = new System.Drawing.Point(62, 70);
            this.label_FirstNum.Name = "label_FirstNum";
            this.label_FirstNum.Size = new System.Drawing.Size(138, 30);
            this.label_FirstNum.TabIndex = 0;
            this.label_FirstNum.Text = "First Number";
            // 
            // FirstNum_Text
            // 
            this.FirstNum_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstNum_Text.Location = new System.Drawing.Point(320, 70);
            this.FirstNum_Text.Name = "FirstNum_Text";
            this.FirstNum_Text.Size = new System.Drawing.Size(292, 31);
            this.FirstNum_Text.TabIndex = 1;
            // 
            // label_SecondNum
            // 
            this.label_SecondNum.AutoSize = true;
            this.label_SecondNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label_SecondNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_SecondNum.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_SecondNum.Location = new System.Drawing.Point(62, 144);
            this.label_SecondNum.Name = "label_SecondNum";
            this.label_SecondNum.Size = new System.Drawing.Size(165, 30);
            this.label_SecondNum.TabIndex = 2;
            this.label_SecondNum.Text = "Second Number";
            // 
            // SecondNum_Text
            // 
            this.SecondNum_Text.Location = new System.Drawing.Point(320, 144);
            this.SecondNum_Text.Name = "SecondNum_Text";
            this.SecondNum_Text.Size = new System.Drawing.Size(292, 31);
            this.SecondNum_Text.TabIndex = 3;
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Result.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Result.Location = new System.Drawing.Point(96, 234);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(73, 30);
            this.Result.TabIndex = 4;
            this.Result.Text = "Result";
            // 
            // Result_Text
            // 
            this.Result_Text.Location = new System.Drawing.Point(320, 233);
            this.Result_Text.Name = "Result_Text";
            this.Result_Text.Size = new System.Drawing.Size(292, 31);
            this.Result_Text.TabIndex = 5;
            // 
            // Btn_Add
            // 
            this.Btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Btn_Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Add.Location = new System.Drawing.Point(124, 304);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(112, 34);
            this.Btn_Add.TabIndex = 6;
            this.Btn_Add.Text = "Add";
            this.Btn_Add.UseVisualStyleBackColor = false;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Location = new System.Drawing.Point(311, 292);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(112, 34);
            this.Btn_Clear.TabIndex = 7;
            this.Btn_Clear.Text = "clear";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Simple_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.Result_Text);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.SecondNum_Text);
            this.Controls.Add(this.label_SecondNum);
            this.Controls.Add(this.FirstNum_Text);
            this.Controls.Add(this.label_FirstNum);
            this.Name = "Simple_Form";
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_FirstNum;
        private System.Windows.Forms.TextBox FirstNum_Text;
        private System.Windows.Forms.Label label_SecondNum;
        private System.Windows.Forms.TextBox SecondNum_Text;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.TextBox Result_Text;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button Btn_Clear;
    }
}

