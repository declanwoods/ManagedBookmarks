using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Newtonsoft.Json;

namespace ManagedBookmarks
{
    public partial class ManagedBookmarks : Form
    {
        private string currFileName = null;
        private int currid = 0;
        private TreeNodeCollection laststate = null;

        public ManagedBookmarks()
        {
            InitializeComponent();
        }

        private TreeNode generateTreeNode(List<Bookmark> lbm)
        {
            TreeNode parent = new TreeNode();
            for (int i = 0; i < lbm.Count(); i++)
            {
                if (lbm[i].children == null && lbm[i].folder != true)
                {
                    // Bookmark
                    TreeNode child = new TreeNode();
                    child.Text = lbm[i].name;

                    BookmarkTag tag = new BookmarkTag();
                    tag.url = lbm[i].url;
                    tag.id = currid++;
                    child.Tag = tag;

                    parent.Nodes.Add(child);
                } 
                else
                {
                    TreeNode child = generateTreeNode(lbm[i].children.ToList());
                    child.Text = lbm[i].name;

                    BookmarkTag tag = new BookmarkTag();
                    tag.url = null;
                    tag.id = currid++;
                    child.Tag = tag;

                    parent.Nodes.Add(child);
                }
            }
            return parent;
        }

        private TreeNode convertJsonToTreenode(string data)
        {
            List<Bookmark> lbm = JsonConvert.DeserializeObject<List<Bookmark>>(data);
            TreeNode root = generateTreeNode(lbm);
            root.Text = "root";

            BookmarkTag tag = new BookmarkTag();
            tag.url = null;
            tag.id = currid++;
            root.Tag = tag;

            treeview.Nodes.Clear();
            treeview.Nodes.Add(root);
            treeview.ExpandAll();
            updateLiveOutput();
            return root;
        }

        private List<Object> outputObject(List<TreeNode> lbm)
        {
            List<Object> output = new List<Object>();
            if (lbm != null)
            {
                for (int i = 0; i < lbm.Count(); i++)
                {
                    Debug.WriteLine(lbm[i].Tag);
                    BookmarkTag tag = (BookmarkTag)lbm[i].Tag;
                    if (tag.url != null)
                    {
                        // Bookmark
                        BookmarkOutput parent = new BookmarkOutput();
                        Debug.WriteLine(lbm[i].Text);
                        parent.name = lbm[i].Text;
                        parent.url = tag.url;
                        output.Add(parent);
                    }
                    else
                    {
                        // Folder
                        BookmarkFolderOutput parent = new BookmarkFolderOutput();
                        parent.name = lbm[i].Text;
                        List<TreeNode> nodes = new List<TreeNode>();
                        foreach (TreeNode t in lbm[i].Nodes)
                        {
                            nodes.Add(t);
                        }
                        List<Object> children = outputObject(nodes);
                        parent.children = children.ToArray();
                        output.Add(parent);
                    }
                }
            }
            return output;
        }

