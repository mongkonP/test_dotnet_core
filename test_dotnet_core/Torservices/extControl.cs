

using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TORServices.Forms
{
    public static class extControl
    {
        #region  Form  Ext       
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
       
        public static  void AddNewForm(this System.Windows.Forms.Panel pn, System.Windows.Forms.Form form)
        {
            pn.Controls.Clear();
           

            form.TopLevel = false;
            form.AutoScroll = true;
            form.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Left);
            form.Dock = System.Windows.Forms.DockStyle.Fill;
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Parent = pn;
            pn.Controls.Add(form);
            try { form.Show(); }
            catch { }

            

        }

        public static void SetFormDialog(this Form f, FormBorderStyle _FormBorderStyle = FormBorderStyle.None)
        {
            f.FormBorderStyle = _FormBorderStyle;
            f.BackColor = Color.SkyBlue;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.SetThemeColor();
        }
        public static void SetThemeColor(this Control clt)
        {
            clt.BackColor = Color.SkyBlue;
        }
        public static void SetMoveformwithoutTitlebar(this System.Windows.Forms.Form f)
        {
            f.MouseDown += new MouseEventHandler((object sender,
               System.Windows.Forms.MouseEventArgs e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(f.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            });

        }
        public static void SetMoveformwithoutTitlebar(this Control c, Form f)
        {
            c.MouseDown += new MouseEventHandler((object sender,
               System.Windows.Forms.MouseEventArgs e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(f.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            });

        }


        public static void AddToolTip(this System.Windows.Forms.Control ct, string strToolTip)
        {
            System.Windows.Forms.ToolTip toolTipcmdLogin = new System.Windows.Forms.ToolTip();
            toolTipcmdLogin.SetToolTip(ct, strToolTip);
        }
        #endregion


        #region _Control Write
        public static void Write(this System.Windows.Forms.Control ctl, string value)
        {
            try
            {

                ctl.Invoke(new System.Action(() => { ctl.Text = value; }));
            }
            catch { }
        }
        public static void Write(this System.Windows.Forms.Control ctl)
        {
            ctl.Write("");
        }
        public static void Write(this System.Windows.Forms.Control ctl, Object value)
        {
            ctl.Write(value.ToString());
        }
        public static void Write(this System.Windows.Forms.Control ctl, System.String format, System.Object arg0)
        {
            ctl.Write(string.Format(format, arg0));

        }
        public static void Write(this System.Windows.Forms.Control ctl, System.String format, System.Object arg0, System.Object arg1)
        {
            ctl.Write(string.Format(format, arg0, arg1));

        }
        public static void Write(this System.Windows.Forms.Control ctl, System.String format, System.Object arg0, System.Object arg1, System.Object arg2)
        {
            ctl.Write(string.Format(format, arg0, arg1, arg2));

        }
        public static void Write(this System.Windows.Forms.Control ctl, System.String format, params System.Object[] arg)
        {
            ctl.Write(string.Format(format, arg));

        }


        public static void WriteLine(this System.Windows.Forms.Control ctl, string value)
        {
            try
            {

                ctl.Invoke(new System.Action(() => { ctl.Write(ctl.Text += "\n" + value); }));
            }
            catch { }
        }
        public static void WriteLine(this System.Windows.Forms.Control ctl)
        {
            ctl.WriteLine("");
        }
        public static void WriteLine(this System.Windows.Forms.Control ctl, Object value)
        {
            ctl.WriteLine(value.ToString());
        }
        public static void WriteLine(this System.Windows.Forms.Control ctl, System.String format, System.Object arg0)
        {
            ctl.WriteLine(string.Format(format, arg0));

        }
        public static void WriteLine(this System.Windows.Forms.Control ctl, System.String format, System.Object arg0, System.Object arg1)
        {
            ctl.WriteLine(string.Format(format, arg0, arg1));

        }
        public static void WriteLine(this System.Windows.Forms.Control ctl, System.String format, System.Object arg0, System.Object arg1, System.Object arg2)
        {
            ctl.WriteLine(string.Format(format, arg0, arg1, arg2));

        }
        public static void WriteLine(this System.Windows.Forms.Control ctl, System.String format, params System.Object[] arg)
        {
            ctl.WriteLine(string.Format(format, arg));

        }

        #endregion



    }
}
