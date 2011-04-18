namespace RodHowarthAssignment1.Question6
{
    partial class WordnetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordnetForm));
            this.txtFishTagged = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSynonyms = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHypernyms = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTreeTagged = new System.Windows.Forms.TextBox();
            this.nupdLimit = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSeeResults = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupdLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFishTagged
            // 
            this.txtFishTagged.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFishTagged.Location = new System.Drawing.Point(497, 27);
            this.txtFishTagged.Name = "txtFishTagged";
            this.txtFishTagged.Size = new System.Drawing.Size(222, 22);
            this.txtFishTagged.TabIndex = 0;
            this.txtFishTagged.Text = "Question45\\FishTagged.txt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(254, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "POS Tagged Fish File";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Synonyms of Nouns/Adjectives";
            // 
            // txtSynonyms
            // 
            this.txtSynonyms.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSynonyms.Location = new System.Drawing.Point(26, 255);
            this.txtSynonyms.Multiline = true;
            this.txtSynonyms.Name = "txtSynonyms";
            this.txtSynonyms.Size = new System.Drawing.Size(455, 364);
            this.txtSynonyms.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(671, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hypernyms of nouns grouped by sense";
            // 
            // txtHypernyms
            // 
            this.txtHypernyms.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHypernyms.Location = new System.Drawing.Point(569, 255);
            this.txtHypernyms.Multiline = true;
            this.txtHypernyms.Name = "txtHypernyms";
            this.txtHypernyms.Size = new System.Drawing.Size(446, 364);
            this.txtHypernyms.TabIndex = 5;
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(497, 141);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(222, 26);
            this.btnGo.TabIndex = 7;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "POS Tagged Tree File";
            // 
            // txtTreeTagged
            // 
            this.txtTreeTagged.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTreeTagged.Location = new System.Drawing.Point(497, 64);
            this.txtTreeTagged.Name = "txtTreeTagged";
            this.txtTreeTagged.Size = new System.Drawing.Size(222, 22);
            this.txtTreeTagged.TabIndex = 8;
            this.txtTreeTagged.Text = "Question45\\TreeTagged.txt";
            // 
            // nupdLimit
            // 
            this.nupdLimit.Location = new System.Drawing.Point(497, 105);
            this.nupdLimit.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nupdLimit.Name = "nupdLimit";
            this.nupdLimit.Size = new System.Drawing.Size(120, 20);
            this.nupdLimit.TabIndex = 10;
            this.nupdLimit.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(254, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Limit counts (for performance)";
            // 
            // btnSeeResults
            // 
            this.btnSeeResults.Location = new System.Drawing.Point(26, 639);
            this.btnSeeResults.Name = "btnSeeResults";
            this.btnSeeResults.Size = new System.Drawing.Size(263, 23);
            this.btnSeeResults.TabIndex = 12;
            this.btnSeeResults.Text = "See Precompiled Results and Analysis";
            this.btnSeeResults.UseVisualStyleBackColor = true;
            this.btnSeeResults.Click += new System.EventHandler(this.btnSeeResults_Click);
            // 
            // WordnetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 691);
            this.Controls.Add(this.btnSeeResults);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nupdLimit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTreeTagged);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHypernyms);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSynonyms);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFishTagged);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WordnetForm";
            this.Text = "Fish and Tree Analysis";
            ((System.ComponentModel.ISupportInitialize)(this.nupdLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFishTagged;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSynonyms;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHypernyms;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTreeTagged;
        private System.Windows.Forms.NumericUpDown nupdLimit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSeeResults;
    }
}

