using System;
using System.Diagnostics;
using FadeGE;
using SharpDX;
using SharpDX.Direct2D1;

namespace Demo
{
    static class Program
    {

        private static void CreateTestSprites() {
            var random = new Random();
            var personList = new TestSprite[1];
            for (var i = 0; i < personList.Length; i++) {
                personList[i] = new TestSprite();
                var width = personList[i].FrameSize.Width;
                var height = personList[i].FrameSize.Height;
                personList[i].Position = new Vector2(random.Next(0, 1024 - (int)width), random.Next(0, 768 - (int)height));
                personList[i].V = new Vector2(random.Next(1, 100), random.Next(1, 100));

                Game.Instance.SpriteManager.AddSprite(personList[i]);
            }
        }

        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args) {
            using (var game = new Game(1024, 768, "FadeGameFramework Demo")) {
                LoadContent();
                CreateTestSprites();
                game.RenderEventHandler += game_RenderEvent;
                game.Run();
            }
        }

        static void LoadContent() {
            Game.Instance.ResourcesManager.LoadBitmapFromFile("Content/Sasuke-fireball.png");
        }

        static void game_RenderEvent(RenderArgs e) {
            e.SimpleRenderTarget.Clear(Color.White);
            Game.Instance.FpsManager.Draw(e.SimpleRenderTarget);
            Game.Instance.SpriteManager.Draw(e.SimpleRenderTarget);
        }


    }
}
