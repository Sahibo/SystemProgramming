namespace Fibonacci
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
            this.generate_btn = new System.Windows.Forms.Button();
            this.Stop_btn = new System.Windows.Forms.Button();
            this.fibonacci_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.start_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.end_textbox = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // generate_btn
            // 
            this.generate_btn.Location = new System.Drawing.Point(12, 12);
            this.generate_btn.Name = "generate_btn";
            this.generate_btn.Size = new System.Drawing.Size(228, 58);
            this.generate_btn.TabIndex = 0;
            this.generate_btn.Text = "Generate";
            this.generate_btn.UseVisualStyleBackColor = true;
            this.generate_btn.Click += new System.EventHandler(this.generate_btn_click);
            // 
            // Stop_btn
            // 
            this.Stop_btn.Location = new System.Drawing.Point(652, 12);
            this.Stop_btn.Name = "Stop_btn";
            this.Stop_btn.Size = new System.Drawing.Size(136, 58);
            this.Stop_btn.TabIndex = 1;
            this.Stop_btn.Text = "Stop";
            this.Stop_btn.UseVisualStyleBackColor = true;
            this.Stop_btn.Click += new System.EventHandler(this.Stop_btn_click);
            // 
            // fibonacci_btn
            // 
            this.fibonacci_btn.Location = new System.Drawing.Point(246, 12);
            this.fibonacci_btn.Name = "fibonacci_btn";
            this.fibonacci_btn.Size = new System.Drawing.Size(228, 58);
            this.fibonacci_btn.TabIndex = 2;
            this.fibonacci_btn.Text = "Fibonacci";
            this.fibonacci_btn.UseVisualStyleBackColor = true;
            this.fibonacci_btn.Click += new System.EventHandler(this.fibonacci_btn_click);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(510, 12);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(136, 58);
            this.clear_btn.TabIndex = 3;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_click);
            // 
            // start_textbox
            // 
            this.start_textbox.Location = new System.Drawing.Point(65, 87);
            this.start_textbox.Name = "start_textbox";
            this.start_textbox.Size = new System.Drawing.Size(175, 27);
            this.start_textbox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Start: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "End: ";
            // 
            // end_textbox
            // 
            this.end_textbox.Location = new System.Drawing.Point(299, 87);
            this.end_textbox.Name = "end_textbox";
            this.end_textbox.Size = new System.Drawing.Size(175, 27);
            this.end_textbox.TabIndex = 6;
            // 
            // result
            // 
            this.result.FormattingEnabled = true;
            this.result.ItemHeight = 20;
            this.result.Location = new System.Drawing.Point(510, 90);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(278, 344);
            this.result.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.end_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start_textbox);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.fibonacci_btn);
            this.Controls.Add(this.Stop_btn);
            this.Controls.Add(this.generate_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button generate_btn;
        private Button Stop_btn;
        private Button fibonacci_btn;
        private Button clear_btn;
        private TextBox start_textbox;
        private Label label1;
        private Label label2;
        private TextBox end_textbox;
        private ListBox result;
    }
}