using System;
using System.Diagnostics;
using System.Windows.Forms;
using SharpDX;
using SharpDX.Direct2D1;
using SharpDX.Windows;
using Format = SharpDX.DXGI.Format;

namespace FadeGE
{
    public class Game : IDisposable
    {
        private readonly RenderForm form;

        private readonly WindowRenderTarget target;

        public delegate void RenderDelegate(RenderArgs e);

        public event RenderDelegate RenderEvent;

        public Game(int width, int height, string title) {
            form = new RenderForm {
                Size = new System.Drawing.Size(width, height),
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

            target = new WindowRenderTarget(factory, renderTargetProperties, hwndRenderTargetProperties);
        }

        public void Dispose() {
            if (!target.IsDisposed) {
                target.Dispose();
            }
        }

        public void Run() {
            RenderLoop.Run(form, Render);
        }

        private void Render() {
            Debug.Assert(RenderEvent != null, "RenderEvent != null");
            target.BeginDraw();
            RenderEvent(new RenderArgs(target, 0.0f));
            target.EndDraw();
        }
    }

    public class FRenderTarget
    {
        private readonly RenderTarget target;

        public FRenderTarget(RenderTarget target) {
            this.target = target;
        }

        public void Clear(Color color) {
            target.Clear(color);
        }
    }

    public class RenderArgs
    {
        public readonly FRenderTarget Target;
        public readonly float DeltaTime;

        public RenderArgs(RenderTarget target, float dt) {
            Target = new FRenderTarget(target);
            DeltaTime = dt;
        }
    }
}