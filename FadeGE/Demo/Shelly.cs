using FadeGE;
using SharpDX;


namespace Demo
{
    class Shelly : Sprite
    {

        public Vector2 V = new Vector2(100, 100);

        public Shelly()
            : base("Content/Sasuke-fireball.png", true, 23, 1, 0.1f) {
            Tag = "Shelly";
            Zorder = int.MaxValue;
        }

        public override void Update(float dt) {
            Position += V * dt;
            if (Position.X + Texture.Size.Width > 1024 || Position.X <= 0) {
                V *= new Vector2(-1, 1);
            }
            if (Position.Y + Texture.Size.Height > 768 || Position.Y <= 0) {
                V *= new Vector2(1, -1);
            }
            base.Update(dt);
        }
    }
}
