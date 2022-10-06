using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using test_dotnet_core.Torservices;
using TORServices.Forms;

namespace test_dotnet_core.microsoft._Parallel
{
   public partial class frmparallel_02: frmBaseForm
    {
        public frmparallel_02()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmparallel_02
            // 
            this.ClientSize = new System.Drawing.Size(990, 653);
            this.Name = "frmparallel_02";
            this.Load += new System.EventHandler(this.frmparallel_02_Load);
            this.ResumeLayout(false);

        }

        private void frmparallel_02_Load(object sender, EventArgs e)
        {
            Test_01();
        }
        void Test_01()
        {
            int[] nums = Enumerable.Range(0, 1000000).ToArray();
            long total = 0;

            // Use type parameter to make subtotal a long, not an int
            Parallel.For<long>(0, nums.Length, () => 0, (j, loop, subtotal) =>
            {
                subtotal += nums[j];
                return subtotal;
            },
                (x) => Interlocked.Add(ref total, x)
            );

            richTextBox1.WriteLine("The total is {0:N0}", total);
       

        }
    }
}
