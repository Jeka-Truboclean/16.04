using System.Windows.Forms;

namespace _16._04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                textBox1.AppendText(listBox1.SelectedItem.ToString() + Environment.NewLine);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Item 1");
            listBox1.Items.Add("Item 2");
            listBox1.Items.Add("Item 3");
            listBox1.Items.Add("Item 4");
        }
    }
}
