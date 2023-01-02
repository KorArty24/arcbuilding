namespace WindowsFormsApp1
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
            this.Span = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Height = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.N_Panels = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.offset = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Span
            // 
            this.Span.Location = new System.Drawing.Point(160, 31);
            this.Span.Name = "Span";
            this.Span.Size = new System.Drawing.Size(127, 20);
            this.Span.TabIndex = 0;
            this.Span.TextChanged += new System.EventHandler(this.Span_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Arc span";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // Height
            // 
            this.Height.Location = new System.Drawing.Point(160, 72);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(127, 20);
            this.Height.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Arc height";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Build";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // N_Panels
            // 
            this.N_Panels.Location = new System.Drawing.Point(160, 154);
            this.N_Panels.Name = "N_Panels";
            this.N_Panels.Size = new System.Drawing.Size(127, 20);
            this.N_Panels.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Number of panels N/2";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // offset
            // 
            this.offset.Location = new System.Drawing.Point(160, 111);
            this.offset.Name = "offset";
            this.offset.Size = new System.Drawing.Size(127, 20);
            this.offset.TabIndex = 0;
            this.offset.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inner radius offset";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 282);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.N_Panels);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Span);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.offset);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Span;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Height;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox N_Panels;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox offset;
        private System.Windows.Forms.Label label1;
    }
}

