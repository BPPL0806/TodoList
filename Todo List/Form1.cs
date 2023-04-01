namespace Todo_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Length > 0)
            {
                list.Items.Add(textBox.Text);
            }
        }

        private void clean_Click(object sender, EventArgs e)
        {
            for (int i = list.Items.Count - 1; i >= 0; i--)
            {
                if (list.GetItemChecked(i))
                {
                    list.Items.RemoveAt(i);
                }
            }
        }
    }
}