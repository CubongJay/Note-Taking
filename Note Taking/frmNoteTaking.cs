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

namespace Note_Taking
{
    public partial class frmNote : Form
    {
        public frmNote()
        {
            InitializeComponent();
        }

        private void frmNote_Load(object sender, EventArgs e)
        {
            panNotearea.Enabled = false;
        }

        private void tsmNewText_Click(object sender, EventArgs e)
        {
            panNotearea.Enabled = true;
        }

        private void tsmSaveText_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfdNote = new SaveFileDialog();

            sfdNote.Filter = "Text files(*.txt) | *.txt | All files(*.*) | *.* "; 
            sfdNote.ShowDialog();
            if(sfdNote.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfdNote.FileName, txtNote.Text);

            }
            
            
        }
    }
}
