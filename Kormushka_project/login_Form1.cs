using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Kormushka_project
{
    public partial class login_Form1 : Form
    {
        public login_Form1()
        {
            InitializeComponent();
            this.lock_pole.AutoSize = false;
            this.lock_pole.Size = new Size(this.user_pole.Size.Width,53);
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //кнопка войти
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void close_button_Click(object sender, EventArgs e)
        {
             Application.Exit();
        }

        private void close_button_MouseEnter(object sender, EventArgs e)
        {
            close_button.ForeColor=Color.Black;
        }

        private void close_button_MouseLeave(object sender, EventArgs e)
        {
            close_button.ForeColor = Color.White;
        }
        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
  

            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button_voyti_Click(object sender, EventArgs e)
        {
            String loginUser = user_pole.Text;
            String passUser = lock_pole.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `userscats` WHERE `login` = @uL AND `password` =@uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                 MainForm mainForm = new MainForm();    
                mainForm.Show();
            }
            else
                MessageBox.Show("No");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void user_pole_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void registorLable_Click(object sender, EventArgs e)
        {
            this.Hide();    
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            
        }
    }
}
