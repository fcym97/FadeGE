using System;
using System.Diagnostics;
using Fade;
using SharpDX;
using SharpDX.Direct2D1;
using SharpDX.RawInput;
using System.Windows.Forms;

namespace FadeDemo
{
    static class Program
    {
        static TestSprite testSprite;
        static Game game;

        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args) {
            game = new Game(1024, 768, "FadeGameFramework Demo");
            LoadAllContents();
            testSprite = new TestSprite();
            game.SpriteManager.AddSprite(testSprite);
            game.RenderEventHandler += Render;
            game.InputManager.KeyboardInputEventHandler += KeyboardHandler;
            game.Run();
        }

        private static void KeyboardHandler() {
            const int v = 10;
            if (game.InputManager.IsKeyDown(Keys.Up)) {
                testSprite.Position -= new Vector2(0, v);
            }
            else if (game.InputManager.IsKeyDown(Keys.Down)) {
                testSprite.Position += new Vector2(0, v);
            }
            if (game.InputManager.IsKeyDown(Keys.Left)) {
                testSprite.Position -= new Vector2(v, 0);
            }
            else if (game.InputManager.IsKeyDown(Keys.Right)) {
                testSprite.Position += new Vector2(v, 0);
            }
        }

        static void LoadAllContents() {
            game.ResourcesManager.LoadBitmapFromFile("Content/grossini.png");
            game.ResourcesManager.LoadBitmapFromFile("Content/Sasuke-fireball.png");
        }

        static void Render(RenderArgs e) {
            e.SimpleRenderTarget.Clear(Color.White);
            game.EngineInfoDrawer.Draw(e.SimpleRenderTarget);
            game.SpriteManager.Draw(e.SimpleRenderTarget);
        }
    }
}
