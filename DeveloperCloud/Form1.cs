using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeveloperCloud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Init();
            
        }

        private void Init()
        {
            mainFileListView.View = View.LargeIcon;
            mainFileListView.LargeImageList = fileImageList;
            for (int i = 0; i < 5; i++)
            {
                ListViewItem lvi = new ListViewItem();

                lvi.ImageIndex = 0;

                lvi.Text = "item" + i;

                mainFileListView.Items.Add(lvi);
            }

            mainFileListView.EndUpdate();
        }
    }
}
