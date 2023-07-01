namespace _2Constructor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CardList = new System.Windows.Forms.CheckedListBox();
            this.HeadFontSizeLabel = new System.Windows.Forms.Label();
            this.FileBrowser = new System.Windows.Forms.OpenFileDialog();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.FileSelectedLabel = new System.Windows.Forms.Label();
            this.FileSaver = new System.Windows.Forms.SaveFileDialog();
            this.LoadCardsButton = new System.Windows.Forms.Button();
            this.CardsLoaded = new System.Windows.Forms.Label();
            this.CardAmountLabel = new System.Windows.Forms.Label();
            this.FontSizeSelector = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.FontSizeSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // CardList
            // 
            this.CardList.CheckOnClick = true;
            this.CardList.FormattingEnabled = true;
            this.CardList.Location = new System.Drawing.Point(9, 115);
            this.CardList.Margin = new System.Windows.Forms.Padding(2);
            this.CardList.Name = "CardList";
            this.CardList.Size = new System.Drawing.Size(136, 484);
            this.CardList.TabIndex = 0;
            this.CardList.SelectedIndexChanged += new System.EventHandler(this.CardList_SelectedIndexChanged);
            // 
            // HeadFontSizeLabel
            // 
            this.HeadFontSizeLabel.AutoSize = true;
            this.HeadFontSizeLabel.Location = new System.Drawing.Point(7, 53);
            this.HeadFontSizeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HeadFontSizeLabel.Name = "HeadFontSizeLabel";
            this.HeadFontSizeLabel.Size = new System.Drawing.Size(120, 15);
            this.HeadFontSizeLabel.TabIndex = 2;
            this.HeadFontSizeLabel.Text = "Card Head Font Size";
            // 
            // FileBrowser
            // 
            this.FileBrowser.FileName = "FileSelector";
            this.FileBrowser.FileOk += new System.ComponentModel.CancelEventHandler(this.FileBrowser_FileOk);
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(9, 620);
            this.GenerateButton.Margin = new System.Windows.Forms.Padding(2);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(136, 19);
            this.GenerateButton.TabIndex = 3;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(9, 26);
            this.BrowseButton.Margin = new System.Windows.Forms.Padding(2);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(136, 19);
            this.BrowseButton.TabIndex = 4;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // FileSelectedLabel
            // 
            this.FileSelectedLabel.AutoSize = true;
            this.FileSelectedLabel.Location = new System.Drawing.Point(7, 11);
            this.FileSelectedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FileSelectedLabel.Name = "FileSelectedLabel";
            this.FileSelectedLabel.Size = new System.Drawing.Size(97, 15);
            this.FileSelectedLabel.TabIndex = 5;
            this.FileSelectedLabel.Text = "No File Selected";
            this.FileSelectedLabel.Click += new System.EventHandler(this.FileSelectedLabel_Click);
            // 
            // FileSaver
            // 
            this.FileSaver.FileOk += new System.ComponentModel.CancelEventHandler(this.FileSaver_FileOk);
            // 
            // LoadCardsButton
            // 
            this.LoadCardsButton.Location = new System.Drawing.Point(9, 91);
            this.LoadCardsButton.Margin = new System.Windows.Forms.Padding(2);
            this.LoadCardsButton.Name = "LoadCardsButton";
            this.LoadCardsButton.Size = new System.Drawing.Size(136, 19);
            this.LoadCardsButton.TabIndex = 8;
            this.LoadCardsButton.Text = "Confirm";
            this.LoadCardsButton.UseVisualStyleBackColor = true;
            this.LoadCardsButton.Click += new System.EventHandler(this.LoadCardsButton_Click);
            // 
            // CardsLoaded
            // 
            this.CardsLoaded.AutoSize = true;
            this.CardsLoaded.Location = new System.Drawing.Point(9, 641);
            this.CardsLoaded.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CardsLoaded.Name = "CardsLoaded";
            this.CardsLoaded.Size = new System.Drawing.Size(87, 15);
            this.CardsLoaded.TabIndex = 9;
            this.CardsLoaded.Text = "Cards Loaded:";
            // 
            // CardAmountLabel
            // 
            this.CardAmountLabel.AutoSize = true;
            this.CardAmountLabel.Location = new System.Drawing.Point(86, 641);
            this.CardAmountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CardAmountLabel.Name = "CardAmountLabel";
            this.CardAmountLabel.Size = new System.Drawing.Size(14, 15);
            this.CardAmountLabel.TabIndex = 10;
            this.CardAmountLabel.Text = "0";
            this.CardAmountLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // FontSizeSelector
            // 
            this.FontSizeSelector.Location = new System.Drawing.Point(9, 68);
            this.FontSizeSelector.Margin = new System.Windows.Forms.Padding(2);
            this.FontSizeSelector.Name = "FontSizeSelector";
            this.FontSizeSelector.Size = new System.Drawing.Size(136, 20);
            this.FontSizeSelector.TabIndex = 11;
            this.FontSizeSelector.Value = new decimal(new int[] { 16, 0, 0, 0 });
            this.FontSizeSelector.ValueChanged += new System.EventHandler(this.FontSizeSelector_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(151, 655);
            this.Controls.Add(this.FontSizeSelector);
            this.Controls.Add(this.CardAmountLabel);
            this.Controls.Add(this.CardsLoaded);
            this.Controls.Add(this.LoadCardsButton);
            this.Controls.Add(this.FileSelectedLabel);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.HeadFontSizeLabel);
            this.Controls.Add(this.CardList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(169, 702);
            this.MinimumSize = new System.Drawing.Size(169, 702);
            this.Name = "Form1";
            this.Text = "2Constructor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FontSizeSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.SaveFileDialog FileSaver;

        #endregion

        private System.Windows.Forms.CheckedListBox CardList;
        private System.Windows.Forms.Label HeadFontSizeLabel;
        private System.Windows.Forms.OpenFileDialog FileBrowser;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Label FileSelectedLabel;
        private System.Windows.Forms.SaveFileDialog SaveFile;
        private System.Windows.Forms.Button LoadCardsButton;
        private System.Windows.Forms.Label CardsLoaded;
        private System.Windows.Forms.Label CardAmountLabel;
        private System.Windows.Forms.NumericUpDown FontSizeSelector;
    }
}

