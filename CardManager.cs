using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WnFormsMemory
{
    public partial class CardManager : Form
    {
        bool changed = false;
        public Form1 form1;
        public CardManager(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            this.StartPosition = FormStartPosition.CenterScreen;
            copyControls();
            this.Show();
        }
        void copyControls()
        {
            foreach (Bitmap item in form1.imageList.Images)
            {
                this.imageListTemp.Images.Add(item);
            }
            foreach (ListViewItem item in form1.listView.Items)
            {
                this.listViewTemp.Items.Add((ListViewItem)item.Clone());
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF;*.PNG";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                addImages(fileDialog.FileNames);
            }
            
        }
        private void addImages(string[] paths)
        {
            foreach (string path in paths)
            {
                addImage(path);
            }
        }
        private void addImage(string path)
        {
            if (!imageListTemp.Images.ContainsKey(path))
            {
                string name = System.IO.Path.GetFileName(path);
                ListViewItem listViewItem = new ListViewItem(name);
                listViewItem.SubItems.Add(path);
                Bitmap bitmap = (Bitmap)Bitmap.FromFile(path);
                imageListTemp.Images.Add(path, bitmap);
                listViewItem.ImageIndex = imageListTemp.Images.Count - 1;
                listViewItem.SubItems.Add(bitmap.Width.ToString() + "x" + bitmap.Height.ToString());
                listViewTemp.BeginUpdate();
                listViewTemp.Items.Add(listViewItem);
                changed = true;
                listViewTemp.EndUpdate();

            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listViewTemp.SelectedItems.Count < 0) return;
            foreach (ListViewItem item in listViewTemp.SelectedItems)
            {
                imageListTemp.Images.RemoveAt(item.ImageIndex);
                listViewTemp.Items.Remove(item);
                changed = true;
               
            }
            for (int i = 0; i < listViewTemp.Items.Count; i++)
            {
                listViewTemp.Items[i].ImageIndex = i;
            }
        }
       
        //public int getImagesCount()
        //{
        //    return listViewTemp.Items.Count;
        //}
        //public Bitmap getImage(int index = 0)
        //{
        //    return new Bitmap( listViewTemp.Items[index].SubItems[1].Text);
        //}


        private void buttonOk_Click(object sender, EventArgs e)
        {
            form1.imageList.Images.Clear();
            form1.listView.Items.Clear();
            foreach (Bitmap item in this.imageListTemp.Images)
            {
                form1.imageList.Images.Add(item);
            }
            foreach (ListViewItem item in this.listViewTemp.Items)
            {
                this.listViewTemp.Items.Remove(item);
                form1.listView.Items.Add(item);
            }
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
           
            if(!changed || MessageBox.Show("Niezapisane zmiany zostaną utracone! Kontunuować?","Uwaga",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }


        }

       

        private void buttonLista_Click(object sender, EventArgs e)
        {
            listViewTemp.View = View.List;
        }

        private void buttonSzczegoly_Click(object sender, EventArgs e)
        {
            listViewTemp.View = View.Details;
        }

        private void buttonMiniatury_Click(object sender, EventArgs e)
        {
            listViewTemp.View = View.LargeIcon;
        }
        int elo = 0;
       

   
    }
}
