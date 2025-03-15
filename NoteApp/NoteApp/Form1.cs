using System.Data;

namespace NoteApp
{
    public partial class Form1 : Form
    {

        DataTable table;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Messages", typeof(String));


            dataGridView1.DataSource = table;
            dataGridView1.Columns["Messages"].Visible = false;
            dataGridView1.Columns["Title"].Width = 197;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            txtMsg.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txtTitle.Text, txtMsg.Text);

            txtTitle.Clear();
            txtMsg.Clear();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try 
            { 
               int index = dataGridView1.CurrentCell.RowIndex;

               if (index > -1)
               {
                  txtTitle.Text = table.Rows[index].ItemArray[0].ToString();
                  txtMsg.Text = table.Rows[index].ItemArray[1].ToString();
               }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Choose a note first!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                 int index = dataGridView1.CurrentCell.RowIndex;

                 if (index > -1)
                 {
                     txtTitle.Clear();
                     txtMsg.Clear();
                     table.Rows[index].Delete();
                 }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Choose a note first!");
            }
            
        }
    }
}
