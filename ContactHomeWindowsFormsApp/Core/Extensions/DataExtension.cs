using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactHomeWindowsFormsApp.Core.Extensions
{
    static partial class Extension
    {
        internal static byte[] GetBuffer(this Image image)
        {
            if (image==null)
            {
                return null;
            }
            using (var stream = new MemoryStream())  //from image to buffer
            {
                image.Save(stream, image.RawFormat);
                var buffer = stream.GetBuffer();
                return buffer;
            }
        }
    }
}
    
