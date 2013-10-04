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

            this.comboBox1.DataSource = categories;
        }
    }
}
