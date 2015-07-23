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
        private const int ROW_WEIGHT = 500;
        private const int MAX_ROW_COUNT = 10;

        public EngineInfoDrawer(RenderTarget renderTarget) {
            var factory = new DW.Factory(DW.FactoryType.Shared);
            defaultBrush = new SolidColorBrush(renderTarget, Color.Black);
            defaultTextFormat = new TextFormat(factory, "Microsoft Yahei Mono", FONT_SIZE);
            defaultRectangleFList = new RectangleF[MAX_ROW_COUNT];
            for (int i = 0; i < MAX_ROW_COUNT; i++) {
                defaultRectangleFList[i] = new RectangleF(0, i * FONT_SIZE, ROW_WEIGHT, FONT_SIZE);
            }
        }

        public void Draw(SimpleRenderTarget simpleRenderTarget) {
            var game = Game.Instance;
            var messages = new string[] {
                $"FPS:{fps:F1}",
                $"TotalRunTime:{game.UpdateDispatcher.TotalSeconds:F3}",
                $"SpritesCount:{game.SpriteManager.SpriteCount}",
                $"MousePosition:({game.InputManager.MousePositionX},{game.InputManager.MousePositionY})",
                $"IUpdatableCount:{game.UpdateDispatcher.UpdatableListCount}"
            };
            for (int i = 0; i < messages.Length; i++) {
                simpleRenderTarget.DrawText(messages[i], defaultTextFormat,
                    defaultRectangleFList[i], defaultBrush);
            }
        }

        public void Update(float dt) {
            fps = 1 / dt;
        }
    }
}