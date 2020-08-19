namespace FirstFormsApplication
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
            this.components = new System.ComponentModel.Container();
            this.tbNum1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbNum2 = new System.Windows.Forms.TextBox();
            this.tbOption = new System.Windows.Forms.TextBox();
            this.btnResults = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNum1
            // 
            this.tbNum1.Location = new System.Drawing.Point(121, 93);
            this.tbNum1.Name = "tbNum1";
            this.tbNum1.Size = new System.Drawing.Size(100, 31);
            this.tbNum1.TabIndex = 0;
            this.tbNum1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbNum2
            // 
            this.tbNum2.Location = new System.Drawing.Point(249, 93);
            this.tbNum2.Name = "tbNum2";
            this.tbNum2.Size = new System.Drawing.Size(100, 31);
            this.tbNum2.TabIndex = 2;
            // 
            // tbOption
            // 
            this.tbOption.Location = new System.Drawing.Point(364, 93);
            this.tbOption.Name = "tbOption";
            this.tbOption.Size = new System.Drawing.Size(100, 31);
            this.tbOption.TabIndex = 3;
            // 
            // btnResults
            // 
            this.btnResults.Location = new System.Drawing.Point(507, 204);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(118, 40);
            this.btnResults.TabIndex = 4;
            this.btnResults.Text = "Do Math!";
            this.btnResults.UseVisualStyleBackColor = true;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(526, 286);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(70, 25);
            this.lblResults.TabIndex = 5;
            this.lblResults.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnResults);
            this.Controls.Add(this.tbOption);
            this.Controls.Add(this.tbNum2);
            this.Controls.Add(this.tbNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNum1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbNum2;
        private System.Windows.Forms.TextBox tbOption;
        private System.Windows.Forms.Button btnResults;
        private System.Windows.Forms.Label lblResults;
    }
}

