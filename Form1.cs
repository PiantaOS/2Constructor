using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace _2Constructor
{
    public partial class Form1 : Form
    {
        private int _headFontSize;

        private readonly List<Card> _cards = new List<Card>();
        

        private Word.Document _oDoc1;
        private Word.Document _oDoc2;
        private int _labelNum = 0;

        public Form1()
        {
            InitializeComponent();

            this.openFileDialog1.Multiselect = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //Opens the file dialog

            _headFontSize = Convert.ToInt32(numericUpDown1.Value);

            DialogResult result = openFileDialog1.ShowDialog();
            if (result != DialogResult.OK) return;
            foreach (String file in openFileDialog1.FileNames)
            {
                label2.Text = Path.GetFileName(file);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Iterates over selected _cards and copies content into word document

            int count = _oDoc2.Sentences.Count;

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (!checkedListBox1.GetItemChecked(i)) continue;
                int pos = _cards[i].position;
                int iterate = 1;

                while (Convert.ToInt32(_oDoc2.Sentences[pos + iterate].Font.Size) != _headFontSize && pos + iterate + 1 < count)
                {
                    iterate++;
                }
                object startLocation = _oDoc2.Sentences[pos].Start;
                object endLocation = _oDoc2.Sentences[(pos + iterate) - 1].End;
                _cards[i].range = _oDoc2.Range(ref startLocation, ref endLocation);

                _cards[i].range.Copy();
                _oDoc1.Range(_oDoc1.Content.End - 1, _oDoc1.Content.End - 1).Paste();
            }
            saveFileDialog1.Filter = "Word Document|*.docx";
            saveFileDialog1.ShowDialog();
            _oDoc1.SaveAs2(saveFileDialog1.FileName);
            _oDoc2.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            //Iterates over text in document and finds headers with the right font size

            Word.Application oWord = new Word.Application();
            _oDoc2 = oWord.Documents.Open(openFileDialog1.FileName, null, true);
            int count = _oDoc2.Sentences.Count;

            for (int i = 1; i <= count; i++)
            {
                if (Convert.ToInt32(_oDoc2.Sentences[i].Font.Size) == _headFontSize)
                {
                    Card cd = new Card();
                    cd.position = i;
                    _cards.Add(cd);

                    checkedListBox1.Items.Add(_oDoc2.Sentences[i].Text);
                    _labelNum++;
                    label4.Text = _labelNum.ToString();
                }
            }
            _oDoc1 = oWord.Documents.Add();
            oWord.Visible = true;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void openFileDialog1_FileOk(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void saveFileDialog1_FileOk(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        { 
            _headFontSize = Convert.ToInt32(numericUpDown1.Value);
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }
    }

    internal class Card
    {
        public int position { get; set; }
        public Word.Range range { get; set; }
    }
}