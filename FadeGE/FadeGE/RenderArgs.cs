﻿using SharpDX.Direct2D1;

namespace FadeGE
{
    public class RenderArgs
    {
        public readonly float DeltaTime;
        public readonly SimpleRenderTarget SimpleRenderTarget;

        public RenderArgs(RenderTarget target, float dt) {
            SimpleRenderTarget = new SimpleRenderTarget(target);
            DeltaTime = dt;
        }
    }
}