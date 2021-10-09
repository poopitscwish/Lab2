
namespace WinFormsApp2
{
    partial class task1
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
            this.penny = new System.Windows.Forms.NumericUpDown();
            this.doing = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.task = new System.Windows.Forms.TextBox();
            this.inputhere = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.penny)).BeginInit();
            this.SuspendLayout();
            // 
            // penny
            // 
            this.penny.AllowDrop = true;
            this.penny.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.penny.Location = new System.Drawing.Point(132, 97);
            this.penny.Margin = new System.Windows.Forms.Padding(4);
            this.penny.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.penny.Name = "penny";
            this.penny.Size = new System.Drawing.Size(150, 25);
            this.penny.TabIndex = 1;
            this.penny.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.penny.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.penny.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Penny_KeyUp);
            // 
            // doing
            // 
            this.doing.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.doing.Location = new System.Drawing.Point(181, 203);
            this.doing.Margin = new System.Windows.Forms.Padding(2);
            this.doing.Name = "doing";
            this.doing.Size = new System.Drawing.Size(177, 26);
            this.doing.TabIndex = 2;
            this.doing.Text = "Перевод";
            this.doing.UseMnemonic = false;
            this.doing.UseVisualStyleBackColor = true;
            this.doing.Click += new System.EventHandler(this.Doing_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Стоимость";
            // 
            // task
            // 
            this.task.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.task.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.task.Cursor = System.Windows.Forms.Cursors.Default;
            this.task.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.task.ForeColor = System.Drawing.SystemColors.WindowText;
            this.task.Location = new System.Drawing.Point(13, 13);
            this.task.Margin = new System.Windows.Forms.Padding(4);
            this.task.Multiline = true;
            this.task.Name = "task";
            this.task.ReadOnly = true;
            this.task.Size = new System.Drawing.Size(515, 68);
            this.task.TabIndex = 6;
            this.task.Text = "Дано натуральное число 1≤n≤9999, определяющее стоимость товара в копейках. Вырази" +
    "ть стоимость в рублях и копейках, например, 3 рубля 21 копейка, 15 рублей 5 копе" +
    "ек, 1 рубль ровно и т. п.";
            // 
            // inputhere
            // 
            this.inputhere.AutoSize = true;
            this.inputhere.Location = new System.Drawing.Point(13, 86);
            this.inputhere.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inputhere.Name = "inputhere";
            this.inputhere.Size = new System.Drawing.Size(111, 34);
            this.inputhere.TabIndex = 8;
            this.inputhere.Text = "Исходная сумма \r\n      (коп.)";
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.SystemColors.HighlightText;
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.result.Location = new System.Drawing.Point(132, 148);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(150, 18);
            this.result.TabIndex = 3;
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clear
            // 
            this.clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clear.Location = new System.Drawing.Point(430, 204);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(83, 26);
            this.clear.TabIndex = 4;
            this.clear.Text = "Очистить";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(106F, 106F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(523, 238);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.result);
            this.Controls.Add(this.inputhere);
            this.Controls.Add(this.task);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.doing);
            this.Controls.Add(this.penny);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "Задача на if";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.penny)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button doing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox task;
        private System.Windows.Forms.Label inputhere;
        private System.Windows.Forms.TextBox result;
        public System.Windows.Forms.NumericUpDown penny;
        private System.Windows.Forms.Button clear;
    }
}

