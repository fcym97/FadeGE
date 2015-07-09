using SharpDX;
using SharpDX.Direct2D1;

namespace FadeGE
{
    public class SimpleRenderTarget
    {
        private readonly RenderTarget target;

        public SimpleRenderTarget(RenderTarget target) {
            this.target = target;
        }

        public void Clear(Color color) {
            target.Clear(color);
        }

        public void DrawBitmap(Bitmap bitmap, Vector2 position, float opacity = 1f) {
            target.DrawBitmap(bitmap,
                              new RectangleF(position.X, position.Y,
                                             bitmap.Size.Width,
                                             bitmap.Size.Height),
                              opacity,
                              BitmapInterpolationMode.Linear,
                              new RectangleF(0, 0,
                                             bitmap.Size.Width,
                                             bitmap.Size.Height)
                );
        }
    }
}