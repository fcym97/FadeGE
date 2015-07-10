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
            textFormat = new TextFormat(factory, "Microsoft Yahei Mono", 16);
            rectangle = new RectangleF(0, 0, 200, 16);
        }

        public void Draw(SimpleRenderTarget renderTarget) {
            renderTarget.DrawText(string.Format("FPS:{0:F1}", fps), textFormat, rectangle, brush);
            renderTarget.DrawText(
                string.Format("TotalRunTime:{0:F3}s", Game.Instance.UpdateDispatcher.TotalSeconds), textFormat,
                new RectangleF(0, 16, 200, 16), brush);
        }

        public void Update(float dt) {
            fps = 1 / dt;
        }
    }
}