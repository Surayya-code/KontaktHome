using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactHomeWindowsFormsApp.Core.Extensions
{

    static partial class Extension
    {
        internal static T GetCurrentnRow<T>(this BindingSource bindingSource)
           where T : DataRow
        {
            var row = (bindingSource?.Current as DataRowView)?.Row as T;
            return row;
        }


        internal static byte[] GetBuffer(this Image image)
        {
            if (image==null)
            {
                //MessageBox.Show("sekil secile bilmedi");
                return null;
            }
            using (var stream = new MemoryStream())  //from image to buffer
            {
                image.Save(stream,image.RawFormat);
                var buffer = stream.GetBuffer();
                return buffer;
            }
        }
    }
}
    
