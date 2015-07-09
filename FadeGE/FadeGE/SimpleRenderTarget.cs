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

        public void DrawBitmap(Bitmap bitmap, Size2F frameSize,Vector2 position, RectangleF srcRectangleF, float opacity = 1f) {
            target.DrawBitmap(bitmap,
                              new RectangleF(position.X, position.Y,
                                             frameSize.Width,
                                             frameSize.Height),
                              opacity,
                              BitmapInterpolationMode.Linear,
                              srcRectangleF
                );
        }
    }
}