        private void updateLiveOutput()
        {
            List<TreeNode> nodes = new List<TreeNode>();
            foreach (TreeNode t in treeview.Nodes[0].Nodes)
            {
                nodes.Add(t);
            }
            List<Object> output = outputObject(nodes);
            Debug.WriteLine(output);
            string json = JsonConvert.SerializeObject(output, Formatting.Indented);
            rtbout.Text = json;
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            if (treeview.Nodes.Count != 0)
            {
                DialogResult sure = MessageBox.Show("Are you sure you want to open a new file? \n\nAll unsaved changes will be lost!", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (sure == DialogResult.Cancel)
                {
                    return;
                }
            }
            OpenFileDialog of = new OpenFileDialog();
            DialogResult dr = of.ShowDialog();
            if (dr == DialogResult.OK && !of.FileName.Equals(""))
            {
                txtcurrfile.Text = of.FileName;
                string filedata = File.ReadAllText(of.FileName);
                currFileName = of.FileName;
                convertJsonToTreenode(filedata);
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (treeview.Nodes.Count > 0)
            {
                List<TreeNode> nodes = new List<TreeNode>();
                foreach (TreeNode t in treeview.Nodes[0].Nodes)
                {
                    nodes.Add(t);
                }
                List<Object> output = outputObject(nodes);
                string json = JsonConvert.SerializeObject(output);
                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.InitialDirectory = this.currFileName;
                DialogResult dr = savedialog.ShowDialog();
                if (dr == DialogResult.OK && !savedialog.FileName.Equals(""))
                {
                    File.WriteAllText(savedialog.FileName, json);
                }
            }
        }

        private void chkfolder_Click(object sender, EventArgs e)
        {
            txturl.Enabled = !chkfolder.Checked;
        }

        private void txtname_Changed(object sender, KeyPressEventArgs e)
        {

        }

        private void txturl_Changed(object sender, KeyPressEventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (treeview.Nodes.Count > 0)
            {
                TreeNode selected = treeview.SelectedNode;
                string name = txtname.Text;
                string url = txturl.Text;

                if (name != "root" && name != "")
                {
                    if (chkfolder.Checked)
                    {
                        // Folder
                        if (((BookmarkTag)selected.Tag).url == null)
                        {
                            TreeNode newNode = new TreeNode();
                            newNode.Text = name;

                            BookmarkTag tag = new BookmarkTag();
                            tag.id = currid++;
                            tag.url = null;
                            newNode.Tag = tag;

                            TreeNode emptyNode = new TreeNode();
                            emptyNode.Text = "<Empty>";
                            BookmarkTag emptytag = new BookmarkTag();
                            emptytag.url = "";
                            emptytag.id = currid++;
                            emptyNode.Tag = emptytag;
                            newNode.Nodes.Add(emptyNode);

                            if (selected.Nodes.Count == 1)
                            {
                                if (selected.Nodes[0].Text == "<Empty>")
                                {
                                    selected.Nodes.Clear();
                                }

                            }
                            newNode.ExpandAll();
                            selected.Nodes.Add(newNode);

                        }
                        else
                        {
                            MessageBox.Show("Can't add a bookmark to a non-folder", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        // Bookmark
                        if (((BookmarkTag)selected.Tag).url == null)
                        {
                            TreeNode newNode = new TreeNode();
                            newNode.Text = name;

                            BookmarkTag tag = new BookmarkTag();
                            tag.id = currid++;
                            tag.url = url;
                            newNode.Tag = tag;
                            if (selected.Nodes.Count == 1)
                            {
                                if (selected.Nodes[0].Text == "<Empty>")
                                {
                                    selected.Nodes.Clear();
                                }

                            }
                            selected.Nodes.Add(newNode);
                        }
                        else
                        {
                            MessageBox.Show("Can't add a bookmark to a non-folder", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Name cannot be root or blank", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                updateLiveOutput();
            }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if (treeview.Nodes.Count > 0)
            {
                if (treeview.SelectedNode != null)
                {
                    if (treeview.SelectedNode.Text != "root")
                    {
                        this.laststate = treeview.Nodes;

                        treeview.Nodes.Remove(treeview.SelectedNode);
                        treeview.SelectedNode = null;
                        updateLiveOutput();
                    }
                    else
                    {
                        MessageBox.Show("Can't remove root directory", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnmodify_Click(object sender, EventArgs e)
        {
            if (treeview.Nodes.Count > 0)
            {
                if (treeview.Enabled)
                {
                    if (treeview.SelectedNode.Text != "root")
                    {
                        chkfolder.Enabled = false;
                        treeview.Enabled = false;
                        btnadd.Enabled = false;
                        btnremove.Enabled = false;
                        txtname.Text = treeview.SelectedNode.Text;
                        BookmarkTag tag = (BookmarkTag)treeview.SelectedNode.Tag;
                        Debug.WriteLine(tag.url);
                        if (tag.url == null)
                        {
                            txturl.Enabled = false;
                            chkfolder.Checked = true;
                        }
                        else
                        {
                            txturl.Text = tag.url;
                        }
                        btnmodify.Text = "Confirm";
                    }
                    else
                    {
                        MessageBox.Show("Cannot modify root", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else
                {
                    if (txtname.Text != "root")
                    {
                        treeview.SelectedNode.Text = txtname.Text;
                        if (((BookmarkTag)treeview.SelectedNode.Tag).url != null)
                        {
                            ((BookmarkTag)treeview.SelectedNode.Tag).url = txturl.Text;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Name cannot be root", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    chkfolder.Enabled = true;
                    chkfolder.Checked = false;
                    treeview.Enabled = true;
                    txtname.Text = "";
                    txturl.Enabled = true;
                    txturl.Text = "";
                    btnadd.Enabled = true;
                    btnremove.Enabled = true;
                    btnmodify.Text = "Modify";
                }
                updateLiveOutput();
            }
        }

        private void btncopyall_Click(object sender, EventArgs e)
        {
            if (treeview.Nodes.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                foreach (string line in rtbout.Lines)
                {
                    sb.AppendLine(line);
                }
                Clipboard.SetText(sb.ToString());
            }
        }

        private void btncopyallunformatted_Click(object sender, EventArgs e)
        {
            if (treeview.Nodes.Count > 0)
            {
                List<TreeNode> nodes = new List<TreeNode>();
                foreach (TreeNode t in treeview.Nodes[0].Nodes)
                {
                    nodes.Add(t);
                }
                List<Object> output = outputObject(nodes);
                Debug.WriteLine(output);
                string json = JsonConvert.SerializeObject(output, Formatting.None);
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(json);
                Clipboard.SetText(sb.ToString());
            }
        }

        private void btnundo_Click(object sender, EventArgs e)
        {
            if (laststate != null)
            {
                TreeNodeCollection templaststate = treeview.Nodes;
                treeview.Nodes.Clear();
                foreach (TreeNode t in laststate)
                {
                    treeview.Nodes.Add(t);
                }
                laststate = templaststate;
                updateLiveOutput();
            }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            if (treeview.Nodes.Count != 0)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to start new? \n\nAll unsaved changes will be lost!", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
            }
            currFileName = "";
            convertJsonToTreenode("[]");
        }
    }

    public class Bookmark
    {
        public string name { get; set; }
        public string url { get; set; }
        public Bookmark[] children { get; set; }
        public bool folder { get; set; }
        public int id { get; set; }
    }

    public class BookmarkTag
    {
        public string url { get; set; }
        public int id { get; set; }
    }

    public class BookmarkOutput
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class BookmarkFolderOutput
    {
        public string name { get; set; }
        public Object[] children { get; set; }
    }
}
