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
using System.Runtime.InteropServices;
using System.Threading;

namespace WindowOrganizer
{
    public partial class MainForm : Form
    {
        private IntPtr id;
        public MainForm()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        public static IntPtr WinGetHandle(string wName)
        {
            IntPtr hWnd = IntPtr.Zero;
            foreach (Process pList in Process.GetProcesses())
            {
                if (pList.MainWindowTitle.Contains(wName))
                {
                    hWnd = pList.MainWindowHandle;
                }
            }
            return hWnd;
        }

        private void btn_findWindow_Click(object sender, EventArgs e)
        {
            id = WinGetHandle(txt_WindowTitle.Text);
            if (id != IntPtr.Zero)
            {
                MessageBox.Show("hWnd found with id: " + id.ToString());
                btn_setParam.Enabled = true;
            }
            else
            {
                MessageBox.Show("hWnd not found!\nVerify the input title");
                btn_setParam.Enabled = false;
            }
            
            
        }

        private void btn_setParam_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txt_posX.Text);
            int y = Convert.ToInt32(txt_posY.Text);
            int height = Convert.ToInt32(txt_height.Text);
            int width = Convert.ToInt32(txt_width.Text);

            MoveWindow(id, x, y, width, height, true);
        }
    }
}
