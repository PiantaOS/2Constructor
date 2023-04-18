using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace _2Constructor
{
    public partial class Form1 : Form
    {
        private int headFontSize;

        private List<Card> cards = new List<Card>();

        private Word.Document oDoc1;
        private Word.Document oDoc2;
        private int labelNum = 0;

        private int accuracy = 2;

        public Form1()
        {
            InitializeComponent();

            this.openFileDialog1.Multiselect = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Opens the file dialog

            headFontSize = Convert.ToInt32(numericUpDown1.Value);

            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                foreach (String file in openFileDialog1.FileNames)
                {
                    label2.Text = Path.GetFileName(file);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Iterates over selected cards and copies content into word document

            int count = oDoc2.Sentences.Count;

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    int pos = cards[i].position;
                    int iterate = 1;

                    while (oDoc2.Sentences[pos + iterate].Font.Size != headFontSize && pos + iterate + 1 < count)
                    {
                        iterate++;
                    }
                    object startLocation = oDoc2.Sentences[pos].Start;
                    object endLocation = oDoc2.Sentences[(pos + iterate) - 1].End;
                    cards[i].range = oDoc2.Range(ref startLocation, ref endLocation);

                    cards[i].range.Copy();
                    oDoc1.Range(oDoc1.Content.End - 1, oDoc1.Content.End - 1).Paste();
                }
            }
            saveFileDialog1.Filter = "Word Document|*.docx";
            saveFileDialog1.ShowDialog();
            oDoc1.SaveAs2(saveFileDialog1.FileName);
            oDoc2.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            //Iterates over text in document and finds headers with the right font size

            Word.Application oWord = new Word.Application();
            oDoc2 = oWord.Documents.Open(openFileDialog1.FileName, null, true);
            int count = oDoc2.Sentences.Count;

            for (int i = 1; i <= count; i++)
            {
                if (oDoc2.Sentences[i].Font.Size == headFontSize)
                {
                    Card cd = new Card();
                    cd.position = i;
                    cards.Add(cd);

                    checkedListBox1.Items.Add(oDoc2.Sentences[i].Text);

                    labelNum++;
                    label4.Text = labelNum.ToString();

                    i += accuracy;
                }
            }
            oDoc1 = oWord.Documents.Add();
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
            headFontSize = Convert.ToInt32(numericUpDown1.Value);
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