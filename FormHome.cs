using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Room_Click(object sender, EventArgs e)
        {
            FormC formC = new FormC();
            formC.Show();
            this.Hide();
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            State formState = new State();
            formState.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            District formD = new District();
            formD.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            City formC = new City();
            formC.Show();
            this.Hide();
        }

        private void Employee_Click(object sender, EventArgs e)
        {
            Customer formC = new Customer();
            formC.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Employee formC = new Employee();
            formC.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Designation designation = new Designation();
            designation.Show();
            this.Hide();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {

        }
    }
}
