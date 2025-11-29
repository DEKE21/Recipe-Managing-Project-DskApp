namespace Recipe_Managing_Project_DskApp
{
    partial class recipeloader
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dvgResults = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.lstbDetails = new System.Windows.Forms.ListBox();
            this.btnback = new System.Windows.Forms.Button();
            this.txtInstructions = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgResults)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recipe Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(539, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Instructions";
            // 
            // dvgResults
            // 
            this.dvgResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgResults.Location = new System.Drawing.Point(12, 67);
            this.dvgResults.Name = "dvgResults";
            this.dvgResults.RowHeadersWidth = 51;
            this.dvgResults.RowTemplate.Height = 24;
            this.dvgResults.Size = new System.Drawing.Size(176, 301);
            this.dvgResults.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Recipes";
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.Location = new System.Drawing.Point(588, 421);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(100, 23);
            this.btnViewDetails.TabIndex = 6;
            this.btnViewDetails.Text = "&View Details";
            this.btnViewDetails.UseVisualStyleBackColor = true;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // lstbDetails
            // 
            this.lstbDetails.FormattingEnabled = true;
            this.lstbDetails.ItemHeight = 16;
            this.lstbDetails.Location = new System.Drawing.Point(283, 67);
            this.lstbDetails.Name = "lstbDetails";
            this.lstbDetails.Size = new System.Drawing.Size(140, 292);
            this.lstbDetails.TabIndex = 7;
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(472, 421);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 8;
            this.btnback.Text = "B&ack";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // txtInstructions
            // 
            this.txtInstructions.Location = new System.Drawing.Point(525, 67);
            this.txtInstructions.Multiline = true;
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.Size = new System.Drawing.Size(138, 283);
            this.txtInstructions.TabIndex = 9;
            // 
            // recipeloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 467);
            this.Controls.Add(this.txtInstructions);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.lstbDetails);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dvgResults);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "recipeloader";
            this.Text = "recipeloader";
            ((System.ComponentModel.ISupportInitialize)(this.dvgResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dvgResults;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.ListBox lstbDetails;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.TextBox txtInstructions;
    }
}