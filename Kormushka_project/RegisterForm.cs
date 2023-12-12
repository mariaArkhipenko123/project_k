using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Kormushka_project
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            userNameField.Text = "Введите имя";
            userSurnameField.Text = "Фамилия";

            userNameField.ForeColor = Color.Gray;
            userSurnameField.ForeColor = Color.Gray;
        }

        private void button_voyti_Click(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введите имя")
            {
                MessageBox.Show("Введите имя");
                return;
            }

            if (userSurnameField.Text == "Введите Фамилию")
            {
                MessageBox.Show("Введите Фамилию");
                return;
            }

            if (isUserExist())
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `userscats` ( `login`, `password`, `name`, `surname`) VALUES ( '@login', '@pass', '@name', '@surname')", db.getConnection());
       
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = user_pole.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = lock_pole.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userNameField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = userSurnameField.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт был создан");
            else
                MessageBox.Show("Аккаун не был создан");


            db.closeConnection();


        }

        public Boolean isUserExist()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `userscats` WHERE `login` = @uL ", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = user_pole.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Логин занят");
                return true;
            }
      
            else
                return false;
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        Point lastPoint;
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;


            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void userNameField_Enter(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введите имя")
            {
                userNameField.Text = "";
            }
        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
            {
                userNameField.Text = "Введите имя";

                userNameField.ForeColor = Color.Gray;
            }
            }

        private void userSurnameField_Enter(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "Фамилия")
            {
                userSurnameField.Text = "";
            }
        }

        private void userSurnameField_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
            {
                userSurnameField.Text = "Фамилия";

                userSurnameField.ForeColor = Color.Gray;
            }
        }

        private void registorLable_Click(object sender, EventArgs e)
        {
            this.Hide();
            login_Form1 login_Form1 = new login_Form1();
            login_Form1.Show();
        }
    }
}
