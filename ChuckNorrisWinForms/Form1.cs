using ChuckNorrisAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuckNorrisWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateCategoriesAsync();
        }
        private async void PopulateCategoriesAsync()
        {
            var categories = await ChuckNorrisClient.GetCategories();

            foreach (var category in categories)
            {
                filterCbx.Items.Add(category);
            }
        }

        private async void generateBtn_Click(object sender, EventArgs e)
        {
            Joke j = await ChuckNorrisClient.GetRandomJoke();
            MessageBox.Show(j.JokeText);
        }


    }
}
