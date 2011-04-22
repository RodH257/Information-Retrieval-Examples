namespace RodHowarthAssignment1.Question23
{
    partial class StemmingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StemmingForm));
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnEnglishStem = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnFrenchStem = new System.Windows.Forms.Button();
            this.txtFinalText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDetectLanguage = new System.Windows.Forms.Button();
            this.btnEnglishSample = new System.Windows.Forms.Button();
            this.btnFrenchSample = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(79, 32);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInput.Size = new System.Drawing.Size(834, 229);
            this.txtInput.TabIndex = 0;
            // 
            // btnEnglishStem
            // 
            this.btnEnglishStem.Location = new System.Drawing.Point(175, 267);
            this.btnEnglishStem.Name = "btnEnglishStem";
            this.btnEnglishStem.Size = new System.Drawing.Size(191, 37);
            this.btnEnglishStem.TabIndex = 1;
            this.btnEnglishStem.Text = "Stem in English, showing steps";
            this.btnEnglishStem.UseVisualStyleBackColor = true;
            this.btnEnglishStem.Click += new System.EventHandler(this.btnEnglishStem_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(43, 365);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(404, 314);
            this.txtOutput.TabIndex = 2;
            // 
            // btnFrenchStem
            // 
            this.btnFrenchStem.Location = new System.Drawing.Point(386, 267);
            this.btnFrenchStem.Name = "btnFrenchStem";
            this.btnFrenchStem.Size = new System.Drawing.Size(191, 37);
            this.btnFrenchStem.TabIndex = 3;
            this.btnFrenchStem.Text = "Stem in French";
            this.btnFrenchStem.UseVisualStyleBackColor = true;
            this.btnFrenchStem.Click += new System.EventHandler(this.btnFrenchStem_Click);
            // 
            // txtFinalText
            // 
            this.txtFinalText.Location = new System.Drawing.Point(483, 365);
            this.txtFinalText.Multiline = true;
            this.txtFinalText.Name = "txtFinalText";
            this.txtFinalText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFinalText.Size = new System.Drawing.Size(548, 314);
            this.txtFinalText.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(624, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Final text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Stemmed Words";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Input Text";
            // 
            // btnDetectLanguage
            // 
            this.btnDetectLanguage.Location = new System.Drawing.Point(593, 267);
            this.btnDetectLanguage.Name = "btnDetectLanguage";
            this.btnDetectLanguage.Size = new System.Drawing.Size(190, 37);
            this.btnDetectLanguage.TabIndex = 8;
            this.btnDetectLanguage.Text = "Detect language";
            this.btnDetectLanguage.UseVisualStyleBackColor = true;
            this.btnDetectLanguage.Click += new System.EventHandler(this.btnDetectLanguage_Click);
            // 
            // btnEnglishSample
            // 
            this.btnEnglishSample.Location = new System.Drawing.Point(919, 51);
            this.btnEnglishSample.Name = "btnEnglishSample";
            this.btnEnglishSample.Size = new System.Drawing.Size(126, 23);
            this.btnEnglishSample.TabIndex = 9;
            this.btnEnglishSample.Text = "English Sample Text";
            this.btnEnglishSample.UseVisualStyleBackColor = true;
            this.btnEnglishSample.Click += new System.EventHandler(this.btnEnglishSample_Click);
            // 
            // btnFrenchSample
            // 
            this.btnFrenchSample.Location = new System.Drawing.Point(919, 80);
            this.btnFrenchSample.Name = "btnFrenchSample";
            this.btnFrenchSample.Size = new System.Drawing.Size(126, 23);
            this.btnFrenchSample.TabIndex = 10;
            this.btnFrenchSample.Text = "French Sample Text";
            this.btnFrenchSample.UseVisualStyleBackColor = true;
            this.btnFrenchSample.Click += new System.EventHandler(this.btnFrenchSample_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(789, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "(need to stem in English and French first)";
            // 
            // StemmingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 753);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnFrenchSample);
            this.Controls.Add(this.btnEnglishSample);
            this.Controls.Add(this.btnDetectLanguage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFinalText);
            this.Controls.Add(this.btnFrenchStem);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnEnglishStem);
            this.Controls.Add(this.txtInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StemmingForm";
            this.Text = "Stemming Functions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnEnglishStem;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnFrenchStem;
        private System.Windows.Forms.TextBox txtFinalText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDetectLanguage;
        private System.Windows.Forms.Button btnEnglishSample;
        private System.Windows.Forms.Button btnFrenchSample;
        private System.Windows.Forms.Label label4;
    }
}

