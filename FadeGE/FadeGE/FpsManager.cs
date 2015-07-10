using System;
using System.Globalization;
using SharpDX;
using SharpDX.Direct2D1;
using TextFormat = SharpDX.DirectWrite.TextFormat;
using DW = SharpDX.DirectWrite;

namespace FadeGE
{
    public class FpsManager : IUpdatable, IDrawable
    {
        private float fps;
        private Brush brush;
        private TextFormat textFormat;
        private RectangleF rectangle;

        public FpsManager(RenderTarget renderTarget) {
            var factory = new DW.Factory(DW.FactoryType.Shared);
            brush = new SolidColorBrush(renderTarget, Color.Black);
            textFormat = new TextFormat(factory, "Microsoft Yahei Mono",16);
            rectangle = new RectangleF(0, 0, 100, 100);
        }

        public void Draw(SimpleRenderTarget renderTarget) {
            renderTarget.DrawText(string.Format("FPS:{0:F1}", fps), textFormat, rectangle, brush);
        }

        public void Update(float dt) {
            fps = 1 / dt;
        }
    }
}