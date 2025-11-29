using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Xml.Linq;
using System.IO;
namespace Recipe_Managing_Project_DskApp
{
    public partial class recipeloader : Form
    {
        public List<string> Ingredients { get; set; }
        public List<string> Instructions { get; set; }
        public List<string> Intolerances { get; set; }
       
        public recipeloader()
        {
            InitializeComponent();
        }
        
        private void recipeloader_Load(object sender, EventArgs e)
        {
           string xmlpath = Path.Combine(Application.StartupPath, "DB", "dataFile.xml");
            var allrecipes = recipeloader.LoadRecipes(xmlpath);

            var filteredRecipes = allrecipes.Where(r =>
                (Ingredients.All(i => r.Ingredients.Contains(i))) &&
                !r.Ingredients.Any(i => Intolerances.Contains(i)) &&
                (Intolerances.Count == 0 || !r.Intolerances.Any(i => Intolerances.Contains(i)))
                ).ToList();

            dvgResults.DataSource = filteredRecipes;

            lstIngredients.Items.Clear();
            foreach (var ing in recipe.Ingredients) 
                {
                lstIngredients.Items.Add(ing);
            }

            txtInstructions.Text = recipe.Instructions;
        }
        private void dvgResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
               var recipe =(recipeloader)dvgResults.Rows[e.RowIndex].DataBoundItem;
                
            }
        }
        private void btnViewDetails_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
