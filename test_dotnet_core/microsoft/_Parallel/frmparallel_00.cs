using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using test_dotnet_core.Torservices;
using TORServices.Forms;

namespace test_dotnet_core.microsoft._Parallel
{
  public partial  class frmparallel_00: frmBaseForm
    {
        public frmparallel_00()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmparallel_00
            // 
            this.ClientSize = new System.Drawing.Size(990, 653);
            this.Name = "frmparallel_00";
            this.Load += new System.EventHandler(this.frmparallel_00_Load);
            this.ResumeLayout(false);

        }
        //https://learn.microsoft.com/en-us/dotnet/standard/parallel-programming/how-to-write-a-simple-parallel-for-loop
        private void frmparallel_00_Load(object sender, EventArgs e)
        {
            Test_01();
        }
        void Test_01()
        {
            long totalSize = 0;

            string dir = @"D:\SongTOR";
            var watch = Stopwatch.StartNew();
            String[] files = Directory.GetFiles(dir, "*", SearchOption.AllDirectories);
            Parallel.For(0, files.Length,
                         index => {
                             FileInfo fi = new FileInfo(files[index]);
                             long size = fi.Length;
                             Interlocked.Add(ref totalSize, size);
                         });
            richTextBox1.WriteLine($"Directory {dir}:\n{files.Length:N0} files, {totalSize:N0} bytes\n Time Taken : {watch.ElapsedMilliseconds} ms.");
        }
    }
}
