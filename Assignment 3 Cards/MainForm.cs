using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Assignment_3_Cards
{
    public partial class MainForm : Form
    {
        //List to represent a deck of cards
        List<int> deckList = new List<int>();

        //Array to store hand of 5 cards
        int[] handArray = new int[5];

        //PictureBox and CheckBox arrays
        PictureBox[] pictureBoxes;
        CheckBox[] keepCheckBoxes;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ShuffleDeck()
        {
            //Clear the deck
            deckList.Clear();
            for (int i = 0; i < imageList1.Images.Count; i++)
            {
                //Add cards to the deck list
                deckList.Add(i);
            }

            Random rnd = new Random();
            int n = deckList.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                int value = deckList[k];
                deckList[k] = deckList[n];
                deckList[n] = value;
            }
        }

        private void Card1pictureBox_Click(object sender, EventArgs e)
        {
            Keep1checkBox.Checked = !Keep1checkBox.Checked;
        }

        private void Card2pictureBox_Click(object sender, EventArgs e)
        {
            Keep2checkBox.Checked = !Keep2checkBox.Checked;
        }

        private void Card3pictureBox_Click(object sender, EventArgs e)
        {
            Keep3checkBox.Checked = !Keep3checkBox.Checked;
        }

        private void Card4pictureBox_Click(object sender, EventArgs e)
        {
            Keep4checkBox.Checked = !Keep4checkBox.Checked;
        }

        private void Card5pictureBox_Click(object sender, EventArgs e)
        {
            Keep5checkBox.Checked = !Keep5checkBox.Checked;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            imageList1.ImageSize = new Size(100, 140);

            //Load card images into the ImageList
            string[] files = Directory.GetFiles("C:\\Users\\jbagg\\source\\repos\\Assignment 3 Cards\\Assignment 3 Cards\\Cards\\", "*.png");
            foreach (string file in files)
            {
                imageList1.Images.Add(Image.FromFile(file));
            }

            //Initialize the PictureBoxes 
            pictureBoxes = new PictureBox[] { Card1pictureBox, Card2pictureBox, Card3pictureBox, Card4pictureBox, Card5pictureBox };

            //Initialize CheckBoxes
            keepCheckBoxes = new CheckBox[] { Keep1checkBox, Keep2checkBox, Keep3checkBox, Keep4checkBox, Keep5checkBox };

            //Deal the initial hand of cards
            ShuffleDeck();
            for (int i = 0; i < handArray.Length; i++)
            {
                handArray[i] = deckList[i];
                pictureBoxes[i].Image = imageList1.Images[handArray[i]];
            }
        }

        private void Dealbutton_Click(object sender, EventArgs e)
        {
            ShuffleDeck();

            for (int i = 0; i < handArray.Length; i++)
            {
                //Deal new card if the checkbox is not checked
                if (!keepCheckBoxes[i].Checked)
                {
                    //Ensure that the deck has cards left to draw
                    if (deckList.Count < 5)
                    {
                        ShuffleDeck();
                    }

                    if (deckList.Count > 0)
                    {
                        int cardToDeal = deckList[0];
                        handArray[i] = cardToDeal;
                        deckList.RemoveAt(0);

                        //Set the PictureBox to show the card
                        pictureBoxes[i].Image = imageList1.Images[handArray[i]];
                    }
                }
                else
                {
                    //If the card is kept, update the PictureBox with the current card in hand
                    pictureBoxes[i].Image = imageList1.Images[handArray[i]];
                }
            }
            //Uncheck the checkboxes after dealing new cards
            foreach (var checkBox in keepCheckBoxes)
            {
                checkBox.Checked = false;
            }
        }

        private void LoadHandbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                DefaultExt = "txt"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(openFileDialog.FileName);

                for (int i = 0; i < handArray.Length; i++)
                {
                    if (i < lines.Length)
                    {
                        try
                        {
                            handArray[i] = int.Parse(lines[i]);
                        }
                        catch (FormatException)
                        {
                            handArray[i] = -1; 
                        }
                        if (handArray[i] >= 0 && handArray[i] < imageList1.Images.Count)
                        {
                            pictureBoxes[i].Image = imageList1.Images[handArray[i]];
                        }
                        else
                        {
                            handArray[i] = -1; // Invalid index, no card
                            pictureBoxes[i].Image = null;
                        }
                    }
                    else
                    {
                        handArray[i] = -1;
                        pictureBoxes[i].Image = null;
                    }
                }
            }
        }

        private void SaveHandbutton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Open the file 
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        for (int i = 0; i < handArray.Length; i++)
                        {
                            writer.WriteLine(handArray[i]);
                        }
                    }
                }
            }
        }
    }
}