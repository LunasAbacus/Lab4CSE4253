using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ArtworkCollection;

        

namespace CollectionViewer
{
    public partial class Form1 : Form
    {
        List<ArtInfo> artLib = new List<ArtInfo>();
        BindingList<ArtInfo> bindingArtLib;
        ArtCategories categories = new ArtCategories();

        public Form1()
        {
            InitializeComponent();

            bindingArtLib = new BindingList<ArtInfo>(artLib);
            bindingArtLib.RaiseListChangedEvents = true;
            bindingArtLib.AllowNew = true;
            bindingArtLib.AllowEdit = true;

            this.listBox1.DataSource = bindingArtLib;
            this.listBox1.DisplayMember = "Title";

            this.comboBox1.DataSource = categories.getCategories();
        }

        private void newPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArtInfo newArt = new ArtInfo();
            bindingArtLib.Add(newArt);
            this.listBox1.SetSelected(artLib.Count - 1, true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = this.listBox1.SelectedIndex;
            ArtInfo selectedArt = this.listBox1.SelectedItem as ArtInfo;
            if (selectedArt != null)
            {
                selectedArt.author = this.authorBox.Text;
                //selectedArt.category = categories.getCategories()[comboBox1.SelectedIndex];
                selectedArt.Title = this.titleBox.Text;
                selectedArt.website = this.websiteBox.Text;
                selectedArt.year = (int) this.numericUpDown1.Value;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArtInfo art = (ArtInfo)this.listBox1.SelectedItem;
            if (art != null)
            {
                this.titleBox.Text = art.Title;
            }
        }
    }
}
