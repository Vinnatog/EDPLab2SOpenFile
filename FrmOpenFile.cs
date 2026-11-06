namespace EDPLab2SOpenFile
{
    public partial class FrmOpenFile : Form
    {
        public FrmOpenFile()
        {
            InitializeComponent();
        }

        public void DisplayToList()
        {
            openFileDialog1.InitialDirectory = @"C:\Users\Enteng13\source\repos";
            openFileDialog1.Title = "Browse Text Files";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string path = openFileDialog1.FileName;
            lvShowText.Items.Clear();

            try
            {
                // I-setup ang columns (isang beses lang)
                lvShowText.View = View.Details;
                lvShowText.FullRowSelect = true;
                lvShowText.GridLines = true;
                lvShowText.Columns.Clear();
                lvShowText.Columns.Add("Line #", 60);
                lvShowText.Columns.Add("Text", 400);

                // Ipakita sa title ng form kung anong file ang napili
                this.Text = "Selected: " + Path.GetFileName(path);

                using (StreamReader streamReader = File.OpenText(path))
                {
                    string lineText;
                    int lineNumber = 1;

                    while ((lineText = streamReader.ReadLine()) != null)
                    {
                        ListViewItem item = new ListViewItem(lineNumber.ToString());
                        item.SubItems.Add(lineText);
                        lvShowText.Items.Add(item);
                        lineNumber++;
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Cannot read the file.", "File Error");
            }
        }
        private void btnOpen_Click_1(object sender, EventArgs e)
        {
            DisplayToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lvShowText.Items.Clear();
        }
    }
}

