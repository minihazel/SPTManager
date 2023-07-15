using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPTManager
{
    public partial class mainForm : Form
    {
        public string currentDir = "E:\\SPT Iterations\\SPT-AKI 3.5.8";

        public string userFolder;
        public string serverModsFolder;
        public string clientModsFolder;

        public Color listBackcolor = Color.FromArgb(255, 28, 28, 28);
        public Color listSelectedcolor = Color.FromArgb(255, 37, 37, 37);
        public Color listHovercolor = Color.FromArgb(255, 33, 33, 33);

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            serverMods.BringToFront();

            // Variables
            userFolder = Path.Combine(currentDir, "user");
            serverModsFolder = Path.Combine(userFolder, "mods");
            string clientBepFolder = Path.Combine(currentDir, "BepInEx");
            clientModsFolder = Path.Combine(clientBepFolder, "plugins");

            // Checking paths
            bool userFolderExists = Directory.Exists(userFolder);
            bool serverModsFolderExists = Directory.Exists(serverModsFolder);
            bool clientModsFolderExists = Directory.Exists(clientModsFolder);

            if (userFolderExists && serverModsFolderExists && clientModsFolderExists)
            {
                serverModsBtn.BackColor = Color.FromArgb(37, 37, 37);

                listServerMods();
                listClientMods();

                globalFontSizeBox.Value = 10;
            }
        }

        private void globalFontSizeBox_ValueChanged(object sender, EventArgs e)
        {
            foreach (Control ctrl in serverMods.Controls)
            {
                if (ctrl is Label lbl)
                {
                    lbl.Font = new Font("Bahnschrift Light", Convert.ToSingle(globalFontSizeBox.Value), FontStyle.Regular);
                }
            }

            foreach (Control ctrl in serverMods.Controls)
            {
                if (ctrl is Label lbl)
                {
                    lbl.Font = new Font("Bahnschrift Light", Convert.ToSingle(globalFontSizeBox.Value), FontStyle.Regular);
                }
            }
        }

        private void listServerMods()
        {
            string[] serverModsPath = Directory.GetDirectories(serverModsFolder);
            int widthspacer = 38;

            for (int i = 0; i < serverModsPath.Length; i++)
            {
                Label lbl = new Label();
                lbl.Text = Path.GetFileName(serverModsPath[i]);
                lbl.AutoSize = false;
                lbl.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);
                lbl.TextAlign = ContentAlignment.MiddleLeft;
                lbl.Size = new Size(serverMods.Size.Width - 4, widthspacer);
                lbl.Location = new Point(0, 1 + (i * widthspacer));
                lbl.Font = new Font("Bahnschrift Light", 10, FontStyle.Regular);
                lbl.BackColor = listBackcolor;
                lbl.ForeColor = Color.LightGray;
                lbl.Margin = new Padding(1, 1, 1, 1);
                lbl.Cursor = Cursors.Hand;
                lbl.MouseEnter += new EventHandler(lbl_MouseEnter);
                lbl.MouseLeave += new EventHandler(lbl_MouseLeave);
                lbl.MouseDown += new MouseEventHandler(lbl_MouseDown);
                lbl.MouseUp += new MouseEventHandler(lbl_MouseUp);
                serverMods.Controls.Add(lbl);
            }
        }

        private void listClientMods()
        {
            string[] clientModsPath = Directory.GetDirectories(clientModsFolder);
            string[] clientModsPath2 = Directory.GetFiles(clientModsFolder);
            int widthspacer1 = 38;
            int widthspacer2 = 38;
            int labelIndex = 0;
            int labelIndex2 = 0;

            for (int i = 0; i < clientModsPath.Length; i++)
            {
                Label lbl = new Label();
                lbl.Text = Path.GetFileName(clientModsPath[i]);
                lbl.AutoSize = false;
                lbl.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);
                lbl.TextAlign = ContentAlignment.MiddleLeft;
                lbl.Size = new Size(serverMods.Size.Width - 4, widthspacer1);
                lbl.Location = new Point(0, 1 + (labelIndex * widthspacer1));
                lbl.Font = new Font("Bahnschrift Light", 10, FontStyle.Regular);
                lbl.BackColor = listBackcolor;
                lbl.ForeColor = Color.LightGray;
                lbl.Margin = new Padding(1, 1, 1, 1);
                lbl.Cursor = Cursors.Hand;
                lbl.MouseEnter += new EventHandler(lbl_MouseEnter);
                lbl.MouseLeave += new EventHandler(lbl_MouseLeave);
                lbl.MouseDown += new MouseEventHandler(lbl_MouseDown);
                lbl.MouseUp += new MouseEventHandler(lbl_MouseUp);
                clientMods.Controls.Add(lbl);
                labelIndex++;
            }

            for (int i = 0; i < clientModsPath2.Length; i++)
            {
                if (Path.GetFileNameWithoutExtension(clientModsPath2[i]) != "aki-core" &&
                    Path.GetFileNameWithoutExtension(clientModsPath2[i]) != "aki-custom" &&
                    Path.GetFileNameWithoutExtension(clientModsPath2[i]) != "aki-debugging" &&
                    Path.GetFileNameWithoutExtension(clientModsPath2[i]) != "aki-singleplayer" &&
                    Path.GetFileNameWithoutExtension(clientModsPath2[i]) != "ConfigurationManager" &&
                    Path.GetFileNameWithoutExtension(clientModsPath2[i]) != "LICENSE" &&
                    Path.GetExtension(clientModsPath2[i]) != null || Path.GetExtension(clientModsPath2[i]) != "")
                {
                    Label lbl = new Label();
                    lbl.Text = Path.GetFileName(clientModsPath2[i]);
                    lbl.AutoSize = false;
                    lbl.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);
                    lbl.TextAlign = ContentAlignment.MiddleLeft;
                    lbl.Size = new Size(serverMods.Size.Width - 4, widthspacer2);
                    lbl.Location = new Point(0, 1 + (labelIndex2 * widthspacer2));
                    lbl.Font = new Font("Bahnschrift Light", 10, FontStyle.Regular);
                    lbl.BackColor = listBackcolor;
                    lbl.ForeColor = Color.LightGray;
                    lbl.Margin = new Padding(1, 1, 1, 1);
                    lbl.Cursor = Cursors.Hand;
                    lbl.MouseEnter += new EventHandler(lbl_MouseEnter);
                    lbl.MouseLeave += new EventHandler(lbl_MouseLeave);
                    lbl.MouseDown += new MouseEventHandler(lbl_MouseDown);
                    lbl.MouseUp += new MouseEventHandler(lbl_MouseUp);
                    clientMods.Controls.Add(lbl);
                    labelIndex2++;
                }
            }
        }

        private void lbl_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.Label label = (System.Windows.Forms.Label)sender;
            if (label.Text != "")
            {
                if (label.BackColor != listSelectedcolor)
                {
                    label.BackColor = listHovercolor;
                }
            }
        }

        private void lbl_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.Label label = (System.Windows.Forms.Label)sender;
            if (label.Text != "")
            {
                if (label.BackColor != listSelectedcolor)
                {
                    label.BackColor = listBackcolor;
                }
            }
        }

        // When a profile is clicked
        private void lbl_MouseDown(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Label label = (System.Windows.Forms.Label)sender;

            if (label.Text != "")
            {
                if (Control.ModifierKeys == Keys.Control && e.Button == MouseButtons.Left)
                {
                    label.BackColor = listSelectedcolor;
                }
                else if ((Control.ModifierKeys & Keys.Control) != Keys.Control)
                {
                    deSelectPanel(label.Parent);
                    label.BackColor = listSelectedcolor;
                }
            }
        }

        private void lbl_MouseUp(object sender, EventArgs e)
        {
            System.Windows.Forms.Label label = (System.Windows.Forms.Label)sender;
            if (label.Text != "")
            {
                // label.BackColor = listHovercolor;
            }
        }

        private void deSelectPanel(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is Label lbl)
                {
                    lbl.BackColor = listBackcolor;
                }
            }
        }

        private void serverModsBtn_Click(object sender, EventArgs e)
        {
            serverMods.BringToFront();
            serverModsBtn.BackColor = Color.FromArgb(37, 37, 37);
            clientModsBtn.BackColor = Color.FromArgb(28, 28, 28);
        }

        private void clientModsBtn_Click(object sender, EventArgs e)
        {
            clientMods.BringToFront();
            clientModsBtn.BackColor = Color.FromArgb(37, 37, 37);
            serverModsBtn.BackColor = Color.FromArgb(28, 28, 28);
        }

        private void mainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (serverModsBtn.BackColor == listSelectedcolor)
                {
                    
                }
                else
                {

                }
            }
        }
    }
}
