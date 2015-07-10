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

namespace FadeGE
{
    public class Game : IDisposable
    {
        public readonly UpdateDispatcher UpdateDispatcher;

        public readonly FpsManager FpsManager;

        public readonly ResourcesManager ResourcesManager;

        public readonly SpriteManager SpriteManager;

        private readonly GameClock gameClock;

        private RenderForm form;

        private WindowRenderTarget renderTarget;

        public Game(int width, int height, string title) {
            InitRenderComponent(width, height, title);
            ResourcesManager = new ResourcesManager(renderTarget);//todo 增加载入资源事件
            gameClock = new GameClock();
            UpdateDispatcher = new UpdateDispatcher();
            SpriteManager = new SpriteManager();
            FpsManager = new FpsManager(renderTarget);
            UpdateDispatcher.AddComponent(FpsManager, 0.4f);
            UpdateDispatcher.AddComponent(SpriteManager, 0);
            Instance = this;
        }

        public delegate void RenderDelegate(RenderArgs e);

        public event RenderDelegate RenderEventHandler;

        public static Game Instance { get; private set; }

        public void Dispose() {
            if (!renderTarget.IsDisposed) {
                renderTarget.Dispose();
            }
        }

        public void Run() {
            RenderLoop.Run(form, GameLoop);
        }

        private void GameLoop() {
            Debug.Assert(RenderEventHandler != null, "RenderEvent != null");
            //开始计时
            gameClock.Start();
            //更新所有需要更新的组件
            UpdateDispatcher.Update(gameClock.DeltaTime);
            //绘图
            renderTarget.BeginDraw();
            RenderEventHandler(new RenderArgs(renderTarget, gameClock.DeltaTime));
            renderTarget.EndDraw();
            //停止计时
            gameClock.StopAndReset();
        }

        /// <summary>
        /// 初始化绘图有关组件
        /// </summary>
        /// <param name="width">游戏窗口宽度</param>
        /// <param name="height">游戏窗口高度</param>
        /// <param name="title">游戏窗口标题</param>
        private void InitRenderComponent(int width, int height, string title) {
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
                PresentOptions = PresentOptions.None
            };

            var pixelFormat = new PixelFormat(Format.B8G8R8A8_UNorm, AlphaMode.Ignore);
            var renderTargetProperties = new RenderTargetProperties(
                RenderTargetType.Hardware, pixelFormat, 0, 0, RenderTargetUsage.None, FeatureLevel.Level_DEFAULT);

            renderTarget = new WindowRenderTarget(factory, renderTargetProperties, hwndRenderTargetProperties);
        }
    }
}