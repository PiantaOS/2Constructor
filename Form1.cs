using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace _2Constructor
{
    
    
    
    
    //Move functions from form1 to processor
    public partial class Form1 : Form
    {
        private int _headerFontSize;

        private readonly List<Card> _cards = new List<Card>();

        private Word.Document _originalDocument;
        private Word.Document _finalDocument;
        
        private int _amountCardsLoaded = 0;

        private readonly int _linesToSkip = 2;


        
        

        public Form1()
        {
            InitializeComponent();

            this.FileBrowser.Multiselect = true;
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            GetFiles();
        }
        
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            CreateDocument();
        }

        
        private void LoadCardsButton_Click(object sender, EventArgs e)
        {
            LocateHeaders();
        }

        
        private void FontSizeSelector_ValueChanged(object sender, EventArgs e)
        { 
            UpdateHeaderFontSize(Convert.ToInt32(FontSizeSelector.Value));
        }
        
        public void LocateHeaders() {
            
            Word.Application wordApplication = new Word.Application();
            
            _originalDocument = wordApplication.Documents.Open(FileBrowser.FileName, null, true); //openfile diaglog file name into var please
            
            int sentenceCount = _originalDocument.Sentences.Count;

            for (int i = 1; i <= sentenceCount; i++)
            {
                if(Convert.ToInt32(_originalDocument.Sentences[i].Font.Size) != _headerFontSize) { continue; } //Problem here
                
                Card card = new Card();
                card.position = i;
                _cards.Add(card);

                _amountCardsLoaded++;
                CardsLoaded.Text = _amountCardsLoaded.ToString();
                i += _linesToSkip; //var name indescriptive
                
                CardList.Items.Add(_originalDocument.Sentences[i].Text);
                
            }
            _finalDocument = wordApplication.Documents.Add();
            wordApplication.Visible = true; //Making this false might be better

        }
        public void CreateDocument() {
            int sentencesAmount = _originalDocument.Sentences.Count;

            for (int i = 0; i < CardList.Items.Count; i++)
            {
                if (CardList.GetItemChecked(i) == false) continue;
                
                int sentenceIndex = _cards[i].position;
                int positionInCard = 1;

                int currentPosition = sentenceIndex + positionInCard;
                int nextPosition = currentPosition + 1;
=======

                int currentSentenceFontSize = Convert.ToInt32(_originalDocument.Sentences[currentPosition].Font.Size);

                while (currentSentenceFontSize != _headerFontSize && nextPosition < sentencesAmount)
                {
                    positionInCard++;
                }
                
                object startLocation = _originalDocument.Sentences[sentenceIndex].Start;
                object endLocation = _originalDocument.Sentences[nextPosition - 1].End;
                
                _cards[i].range = _originalDocument.Range(ref startLocation, ref endLocation);
                _cards[i].range.Copy();
                
                _finalDocument.Range(_finalDocument.Content.End - 1, _finalDocument.Content.End - 1).Paste();
            }
            
            SaveFile.Filter = "Word Document|*.docx";
            SaveFile.ShowDialog();
            
            _finalDocument.SaveAs2(SaveFile.FileName);
            _originalDocument.Close();
        }
        public void UpdateHeaderFontSize(int newSize) {
            _headerFontSize = newSize;
        }
        private void GetFiles() {
            _headerFontSize = Convert.ToInt32(FontSizeSelector.Value);

            DialogResult result = FileBrowser.ShowDialog();
            
            if (result != DialogResult.OK) return;
            
            foreach (String file in FileBrowser.FileNames)
            {
                FileSelectedLabel.Text = Path.GetFileName(file);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void CardList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void FileBrowser_FileOk(object sender, EventArgs e)
        {
        }

        private void FileSelectedLabel_Click(object sender, EventArgs e)
        {
        }

        private void FileSaver_FileOk(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }


    internal class Card
    {
        public int position { get; set; } //tf does this variable mean
        public Word.Range range { get; set; }
    }
}