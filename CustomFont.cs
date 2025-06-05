using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Stopwatcher
{
    class CustomFont
    {
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(
            IntPtr pbFont,
            uint cbFont,
            IntPtr pdv,
            [In] ref uint pcFonts
            );

        private PrivateFontCollection pfc = new PrivateFontCollection();

        public void IncludeFont(byte[] resourceFont, List<Label> labels)
        {
            byte[] fontData = resourceFont;
            IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);

            Marshal.Copy(fontData, 0, fontPtr, fontData.Length);

            uint dummy = 0;
            pfc.AddMemoryFont(fontPtr, resourceFont.Length);
            AddFontMemResourceEx(fontPtr, (uint)resourceFont.Length, IntPtr.Zero, ref dummy);
            Marshal.FreeCoTaskMem(fontPtr);

            foreach (Label label in labels)
            {
                label.Font = new Font(pfc.Families[0], label.Font.Size);
            }
            //pfc.Dispose();
        }
    }
}
