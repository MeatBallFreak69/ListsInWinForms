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
            IstNumbers.DataSource = numbers;
        }

        private void btnNewHeroes_Click(object sender, EventArgs e)
        {
            heroes.Clear();
        }
    }
}
