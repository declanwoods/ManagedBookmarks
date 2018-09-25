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
            this.txtcurrfile = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnmodify = new System.Windows.Forms.Button();
            this.btncopyall = new System.Windows.Forms.Button();
            this.btnundo = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeview
            // 
            this.treeview.HideSelection = false;
            this.treeview.Location = new System.Drawing.Point(12, 39);
            this.treeview.Name = "treeview";
            this.treeview.Size = new System.Drawing.Size(417, 427);
            this.treeview.TabIndex = 0;
            // 
            // btnload
            // 
            this.btnload.Location = new System.Drawing.Point(92, 10);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(75, 23);
            this.btnload.TabIndex = 1;
            this.btnload.Text = "Load";
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(172, 10);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 2;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
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
            this.chkfolder.Click += new System.EventHandler(this.chkfolder_Click);
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
            this.txtname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtname_Changed);
            // 
            // txturl
            // 
            this.txturl.Location = new System.Drawing.Point(218, 490);
            this.txturl.Name = "txturl";
            this.txturl.Size = new System.Drawing.Size(211, 20);
            this.txturl.TabIndex = 8;
            this.txturl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txturl_Changed);
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
            this.label3.Location = new System.Drawing.Point(435, 17);
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
            this.rtbout.Size = new System.Drawing.Size(436, 471);
            this.rtbout.TabIndex = 10;
            this.rtbout.Text = "";
            // 
            // txtcurrfile
            // 
            this.txtcurrfile.Location = new System.Drawing.Point(253, 12);
            this.txtcurrfile.Name = "txtcurrfile";
            this.txtcurrfile.Size = new System.Drawing.Size(176, 20);
            this.txtcurrfile.TabIndex = 11;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(15, 517);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 12;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(96, 517);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(75, 23);
            this.btnremove.TabIndex = 13;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnmodify
            // 
            this.btnmodify.Location = new System.Drawing.Point(177, 517);
            this.btnmodify.Name = "btnmodify";
            this.btnmodify.Size = new System.Drawing.Size(75, 23);
            this.btnmodify.TabIndex = 14;
            this.btnmodify.Text = "Modify";
            this.btnmodify.UseVisualStyleBackColor = true;
            this.btnmodify.Click += new System.EventHandler(this.btnmodify_Click);
            // 
            // btncopyall
            // 
            this.btncopyall.Location = new System.Drawing.Point(435, 517);
            this.btncopyall.Name = "btncopyall";
            this.btncopyall.Size = new System.Drawing.Size(436, 23);
            this.btncopyall.TabIndex = 15;
            this.btncopyall.Text = "Copy All";
            this.btncopyall.UseVisualStyleBackColor = true;
            this.btncopyall.Click += new System.EventHandler(this.btncopyall_Click);
            // 
            // btnundo
            // 
            this.btnundo.Enabled = false;
            this.btnundo.Location = new System.Drawing.Point(325, 517);
            this.btnundo.Name = "btnundo";
            this.btnundo.Size = new System.Drawing.Size(104, 23);
            this.btnundo.TabIndex = 16;
            this.btnundo.Text = "Undo Last Action";
            this.btnundo.UseVisualStyleBackColor = true;
            this.btnundo.Click += new System.EventHandler(this.btnundo_Click);
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(12, 10);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(75, 23);
            this.btnnew.TabIndex = 17;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // ManagedBookmarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 549);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnundo);
            this.Controls.Add(this.btncopyall);
            this.Controls.Add(this.btnmodify);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtcurrfile);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
        private System.Windows.Forms.TextBox txtcurrfile;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnmodify;
        private System.Windows.Forms.Button btncopyall;
        private System.Windows.Forms.Button btnundo;
        private System.Windows.Forms.Button btnnew;
    }
}

