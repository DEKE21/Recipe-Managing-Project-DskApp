namespace Recipe_Managing_Project_DskApp
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
            this.label5 = new System.Windows.Forms.Label();
            this.clbRestricted = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cblIntolerances = new System.Windows.Forms.CheckedListBox();
            this.lstIngredients = new System.Windows.Forms.ListBox();
            this.btn_Addingredient = new System.Windows.Forms.Button();
            this.txtIngredient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.recipeListing = new System.Windows.Forms.ListView();
            this.recipeloaderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.recipeloaderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Restricted Foods";
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
            "Red meat"});
            this.clbRestricted.Location = new System.Drawing.Point(427, 63);
            this.clbRestricted.Margin = new System.Windows.Forms.Padding(2);
            this.clbRestricted.Name = "clbRestricted";
            this.clbRestricted.Size = new System.Drawing.Size(128, 157);
            this.clbRestricted.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(602, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Dietary Intolerences";
            // 
            // cblIntolerances
            // 
            this.cblIntolerances.FormattingEnabled = true;
            this.cblIntolerances.Items.AddRange(new object[] {
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
            "Tree nuts"});
            this.cblIntolerances.Location = new System.Drawing.Point(578, 63);
            this.cblIntolerances.Margin = new System.Windows.Forms.Padding(2);
            this.cblIntolerances.Name = "cblIntolerances";
            this.cblIntolerances.Size = new System.Drawing.Size(132, 157);
            this.cblIntolerances.TabIndex = 23;
            // 
            // lstIngredients
            // 
            this.lstIngredients.FormattingEnabled = true;
            this.lstIngredients.Location = new System.Drawing.Point(176, 101);
            this.lstIngredients.Margin = new System.Windows.Forms.Padding(2);
            this.lstIngredients.Name = "lstIngredients";
            this.lstIngredients.Size = new System.Drawing.Size(102, 134);
            this.lstIngredients.TabIndex = 22;
            // 
            // btn_Addingredient
            // 
            this.btn_Addingredient.Location = new System.Drawing.Point(182, 58);
            this.btn_Addingredient.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Addingredient.Name = "btn_Addingredient";
            this.btn_Addingredient.Size = new System.Drawing.Size(94, 20);
            this.btn_Addingredient.TabIndex = 21;
            this.btn_Addingredient.Text = "&Add Ingredient";
            this.btn_Addingredient.UseVisualStyleBackColor = true;
            this.btn_Addingredient.Click += new System.EventHandler(this.btn_Addingredient_Click);
            // 
            // txtIngredient
            // 
            this.txtIngredient.Location = new System.Drawing.Point(182, 35);
            this.txtIngredient.Margin = new System.Windows.Forms.Padding(2);
            this.txtIngredient.Name = "txtIngredient";
            this.txtIngredient.Size = new System.Drawing.Size(96, 20);
            this.txtIngredient.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ingredient List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Recipes Displayed Here";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(566, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Substitution and Health Section";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(647, 339);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(56, 24);
            this.btn_Search.TabIndex = 16;
            this.btn_Search.Text = "&Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(552, 340);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(56, 22);
            this.btn_cancel.TabIndex = 15;
            this.btn_cancel.Text = "&Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // recipeListing
            // 
            this.recipeListing.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.recipeListing.AutoArrange = false;
            this.recipeListing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.recipeListing.GridLines = true;
            this.recipeListing.HideSelection = false;
            this.recipeListing.LabelWrap = false;
            this.recipeListing.Location = new System.Drawing.Point(8, 35);
            this.recipeListing.MultiSelect = false;
            this.recipeListing.Name = "recipeListing";
            this.recipeListing.ShowGroups = false;
            this.recipeListing.Size = new System.Drawing.Size(121, 313);
            this.recipeListing.TabIndex = 27;
            this.recipeListing.UseCompatibleStateImageBehavior = false;
            this.recipeListing.View = System.Windows.Forms.View.List;
            // 
            // recipeloaderBindingSource
            // 
            this.recipeloaderBindingSource.DataSource = typeof(Recipe_Managing_Project_DskApp.recipeloader);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 385);
            this.Controls.Add(this.recipeListing);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clbRestricted);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cblIntolerances);
            this.Controls.Add(this.lstIngredients);
            this.Controls.Add(this.btn_Addingredient);
            this.Controls.Add(this.txtIngredient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_cancel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Calhoun CookBook";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recipeloaderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox clbRestricted;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox cblIntolerances;
        private System.Windows.Forms.ListBox lstIngredients;
        private System.Windows.Forms.Button btn_Addingredient;
        private System.Windows.Forms.TextBox txtIngredient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.BindingSource recipeloaderBindingSource;
        private System.Windows.Forms.ListView recipeListing;
    }
}

