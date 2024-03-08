using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(Box1.Text);
            int m = Convert.ToInt32(Box2.Text);
            label7.Text = (n + m).ToString();
            label8.Text = (n - m).ToString();
            label9.Text = (n * m).ToString();
            label10.Text = (n / m).ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) 
        { 
          bool userConfirmedExit = false;

        // Hiển thị MessageBox để xác nhận việc thoát
        DialogResult result = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            // Kiểm tra phản hồi của người dùng
            if (result == DialogResult.OK)
            {
                // Người dùng đã xác nhận thoát
                userConfirmedExit = true;
            }

            // Kiểm tra biến bool và thoát khỏi ứng dụng nếu người dùng đã xác nhận
            if (userConfirmedExit)
            {
                Application.Exit();
            }
        }

    }
}
