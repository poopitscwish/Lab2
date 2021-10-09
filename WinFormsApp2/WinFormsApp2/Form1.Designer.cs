
namespace WinFormsApp2
{
    partial class Form1
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
            this.task = new System.Windows.Forms.TextBox();
            this.text1 = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // task
            // 
            this.task.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.task.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.task.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.task.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.task.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.task.Location = new System.Drawing.Point(12, 12);
            this.task.MaxLength = 100;
            this.task.Multiline = true;
            this.task.Name = "task";
            this.task.Size = new System.Drawing.Size(817, 56);
            this.task.TabIndex = 6;
            this.task.Text = "Даны два предложения. Для каждого слова первого предложения определить, входит ли" +
    " оно во второе предложение. Повторяющиеся слова первого предложения не рассматри" +
    "вать.";
            // 
            // text1
            // 
            this.text1.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text1.Location = new System.Drawing.Point(220, 117);
            this.text1.Multiline = true;
            this.text1.Name = "text1";
            this.text1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.text1.Size = new System.Drawing.Size(451, 67);
            this.text1.TabIndex = 1;
            this.text1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text1_KeyPress);
            // 
            // text2
            // 
            this.text2.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text2.Location = new System.Drawing.Point(220, 215);
            this.text2.Multiline = true;
            this.text2.Name = "text2";
            this.text2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.text2.Size = new System.Drawing.Size(451, 67);
            this.text2.TabIndex = 2;
            this.text2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Первое предложение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Второе предложение";
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.SystemColors.Window;
            this.result.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result.Location = new System.Drawing.Point(220, 313);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.result.Size = new System.Drawing.Size(451, 79);
            this.result.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(110, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Результат";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(328, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Doing_Click_1);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(689, 413);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 459);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.task);
            this.Name = "Form1";
            this.Text = "Задача на string";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox task;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

