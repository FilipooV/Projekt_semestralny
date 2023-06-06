namespace Projekt
{
    public partial class Form1 : Form
    {
        public static string MyListString;

        public Form1()
        {
            InitializeComponent();



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(43, 115, 111);

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.SelectedItems.Count; i++)
            {
                MyListString = listView1.SelectedItems[i].Text;

            }
            /*ListView.SelectedIndexCollection indexes = listView1.SelectedIndices;
            var GetIndex = listView1.SelectedIndices[0];*/
            /*if (listView1.SelectedItems[0].Selected)
            {
                label2.Text = listView1.SelectedItems[0].Text;
            }*/
        }

        private void poka¿WiêcejToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}