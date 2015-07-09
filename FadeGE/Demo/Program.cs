﻿using System;
using System.Diagnostics;
using FadeGE;
using SharpDX;
using SharpDX.Direct2D1;

namespace Demo
{
    static class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args) {
            var random = new Random();
            using (var game = new Game(1024, 768, "FadeGameFramework Demo")) {
                var personList = new Shelly[1];
                for (var i = 0; i < personList.Length; i++) {
                    personList[i] = new Shelly();
                    var width = personList[i].TextureSize.Width;
                    var height = personList[i].TextureSize.Height;
                    personList[i].Position = new Vector2(0, 0);
                    //personList[i].V = new Vector2(random.Next(1, 100), random.Next(1, 100));
                    personList[i].V = new Vector2(0, 0);
                    game.SpriteManager.AddSprite(personList[i]);
                }
                game.RenderEvent += game_RenderEvent;
                game.Run();
            }
        }

        static void game_RenderEvent(RenderArgs e) {
            e.Target.Clear(Color.White);
            Game.Instance.SpriteManager.Draw(e.Target);
        }
    }
}
