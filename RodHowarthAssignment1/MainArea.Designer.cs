namespace RodHowarthAssignment1
{
    partial class MainArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainArea));
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuestion1 = new System.Windows.Forms.Button();
            this.btnQuestion23 = new System.Windows.Forms.Button();
            this.btnQuestion6 = new System.Windows.Forms.Button();
            this.btnQuestion45 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(566, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rod Howarth - INB344 Assignment 1";
            // 
            // btnQuestion1
            // 
            this.btnQuestion1.Location = new System.Drawing.Point(181, 117);
            this.btnQuestion1.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuestion1.Name = "btnQuestion1";
            this.btnQuestion1.Size = new System.Drawing.Size(534, 36);
            this.btnQuestion1.TabIndex = 1;
            this.btnQuestion1.Text = "1. Stemmer False Positive + False Negative examples (Tut1Q4)";
            this.btnQuestion1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuestion1.UseVisualStyleBackColor = true;
            this.btnQuestion1.Click += new System.EventHandler(this.btnQuestion1_Click);
            // 
            // btnQuestion23
            // 
            this.btnQuestion23.Location = new System.Drawing.Point(181, 172);
            this.btnQuestion23.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuestion23.Name = "btnQuestion23";
            this.btnQuestion23.Size = new System.Drawing.Size(534, 36);
            this.btnQuestion23.TabIndex = 2;
            this.btnQuestion23.Text = "2 + 3 - Stemming (Tut2Q1-3)";
            this.btnQuestion23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuestion23.UseVisualStyleBackColor = true;
            this.btnQuestion23.Click += new System.EventHandler(this.btnQuestion23_Click);
            // 
            // btnQuestion6
            // 
            this.btnQuestion6.Location = new System.Drawing.Point(181, 279);
            this.btnQuestion6.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuestion6.Name = "btnQuestion6";
            this.btnQuestion6.Size = new System.Drawing.Size(534, 36);
            this.btnQuestion6.TabIndex = 5;
            this.btnQuestion6.Text = "6. Use Wordnet to expand nouns with their synonyms and hypernyms";
            this.btnQuestion6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuestion6.UseVisualStyleBackColor = true;
            this.btnQuestion6.Click += new System.EventHandler(this.btnQuestion6_Click);
            // 
            // btnQuestion45
            // 
            this.btnQuestion45.Location = new System.Drawing.Point(181, 224);
            this.btnQuestion45.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuestion45.Name = "btnQuestion45";
            this.btnQuestion45.Size = new System.Drawing.Size(534, 36);
            this.btnQuestion45.TabIndex = 4;
            this.btnQuestion45.Text = "4 +5. Use Brill POS Tagger and Regular Expression to extract information";
            this.btnQuestion45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuestion45.UseVisualStyleBackColor = true;
            this.btnQuestion45.Click += new System.EventHandler(this.btnQuestion45_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(763, 407);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 32);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 473);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnQuestion6);
            this.Controls.Add(this.btnQuestion45);
            this.Controls.Add(this.btnQuestion23);
            this.Controls.Add(this.btnQuestion1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainArea";
            this.Text = "INB344 Assignment 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuestion1;
        private System.Windows.Forms.Button btnQuestion23;
        private System.Windows.Forms.Button btnQuestion6;
        private System.Windows.Forms.Button btnQuestion45;
        private System.Windows.Forms.Button btnExit;
    }
}

