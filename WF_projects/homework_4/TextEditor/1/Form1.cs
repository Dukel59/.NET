using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        ImageList image;
        public Form1()
        {
            InitializeComponent();

            InitTool();

            this.Text = default;
        }

        private void InitTool()
        {
            image = new ImageList();
            image.ImageSize = new Size(50, 50);
            image.Images.Add(new Bitmap("open.png"));
            image.Images.Add(new Bitmap("save.png"));
            image.Images.Add(new Bitmap("new_doc.png"));
            image.Images.Add(new Bitmap("copy.png"));
            image.Images.Add(new Bitmap("cut.png"));
            image.Images.Add(new Bitmap("insert.png"));
            image.Images.Add(new Bitmap("cancel.png"));
            image.Images.Add(new Bitmap("editor.png"));
            image.Images.Add(new Bitmap("text_color.png"));
            image.Images.Add(new Bitmap("background_color.png"));
            image.Images.Add(new Bitmap("font.png"));

            toolStrip1.ImageList = image;
            toolStripButton1.ImageIndex = 0;
            toolStripButton2.ImageIndex = 1;
            toolStripButton3.ImageIndex = 2;
            toolStripButton4.ImageIndex = 3;
            toolStripButton5.ImageIndex = 4;
            toolStripButton6.ImageIndex = 5;
            toolStripButton7.ImageIndex = 6;
            toolStripDropDownButton1.ImageIndex = 7;    
        }

        private void Open()
        {
            var open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader stream = File.OpenText(open.FileName))
                {
                    textBox1.Text = stream.ReadToEnd();
                    this.Text = open.FileName;
                }
            }
        }

        private void Save()
        {
            string dir = Directory.GetCurrentDirectory();
            string saveN = dir + "\\file_1.txt";
            string saveT = textBox1.Text;
            File.WriteAllText(saveN, saveT);
            this.Text = saveN;
        }

        private void NewDoc()
        {
            if(textBox1.Text != null) 
            {
                var result = MessageBox.Show("Вы хотите сохранить изменения в файле?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    SaveAs();
                }
            }
            textBox1.Clear();
            string dir = Directory.GetCurrentDirectory() + "\\file_1.txt";
            System.IO.File.CreateText(dir);
            this.Text = dir;
        }

        private void SaveAs()
        {
            var save = new SaveFileDialog();
            save.FileName = "File_1";
            save.Filter = "TXT (*.txt)|*.txt||";

            if (save.ShowDialog() == DialogResult.OK)
            {
                var writer = new StreamWriter(save.FileName);
                    writer.WriteLine(textBox1.Text);
                this.Text = save.FileName;
                    writer.Close();
            }
        }
        
        private void Copy()
        {
            if (!textBox1.SelectedText.Equals(""))
            {
                Clipboard.SetText(textBox1.SelectedText);
            }
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void Cut()
        {
            if (!textBox1.SelectedText.Equals(""))
            {
                Clipboard.SetText(textBox1.SelectedText);
                textBox1.SelectedText = null;
            }
        }

        private void Insert()
        {
            string text = Clipboard.GetText();
            textBox1.SelectedText = text;
        }

        private void FontStyle()
        {
            var font = new FontDialog();
            var result = font.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox1.Font = font.Font;
            }
        }

        private void FontColor()
        {
            var fColor = new ColorDialog();
            var result = fColor.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox1.ForeColor = fColor.Color;
            }
        }

        private void BackgroundColor()
        {
            var bColor = new ColorDialog();
            var result = bColor.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox1.BackColor = bColor.Color;
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Insert();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FontStyle();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FontColor();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            BackgroundColor();
        }

        private void newDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewDoc();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Insert();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontColor();
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundColor();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontColor();
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void insertToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Insert();
        }

        private void cancelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            NewDoc();
        }
    }
}
