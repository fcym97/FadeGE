using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using SharpDX;
using SharpDX.Direct2D1;
using SharpDX.DXGI;
using AlphaMode = SharpDX.Direct2D1.AlphaMode;
using Bitmap = SharpDX.Direct2D1.Bitmap;
using Image = System.Drawing.Image;
using PixelFormat = SharpDX.Direct2D1.PixelFormat;
using Rectangle = System.Drawing.Rectangle;

namespace FadeGE
{
    public class ResourcesManager
    {
        private readonly List<Bitmap> bitmapList = new List<Bitmap>();
        private readonly RenderTarget renderTarget;
        private int index;

        public ResourcesManager(RenderTarget target) {
            renderTarget = target;
        }

        public Bitmap GetResourceFromId(int resId) {
            return bitmapList[resId];
        }

        /// <summary>
        ///     从指定的路径中加载bitmap
        /// </summary>
        /// <param name="file">路径</param>
        /// <returns>载入的bitmap的位置</returns>
        public int LoadBitmapFromFile(string file) {
            // Loads from file using System.Drawing.Image
            using (var bitmap = (System.Drawing.Bitmap) Image.FromFile(file)) {
                var sourceArea = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
                var bitmapProperties =
                    new BitmapProperties(new PixelFormat(Format.R8G8B8A8_UNorm, AlphaMode.Premultiplied));
                var size = new Size(bitmap.Width, bitmap.Height);

                // Transform pixels from BGRA to RGBA
                var stride = bitmap.Width * sizeof (int);
                using (var tempStream = new DataStream(bitmap.Height * stride, true, true)) {
                    // Lock System.Drawing.Bitmap
                    var bitmapData = bitmap.LockBits(sourceArea, ImageLockMode.ReadOnly,
                                                     System.Drawing.Imaging.PixelFormat.Format32bppPArgb);

                    // Convert all pixels 
                    for (var y = 0; y < bitmap.Height; y++) {
                        var offset = bitmapData.Stride * y;
                        for (var x = 0; x < bitmap.Width; x++) {
                            // Not optimized 
                            var b = Marshal.ReadByte(bitmapData.Scan0, offset++);
                            var g = Marshal.ReadByte(bitmapData.Scan0, offset++);
                            var r = Marshal.ReadByte(bitmapData.Scan0, offset++);
                            var a = Marshal.ReadByte(bitmapData.Scan0, offset++);
                            var rgba = r | (g << 8) | (b << 16) | (a << 24);
                            tempStream.Write(rgba);
                        }
                    }
                    bitmap.UnlockBits(bitmapData);
                    tempStream.Position = 0;

                    bitmapList.Add(new Bitmap(renderTarget,
                                              new Size2(size.Width, size.Height), tempStream, stride,
                                              bitmapProperties));
                    ;
                    return index++;
                }
            }
        }
    }
}
