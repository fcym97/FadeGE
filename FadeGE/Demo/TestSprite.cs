﻿using FadeGE;
using SharpDX;


namespace Demo
{
    class TestSprite : Sprite
    {

        public Vector2 V = new Vector2(100, 100);

        public TestSprite()
            : base("Content/Sasuke-fireball.png", 23, 1, 0.1f) {
            Tag = "TestSprite";
            Zorder = int.MaxValue;
        }

        public override void Update(float dt) {
            Position += V * dt;
            if (PositionX + TextureSize.Width > Game.Instance.WindowSize.Width || PositionX <= 0) {
                V *= new Vector2(-1, 1);
            }
            if (PositionY + TextureSize.Height > Game.Instance.WindowSize.Height || PositionY <= 0) {
                V *= new Vector2(1, -1);
            }
            base.Update(dt);
        }
    }
}