namespace Recipe_Managing_Project_DskApp
{
    partial class AddRecipe
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
            this.clbRestricted = new System.Windows.Forms.CheckedListBox();
            this.clbIntolerances = new System.Windows.Forms.CheckedListBox();
            this.rdrecipe = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.rdComplex = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rdInstruc = new System.Windows.Forms.Label();
            this.rdRestric = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbInstructions = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbIngredients = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clbRestricted
            // 
            this.clbRestricted.FormattingEnabled = true;
            this.clbRestricted.Items.AddRange(new object[] {
            "Dairy",
            "Gluten",
            "Shellfish",
            "Tree Nuts",
            "Soy",
            "Eggs",
            "Peanuts",
            "Seafood",
            "Red Meat"});
            this.clbRestricted.Location = new System.Drawing.Point(186, 91);
            this.clbRestricted.Name = "clbRestricted";
            this.clbRestricted.Size = new System.Drawing.Size(120, 211);
            this.clbRestricted.TabIndex = 0;
            // 
            // clbIntolerances
            // 
            this.clbIntolerances.FormattingEnabled = true;
            this.clbIntolerances.Items.AddRange(new object[] {
            "Lactose",
            "Gluten",
            "Caffeine",
            "Casein",
            "Fructose",
            "MSG",
            "Eggs",
            "Soy",
            "Nuts",
            "Shellfish",
            "Peanuts",
            "Tree-nuts"});
            this.clbIntolerances.Location = new System.Drawing.Point(312, 91);
            this.clbIntolerances.Name = "clbIntolerances";
            this.clbIntolerances.Size = new System.Drawing.Size(120, 280);
            this.clbIntolerances.TabIndex = 1;
            // 
            // rdrecipe
            // 
            this.rdrecipe.AutoSize = true;
            this.rdrecipe.Location = new System.Drawing.Point(33, 30);
            this.rdrecipe.Name = "rdrecipe";
            this.rdrecipe.Size = new System.Drawing.Size(113, 20);
            this.rdrecipe.TabIndex = 2;
            this.rdrecipe.Text = "Recipe Name: ";
            // 
            // tbName
            // 
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Location = new System.Drawing.Point(152, 31);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 19);
            this.tbName.TabIndex = 3;
            // 
            // rdComplex
            // 
            this.rdComplex.AutoSize = true;
            this.rdComplex.Location = new System.Drawing.Point(450, 282);
            this.rdComplex.Name = "rdComplex";
            this.rdComplex.Size = new System.Drawing.Size(85, 20);
            this.rdComplex.TabIndex = 5;
            this.rdComplex.Text = "Complexity";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.listBox1.Location = new System.Drawing.Point(438, 307);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 64);
            this.listBox1.TabIndex = 6;
            // 
            // rdInstruc
            // 
            this.rdInstruc.AutoSize = true;
            this.rdInstruc.Location = new System.Drawing.Point(523, 65);
            this.rdInstruc.Name = "rdInstruc";
            this.rdInstruc.Size = new System.Drawing.Size(92, 20);
            this.rdInstruc.TabIndex = 7;
            this.rdInstruc.Text = "Instructions";
            // 
            // rdRestric
            // 
            this.rdRestric.AutoSize = true;
            this.rdRestric.Location = new System.Drawing.Point(196, 65);
            this.rdRestric.Name = "rdRestric";
            this.rdRestric.Size = new System.Drawing.Size(93, 20);
            this.rdRestric.TabIndex = 8;
            this.rdRestric.Text = "Restrictions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Intolerances";
            // 
            // rtbInstructions
            // 
            this.rtbInstructions.Location = new System.Drawing.Point(438, 91);
            this.rtbInstructions.Name = "rtbInstructions";
            this.rtbInstructions.Size = new System.Drawing.Size(257, 183);
            this.rtbInstructions.TabIndex = 10;
            this.rtbInstructions.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ingredients";
            // 
            // rtbIngredients
            // 
            this.rtbIngredients.Location = new System.Drawing.Point(13, 91);
            this.rtbIngredients.Name = "rtbIngredients";
            this.rtbIngredients.Size = new System.Drawing.Size(167, 211);
            this.rtbIngredients.TabIndex = 12;
            this.rtbIngredients.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 307);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(294, 85);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "EX: Water, 1, Cup; Flour, 0.5, Cup;\nSeparate Name, Amount, and Unit with a comma." +
    "\nSeparate items with a Semicolon.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(594, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 34);
            this.button1.TabIndex = 15;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(594, 358);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 34);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // AddRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 404);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.rtbIngredients);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbInstructions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdRestric);
            this.Controls.Add(this.rdInstruc);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.rdComplex);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.rdrecipe);
            this.Controls.Add(this.clbIntolerances);
            this.Controls.Add(this.clbRestricted);
            this.Name = "AddRecipe";
            this.Text = "Add Recipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbRestricted;
        private System.Windows.Forms.CheckedListBox clbIntolerances;
        private System.Windows.Forms.Label rdrecipe;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label rdComplex;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label rdInstruc;
        private System.Windows.Forms.Label rdRestric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbInstructions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbIngredients;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancel;
    }
}