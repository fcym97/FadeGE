using SharpDX.Direct2D1;

namespace FadeGE
{
    public class RenderArgs
    {
        public readonly float DeltaTime;
        public readonly SimpleRenderTarget Target;

        public RenderArgs(RenderTarget target, float dt) {
            Target = new SimpleRenderTarget(target);
            DeltaTime = dt;
        }
    }
}