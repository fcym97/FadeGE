using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using SharpDX;
using SharpDX.Direct2D1;
using SharpDX.DXGI;
using SharpDX.Windows;
using AlphaMode = SharpDX.Direct2D1.AlphaMode;
using Factory = SharpDX.Direct2D1.Factory;
using System.Threading;

namespace FadeGE
{
    public class Game : IDisposable
    {
        public delegate void RenderDelegate(RenderArgs e);

        private readonly GameClock gameClock;
        private readonly List<IUpdatable> gameUpdatables;
        public readonly ResourcesManager ResourcesManager;
        public readonly SpriteManager SpriteManager;
        private RenderForm form;
        private WindowRenderTarget renderTarget;

        public Game(int width, int height, string title) {
            InitRenderTarget(width, height, title);
            gameClock = new GameClock();
            ResourcesManager = new ResourcesManager(renderTarget);
            SpriteManager = new SpriteManager();
            gameUpdatables = new List<IUpdatable>(10) {
                SpriteManager
            };
            Instance = this;
        }

        public static Game Instance { get; private set; }

        public void Dispose() {
            if (!renderTarget.IsDisposed) {
                renderTarget.Dispose();
            }
        }

        public event RenderDelegate RenderEvent;

        private void InitRenderTarget(int width, int height, string title) {
            form = new RenderForm {
                Size = new Size(width, height),
                StartPosition = FormStartPosition.CenterScreen,
                AutoScaleMode = AutoScaleMode.None,
                Text = title
            };


            var factory = new Factory(FactoryType.SingleThreaded);

            var hwndRenderTargetProperties = new HwndRenderTargetProperties {
                Hwnd = form.Handle,
                PixelSize = new Size2(form.Width, form.Height),
                PresentOptions = PresentOptions.RetainContents
            };

            var pixelFormat = new PixelFormat(Format.B8G8R8A8_UNorm, AlphaMode.Ignore);
            var renderTargetProperties = new RenderTargetProperties(
                RenderTargetType.Hardware, pixelFormat, 0, 0, RenderTargetUsage.None, FeatureLevel.Level_DEFAULT);

            renderTarget = new WindowRenderTarget(factory, renderTargetProperties, hwndRenderTargetProperties);
        }

        public void Run() {
            RenderLoop.Run(form, GameLoop);
        }

        private void GameLoop() {
            Debug.Assert(RenderEvent != null, "RenderEvent != null");

            gameClock.Start();

            foreach (var updatable in gameUpdatables) {
                updatable.Update(gameClock.DeltaTime);
            }

            renderTarget.BeginDraw();
            RenderEvent(new RenderArgs(renderTarget, gameClock.DeltaTime));
            renderTarget.EndDraw();

            gameClock.StopAndReset();
            Debug.WriteLine(1 / gameClock.DeltaTime);
        }
    }
}
