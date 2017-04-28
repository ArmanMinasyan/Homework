using System;
using System.Windows.Forms;
using System.Threading;
namespace DbFilter
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Loger.Reset();
        }
        /// <summary>
        /// button for delete table if it exists
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Loger.Reset();
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread thr = new Thread(Loger.AddLog);
            thr.Start();
           
        }
        /// <summary>
        /// buuton for get logs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private  void button3_Click(object sender, EventArgs e)

        {
            dataGridView1.DataSource = Loger.Getlog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// buuton for filter search
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Filter.Filterer(textBox1, textBox2, textBox3);
        }
    }
}