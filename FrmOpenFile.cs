namespace EDPLab2SOpenFile
{
    public partial class FrmOpenFile : Form
    {
        public FrmOpenFile()
        {
            InitializeComponent();
        }
        public void DisplayToList() {
            openFileDialog1.InitialDirectory = @"C:\Users\Enteng13\source\repos";
            openFileDialog1.Title = "Browse Text Files";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string Path = openFileDialog1.FileName;
            lvShowText.Items.Clear();

            try
            {
                using (StreamReader streamReader = File.OpenText(Path))
                {
                    string lineText;
                    while ((lineText = streamReader.ReadLine()) != null)
                    {
                        lvShowText.Items.Add(lineText);
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
    }
    }

