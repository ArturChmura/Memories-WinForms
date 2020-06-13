namespace WnFormsMemory
{
    partial class CardManager
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.listViewTemp = new System.Windows.Forms.ListView();
            this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.res = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageListTemp = new System.Windows.Forms.ImageList(this.components);
            this.widokLabel = new System.Windows.Forms.Label();
            this.buttonLista = new System.Windows.Forms.Button();
            this.buttonSzczegoly = new System.Windows.Forms.Button();
            this.buttonMiniatury = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdd.Location = new System.Drawing.Point(12, 12);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(121, 57);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.Location = new System.Drawing.Point(12, 75);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(121, 57);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOk.Location = new System.Drawing.Point(12, 323);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(114, 57);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCancel.Location = new System.Drawing.Point(12, 381);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(114, 57);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // listViewTemp
            // 
            this.listViewTemp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName,
            this.path,
            this.res});
            this.listViewTemp.HideSelection = false;
            this.listViewTemp.LargeImageList = this.imageListTemp;
            this.listViewTemp.Location = new System.Drawing.Point(139, 12);
            this.listViewTemp.Name = "listViewTemp";
            this.listViewTemp.Size = new System.Drawing.Size(575, 426);
            this.listViewTemp.TabIndex = 5;
            this.listViewTemp.UseCompatibleStateImageBehavior = false;
            // 
            // FileName
            // 
            this.FileName.Text = "Nazwa Pliku";
            this.FileName.Width = 100;
            // 
            // path
            // 
            this.path.Text = "Ścieżka Katalogu";
            this.path.Width = 300;
            // 
            // res
            // 
            this.res.Text = "Rozdzielczość";
            this.res.Width = 80;
            // 
            // imageListTemp
            // 
            this.imageListTemp.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListTemp.ImageSize = new System.Drawing.Size(100, 100);
            this.imageListTemp.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // widokLabel
            // 
            this.widokLabel.AutoSize = true;
            this.widokLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.widokLabel.Location = new System.Drawing.Point(728, 323);
            this.widokLabel.Name = "widokLabel";
            this.widokLabel.Size = new System.Drawing.Size(60, 26);
            this.widokLabel.TabIndex = 6;
            this.widokLabel.Text = "View";
            // 
            // buttonLista
            // 
            this.buttonLista.Location = new System.Drawing.Point(720, 357);
            this.buttonLista.Name = "buttonLista";
            this.buttonLista.Size = new System.Drawing.Size(75, 23);
            this.buttonLista.TabIndex = 7;
            this.buttonLista.Text = "List";
            this.buttonLista.UseVisualStyleBackColor = true;
            this.buttonLista.Click += new System.EventHandler(this.buttonLista_Click);
            // 
            // buttonSzczegoly
            // 
            this.buttonSzczegoly.Location = new System.Drawing.Point(720, 386);
            this.buttonSzczegoly.Name = "buttonSzczegoly";
            this.buttonSzczegoly.Size = new System.Drawing.Size(75, 23);
            this.buttonSzczegoly.TabIndex = 8;
            this.buttonSzczegoly.Text = "Details";
            this.buttonSzczegoly.UseVisualStyleBackColor = true;
            this.buttonSzczegoly.Click += new System.EventHandler(this.buttonSzczegoly_Click);
            // 
            // buttonMiniatury
            // 
            this.buttonMiniatury.Location = new System.Drawing.Point(720, 415);
            this.buttonMiniatury.Name = "buttonMiniatury";
            this.buttonMiniatury.Size = new System.Drawing.Size(75, 23);
            this.buttonMiniatury.TabIndex = 9;
            this.buttonMiniatury.Text = "Icons";
            this.buttonMiniatury.UseVisualStyleBackColor = true;
            this.buttonMiniatury.Click += new System.EventHandler(this.buttonMiniatury_Click);
            // 
            // CardManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMiniatury);
            this.Controls.Add(this.buttonSzczegoly);
            this.Controls.Add(this.buttonLista);
            this.Controls.Add(this.widokLabel);
            this.Controls.Add(this.listViewTemp);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CardManager";
            this.ShowInTaskbar = false;
            this.Text = "CardManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ListView listViewTemp;
        private System.Windows.Forms.Label widokLabel;
        private System.Windows.Forms.Button buttonLista;
        private System.Windows.Forms.Button buttonSzczegoly;
        private System.Windows.Forms.Button buttonMiniatury;
        private System.Windows.Forms.ImageList imageListTemp;
        private System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.ColumnHeader path;
        private System.Windows.Forms.ColumnHeader res;
    }
}