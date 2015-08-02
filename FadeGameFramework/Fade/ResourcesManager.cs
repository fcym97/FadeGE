using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using SharpDX;
using SharpDX.Direct2D1;
using SharpDX.DXGI;
using AlphaMode = SharpDX.Direct2D1.AlphaMode;
using Bitmap = SharpDX.Direct2D1.Bitmap;
using Image = System.Drawing.Image;
using PixelFormat = SharpDX.Direct2D1.PixelFormat;
using Rectangle = System.Drawing.Rectangle;

namespace Fade
{
    public sealed class ResourcesManager
    {
        private readonly Dictionary<string, int> bitmapNameDictionary = new Dictionary<string, int>();
        private readonly List<Bitmap> bitmapList = new List<Bitmap>();
        private readonly RenderTarget renderTarget;
        private int index;

        public ResourcesManager(RenderTarget target) {
            renderTarget = target;
        }

        public Bitmap GetResourceFromId(int resId) {
            return bitmapList[resId];
        }

        public int GetTextureIdFromPath(string path) {
            var filename = Path.GetFileName(path);
            Debug.Assert(filename != null, "filename != null");
            if (bitmapNameDictionary.ContainsKey(filename)) {
                return bitmapNameDictionary[filename];
            }
            throw new DirectoryNotFoundException("找不到路径对应的资源文件。请先在载入资源的方法中载入该资源！");
        }

        /// <summary>
        ///     从指定的路径中加载bitmap
        /// </summary>
        /// <param name="file">路径</param>
        /// <returns>TextureId</returns>
        public int LoadBitmapFromFile(string file) {
            var fileName = Path.GetFileName(file);
            Debug.Assert(fileName != null, "fileName != null");
            if (bitmapNameDictionary.ContainsKey(fileName)) {
                return bitmapNameDictionary[fileName];
            }
            // Loads from file using System.Drawing.Image
            using (var bitmap = (System.Drawing.Bitmap)Image.FromFile(file)) {
                var sourceArea = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
                var bitmapProperties =
                    new BitmapProperties(new PixelFormat(Format.R8G8B8A8_UNorm, AlphaMode.Premultiplied));
                var size = new Size(bitmap.Width, bitmap.Height);

                // Transform pixels from BGRA to RGBA
                var stride = bitmap.Width * sizeof(int);
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
                    bitmapNameDictionary.Add(fileName, index);
                    return index++;
                }
            }
        }
    }
}
