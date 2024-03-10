using System.Drawing;
using System.Text;

namespace B64_GUI_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool CheckItemsCount()
        {

            if (dragList.Items.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void encButton_Click(object sender, EventArgs e)
        {
            if(!CheckItemsCount())
            {
                MessageBox.Show("Drag the files to encode", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int len = dragList.Items.Count;
            //MessageBox.Show(len.ToString());
            for (int i = 0; i < len; i++)
            {
                string filePath = dragList.Items[i].ToString();
                Byte[] plainBytes = File.ReadAllBytes(filePath);
                String b64Code = Convert.ToBase64String(plainBytes);

                Byte[] codeBytes = Encoding.UTF8.GetBytes(b64Code);
                File.WriteAllBytes(filePath, codeBytes);

            }
            MessageBox.Show("The files are encoded");
            ClearList();
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearList();
        }

        private void ClearList()
        {
            dragList.Items.Clear();

        }

        private void dragList_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void dragList_DragDrop(object sender, DragEventArgs e)
        {
            string[] data = ((string[])e.Data.GetData(DataFormats.FileDrop, false));

            for (int i = 0; i < data.Length; i++)
            {
                dragList.Items.Add(data[i]);
            }
        }

        private void decButton_Click(object sender, EventArgs e)
        {
            if (!CheckItemsCount())
            {
                MessageBox.Show("Drag the files to decode", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int len = dragList.Items.Count;
            for (int i = 0; i < len; i++)
            {
                try
                {
                    string filePath = dragList.Items[i].ToString();
    
                    String strCode = File.ReadAllText(filePath);
                    Byte[] codeBytes = Convert.FromBase64String(strCode);
                    //String b64Plain = BitConverter.ToString(codeBytes, 0, codeBytes.Length);

                    File.WriteAllBytes(filePath, codeBytes);
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("The file is not base64 encrypted","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            MessageBox.Show("The files are decoded");
            ClearList();
        }
    }
}
