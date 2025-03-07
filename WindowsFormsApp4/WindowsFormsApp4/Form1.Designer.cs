namespace WindowsFormsApp4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.question_text = new System.Windows.Forms.TextBox();
            this.solution_textbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.solution_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // question_text
            // 
            this.question_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.question_text.Location = new System.Drawing.Point(54, 51);
            this.question_text.Multiline = true;
            this.question_text.Name = "question_text";
            this.question_text.Size = new System.Drawing.Size(286, 61);
            this.question_text.TabIndex = 0;
            this.question_text.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // solution_textbox
            // 
            this.solution_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.solution_textbox.Location = new System.Drawing.Point(54, 162);
            this.solution_textbox.Multiline = true;
            this.solution_textbox.Name = "solution_textbox";
            this.solution_textbox.Size = new System.Drawing.Size(153, 50);
            this.solution_textbox.TabIndex = 1;
            this.solution_textbox.Text = "0";
            this.solution_textbox.TextChanged += new System.EventHandler(this.solution_textbox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(440, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button2.Location = new System.Drawing.Point(440, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "คำนวณ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // solution_label
            // 
            this.solution_label.AutoSize = true;
            this.solution_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.solution_label.ForeColor = System.Drawing.Color.Red;
            this.solution_label.Location = new System.Drawing.Point(365, 181);
            this.solution_label.Name = "solution_label";
            this.solution_label.Size = new System.Drawing.Size(29, 31);
            this.solution_label.TabIndex = 3;
            this.solution_label.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.solution_label);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.solution_textbox);
            this.Controls.Add(this.question_text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox question_text;
        private System.Windows.Forms.TextBox solution_textbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label solution_label;
    }
}

