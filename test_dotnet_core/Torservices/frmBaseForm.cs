using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace test_dotnet_core.Torservices
{
  public  class frmBaseForm:Form
    {
        public RichTextBox richTextBox1;
        public frmBaseForm()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(990, 653);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // frmBaseForm
            // 
            this.ClientSize = new System.Drawing.Size(990, 653);
            this.Controls.Add(this.richTextBox1);
            this.Name = "frmBaseForm";
            this.ResumeLayout(false);

        }
    }
}
