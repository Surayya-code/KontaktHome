using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactHomeWindowsFormsApp.Core.Extensions
{
    static partial class Extension
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        internal static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );
        internal static void RoundControl(this Control control,int width, int height,int widthEllipse, int heightEllipse)
        {
            control.Region =Region.FromHrgn(CreateRoundRectRgn(0, 0, width, height, widthEllipse, heightEllipse));
        }
        internal static void RoundControl(this Form form, int width, int height, int widthEllipse, int heightEllipse)
        {
            RoundControl((Control)form, width, height, widthEllipse, heightEllipse);
        }

        static public void InitGrid(this DataGridView gridView)
        {
            gridView.AllowUserToAddRows = false;
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (var column in gridView.Columns)
            {
                if (column is DataGridViewTextBoxColumn)
                {
                    (column as DataGridViewTextBoxColumn).ReadOnly = true;

                    if ((column as DataGridViewTextBoxColumn).HeaderText.Contains("Id"))
                        (column as DataGridViewTextBoxColumn).Visible = false;

                }
            }
        }


    }
}
