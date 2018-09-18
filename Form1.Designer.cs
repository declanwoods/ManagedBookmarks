namespace ManagedBookmarks
{
    partial class ManagedBookmarks
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
            this.treeview = new System.Windows.Forms.TreeView();
            this.btnload = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.chkfolder = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txturl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbout = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // treeview
            // 
            this.treeview.Location = new System.Drawing.Point(12, 39);
            this.treeview.Name = "treeview";
            this.treeview.Size = new System.Drawing.Size(417, 427);
            this.treeview.TabIndex = 0;
            // 
            // btnload
            // 
            this.btnload.Location = new System.Drawing.Point(12, 12);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(75, 23);
            this.btnload.TabIndex = 1;
            this.btnload.Text = "Load";
            this.btnload.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(93, 12);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 2;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // chkfolder
            // 
            this.chkfolder.AutoSize = true;
            this.chkfolder.Location = new System.Drawing.Point(17, 486);
            this.chkfolder.Name = "chkfolder";
            this.chkfolder.Size = new System.Drawing.Size(61, 17);
            this.chkfolder.TabIndex = 4;
            this.chkfolder.Text = "Folder?";
            this.chkfolder.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(85, 490);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(127, 20);
            this.txtname.TabIndex = 6;
            // 
            // txturl
            // 
            this.txturl.Location = new System.Drawing.Point(218, 490);
            this.txturl.Name = "txturl";
            this.txturl.Size = new System.Drawing.Size(211, 20);
            this.txturl.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "URL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Live Output";
            // 
            // rtbout
            // 
            this.rtbout.Location = new System.Drawing.Point(435, 39);
            this.rtbout.Name = "rtbout";
            this.rtbout.ReadOnly = true;
            this.rtbout.Size = new System.Drawing.Size(436, 469);
            this.rtbout.TabIndex = 10;
            this.rtbout.Text = "";
            // 
            // ManagedBookmarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 520);
            this.Controls.Add(this.rtbout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txturl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkfolder);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.treeview);
            this.Name = "ManagedBookmarks";
            this.Text = "ManagedBookmarks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeview;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.CheckBox chkfolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txturl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbout;
    }
}

