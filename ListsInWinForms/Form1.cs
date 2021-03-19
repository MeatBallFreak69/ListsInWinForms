using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListsInWinForms
{
    public partial class frmUsingLists : Form
    {
        List<int> numbers = new List<int>();
        List<string> heroes = new List<string>();
        Random generator = new Random();
        bool upperCase = false;
        bool lowerCase = false;
        public frmUsingLists()
        {
            InitializeComponent();
        }

        private void frmUsingLists_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
                numbers.Add(generator.Next(100));
            IstNumbers.DataSource = numbers;
            heroes.Add("Superman");
            heroes.Add("Batman");
            IstHeroes.DataSource = heroes;
        }

        private void BtnSortNumbers_Click(object sender, EventArgs e)
        {
            numbers.Sort();
            IstNumbers.DataSource = null;
            IstNumbers.DataSource = numbers;
            lblStatus.Text = "Status: numbers sorted";
        }

        private void btnSortHeroes_Click(object sender, EventArgs e)
        {
            heroes.Sort();
            IstHeroes.DataSource = null;
            IstHeroes.DataSource = heroes;
            lblStatus.Text = "Status: heroes sorted";
        }

        private void btnNewNumbers_Click(object sender, EventArgs e)
        {
            numbers.Clear();
            for (int i = 0; i < 20; i++)
                numbers.Add(generator.Next(100));
            IstNumbers.DataSource = null;
            IstNumbers.DataSource = numbers;
            lblStatus.Text = "Status: new numbers list";
        }

        private void btnNewHeroes_Click(object sender, EventArgs e)
        {
            heroes.Clear();
            heroes.Add("Superman");
            heroes.Add("Batman");
            IstHeroes.DataSource = null;
            IstHeroes.DataSource = heroes;
            lblStatus.Text = "Status: new heroes list";
        }

        private void btnRemoveNumber_Click(object sender, EventArgs e)
        {
            if (IstNumbers.SelectedIndex != -1)
            {
                numbers.RemoveAt(IstNumbers.SelectedIndex);
                lblStatus.Text = "Status: item removed";
                IstNumbers.DataSource = null;
                IstNumbers.DataSource = numbers;
            }
            else
            {
                lblStatus.Text = "Status: no item selected";
            }
        }

        private void btnRemoveAllNumbers_Click(object sender, EventArgs e)
        {
            int itemsRemoved = 0;
            itemsRemoved = numbers.Count;
            for (int i = numbers.Count - 1; i >= 0; i--)
                numbers.RemoveAt(i);          
            IstNumbers.DataSource = null;
            IstNumbers.DataSource = numbers;
            lblStatus.Text = $"{itemsRemoved} Items were removed";           
        }

        private void btnRemoveHero_Click(object sender, EventArgs e)
        {
            char[] charsToTrim = { '*', ' ', '\'' };
            string removeHero = txtRemoveHero.Text.Trim(charsToTrim);
            if (heroes.Contains(removeHero))
            {
                heroes.Remove(removeHero);
                IstHeroes.DataSource = null;
                IstHeroes.DataSource = heroes;
                lblStatus.Text = $"Status: removed {removeHero} from heroes list";
                txtRemoveHero.Text = " ";
            }
            else
            {
                lblStatus.Text = "Please enter a valid hero";
            }
        }

        private void btmAddHero_Click(object sender, EventArgs e)
        {
            char[] charsToTrim = { '*', ' ', '\'' };
            string addHero = txtAddHero.Text.Trim(charsToTrim);
            if (string.IsNullOrWhiteSpace(addHero))
            {
                lblStatus.Text = "Status: Please enter anything other than a space";
            }
            else if (heroes.Contains(addHero))
            {
                lblStatus.Text = $"Status: Please enter a new hero, you entered {addHero}";
            }
            else
            {
                heroes.Add(addHero);
                lblStatus.Text = $"Status: Entered a hero named: {addHero}";
                txtAddHero.Text = " ";
                IstHeroes.DataSource = null;
                IstHeroes.DataSource = heroes;
            }
        }

        private void btnUppercase_Click(object sender, EventArgs e)
        {
            upperCase = true
            heroes = heroes.ConvertAll(d => d.ToUpper());
            IstHeroes.DataSource = null;
            IstHeroes.DataSource = heroes;

        }

        private void btnLowercase_Click(object sender, EventArgs e)
        {
            heroes = heroes.ConvertAll(d => d.ToLower());
            IstHeroes.DataSource = null;
            IstHeroes.DataSource = heroes;
        }

        private void btnSortDown_Click(object sender, EventArgs e)
        {
            numbers.Sort((a, b) => b.CompareTo(a));
            IstNumbers.DataSource = null;
            IstNumbers.DataSource = numbers;
        }

        private void btnSortHeroesDown_Click(object sender, EventArgs e)
        {
            heroes.Sort((a, b) => b.CompareTo(a));
            IstHeroes.DataSource = null;
            IstHeroes.DataSource = heroes;
        }
    }
}
