using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace png2bmp32
{
   [StructLayout(LayoutKind.Sequential, Pack = 1)]
   public struct BitmapInfoHeader
   {
      public UInt32 biSize;
      public Int32 biWidth;
      public Int32 biHeight;
      public UInt16 biPlanes;
      public UInt16 biBitCount;
      public UInt32 biCompression;
      public UInt32 biSizeImage;
      public Int32 biXPelsPerMeter;
      public Int32 biYPelsPerMeter;
      public UInt32 biClrUsed;
      public UInt32 biClrImportant;

      public static uint Size
      {
         get { return (uint)Marshal.SizeOf(typeof(BitmapInfoHeader)); }
      }

      public void Init()
      {
         biSize = Size;
      }
   }
}
