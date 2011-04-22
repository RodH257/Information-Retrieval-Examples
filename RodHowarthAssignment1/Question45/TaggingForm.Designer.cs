namespace RodHowarthAssignment1.Question45
{
    partial class TaggingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaggingForm));
            this.txtFishArticle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTreeArticle = new System.Windows.Forms.TextBox();
            this.txtTreeResults = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFishResults = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCombinedRegex = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTreeRegex = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFishRegex = new System.Windows.Forms.TextBox();
            this.btnRunFish = new System.Windows.Forms.Button();
            this.btnRunTree = new System.Windows.Forms.Button();
            this.btnRunCombined = new System.Windows.Forms.Button();
            this.lnklblBrillTagger = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtFishArticle
            // 
            this.txtFishArticle.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtFishArticle.Location = new System.Drawing.Point(359, 28);
            this.txtFishArticle.Margin = new System.Windows.Forms.Padding(4);
            this.txtFishArticle.Name = "txtFishArticle";
            this.txtFishArticle.Size = new System.Drawing.Size(378, 26);
            this.txtFishArticle.TabIndex = 0;
            this.txtFishArticle.Text = "Question45\\FishTagged.txt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Brill Tagged Fish Article";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Brill Tagged Tree Article";
            // 
            // txtTreeArticle
            // 
            this.txtTreeArticle.Location = new System.Drawing.Point(359, 62);
            this.txtTreeArticle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTreeArticle.Name = "txtTreeArticle";
            this.txtTreeArticle.Size = new System.Drawing.Size(378, 26);
            this.txtTreeArticle.TabIndex = 2;
            this.txtTreeArticle.Text = "Question45\\TreeTagged.txt";
            // 
            // txtTreeResults
            // 
            this.txtTreeResults.Location = new System.Drawing.Point(536, 255);
            this.txtTreeResults.Multiline = true;
            this.txtTreeResults.Name = "txtTreeResults";
            this.txtTreeResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTreeResults.Size = new System.Drawing.Size(332, 243);
            this.txtTreeResults.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 225);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Types of Fish";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(645, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Types of Trees";
            // 
            // txtFishResults
            // 
            this.txtFishResults.Location = new System.Drawing.Point(176, 255);
            this.txtFishResults.Multiline = true;
            this.txtFishResults.Name = "txtFishResults";
            this.txtFishResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFishResults.Size = new System.Drawing.Size(332, 243);
            this.txtFishResults.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Combined RegEx";
            // 
            // txtCombinedRegex
            // 
            this.txtCombinedRegex.Location = new System.Drawing.Point(359, 160);
            this.txtCombinedRegex.Margin = new System.Windows.Forms.Padding(4);
            this.txtCombinedRegex.Name = "txtCombinedRegex";
            this.txtCombinedRegex.Size = new System.Drawing.Size(378, 26);
            this.txtCombinedRegex.TabIndex = 8;
            this.txtCombinedRegex.Text = "[a-zA-Z]+(/JJ trees?|fish)/NNS?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 130);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tree RegEx";
            // 
            // txtTreeRegex
            // 
            this.txtTreeRegex.Location = new System.Drawing.Point(359, 126);
            this.txtTreeRegex.Margin = new System.Windows.Forms.Padding(4);
            this.txtTreeRegex.Name = "txtTreeRegex";
            this.txtTreeRegex.Size = new System.Drawing.Size(378, 26);
            this.txtTreeRegex.TabIndex = 10;
            this.txtTreeRegex.Text = "[a-zA-Z]+/JJ trees?/NNS?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(173, 99);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fish RegEx";
            // 
            // txtFishRegex
            // 
            this.txtFishRegex.Location = new System.Drawing.Point(359, 95);
            this.txtFishRegex.Margin = new System.Windows.Forms.Padding(4);
            this.txtFishRegex.Name = "txtFishRegex";
            this.txtFishRegex.Size = new System.Drawing.Size(378, 26);
            this.txtFishRegex.TabIndex = 12;
            this.txtFishRegex.Text = "[a-zA-Z]+fish/NNS?";
            // 
            // btnRunFish
            // 
            this.btnRunFish.Location = new System.Drawing.Point(744, 94);
            this.btnRunFish.Name = "btnRunFish";
            this.btnRunFish.Size = new System.Drawing.Size(124, 27);
            this.btnRunFish.TabIndex = 14;
            this.btnRunFish.Text = "Run Fish";
            this.btnRunFish.UseVisualStyleBackColor = true;
            this.btnRunFish.Click += new System.EventHandler(this.btnRunFish_Click);
            // 
            // btnRunTree
            // 
            this.btnRunTree.Location = new System.Drawing.Point(744, 126);
            this.btnRunTree.Name = "btnRunTree";
            this.btnRunTree.Size = new System.Drawing.Size(124, 27);
            this.btnRunTree.TabIndex = 15;
            this.btnRunTree.Text = "Run Tree";
            this.btnRunTree.UseVisualStyleBackColor = true;
            this.btnRunTree.Click += new System.EventHandler(this.btnRunTree_Click);
            // 
            // btnRunCombined
            // 
            this.btnRunCombined.Location = new System.Drawing.Point(744, 159);
            this.btnRunCombined.Name = "btnRunCombined";
            this.btnRunCombined.Size = new System.Drawing.Size(124, 27);
            this.btnRunCombined.TabIndex = 16;
            this.btnRunCombined.Text = "Run Combined";
            this.btnRunCombined.UseVisualStyleBackColor = true;
            this.btnRunCombined.Click += new System.EventHandler(this.btnRunCombined_Click);
            // 
            // lnklblBrillTagger
            // 
            this.lnklblBrillTagger.AutoSize = true;
            this.lnklblBrillTagger.Location = new System.Drawing.Point(12, 535);
            this.lnklblBrillTagger.Name = "lnklblBrillTagger";
            this.lnklblBrillTagger.Size = new System.Drawing.Size(134, 18);
            this.lnklblBrillTagger.TabIndex = 18;
            this.lnklblBrillTagger.TabStop = true;
            this.lnklblBrillTagger.Text = "Brill Tagger Online";
            this.lnklblBrillTagger.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblBrillTagger_LinkClicked);
            // 
            // TaggingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 574);
            this.Controls.Add(this.lnklblBrillTagger);
            this.Controls.Add(this.btnRunCombined);
            this.Controls.Add(this.btnRunTree);
            this.Controls.Add(this.btnRunFish);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFishRegex);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTreeRegex);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCombinedRegex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFishResults);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTreeResults);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTreeArticle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFishArticle);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TaggingForm";
            this.Text = "TaggingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFishArticle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTreeArticle;
        private System.Windows.Forms.TextBox txtTreeResults;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFishResults;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCombinedRegex;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTreeRegex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFishRegex;
        private System.Windows.Forms.Button btnRunFish;
        private System.Windows.Forms.Button btnRunTree;
        private System.Windows.Forms.Button btnRunCombined;
        private System.Windows.Forms.LinkLabel lnklblBrillTagger;
    }
}