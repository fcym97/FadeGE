using SharpDX;
using SharpDX.Direct2D1;
using TextFormat = SharpDX.DirectWrite.TextFormat;
using DW = SharpDX.DirectWrite;

namespace FadeGE
{
    public class EngineInfoDrawer : IUpdatable, IDrawable
    {
        private float fps;

        private Brush defaultBrush;
        private TextFormat defaultTextFormat;
        private RectangleF[] defaultRectangleFList;

        private const int FONT_SIZE = 16;
        private const int ROW_WEIGHT = 200;
        private const int messageCount = 3;

        public EngineInfoDrawer(RenderTarget renderTarget) {
            var factory = new DW.Factory(DW.FactoryType.Shared);
            defaultBrush = new SolidColorBrush(renderTarget, Color.Black);
            defaultTextFormat = new TextFormat(factory, "Microsoft Yahei Mono", FONT_SIZE);
            defaultRectangleFList = new RectangleF[messageCount];
            for (int i = 0; i < messageCount; i++) {
                defaultRectangleFList[i] = new RectangleF(0, i * FONT_SIZE, ROW_WEIGHT, FONT_SIZE);
            }
        }

        public void Draw(SimpleRenderTarget simpleRenderTarget) {
            var messages = new string[messageCount] {
                $"FPS:{fps:F1}",
                $"TotalRunTime:{Game.Instance.UpdateDispatcher.TotalSeconds:F3}",
                $"SpritesCount:{Game.Instance.SpriteManager.SpriteCount}"
            };
            for (int i = 0; i < messageCount; i++) {
                simpleRenderTarget.DrawText(messages[i], defaultTextFormat,
                    defaultRectangleFList[i], defaultBrush);
            }
        }

        public void Update(float dt) {
            fps = 1 / dt;
        }
    }
}