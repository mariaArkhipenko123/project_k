using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kormushka_project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_voyti_Click(object sender, EventArgs e)
        {

        }

        private void addKormushka_Click(object sender, EventArgs e)
        {
            this.Hide();
            TypeForm typeForm = new TypeForm(); 
            typeForm.Show();
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseKormushkaForm chooseKormushkaForm = new ChooseKormushkaForm();
            chooseKormushkaForm.Show();
        }

        private void button_monitoring_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseKormushkaForm chooseKormushkaForm = new ChooseKormushkaForm();
            chooseKormushkaForm.Show();

        }

        private void button_replenish_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseKormushkaForm chooseKormushkaForm = new ChooseKormushkaForm();
            chooseKormushkaForm.Show();
        }
    }
}
