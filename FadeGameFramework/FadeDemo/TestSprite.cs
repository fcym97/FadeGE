using Fade;
using SharpDX;


namespace FadeDemo
{
    class TestSprite : Sprite
    {

        public Vector2 V = new Vector2(100, 100);

        public TestSprite()
            : base("Content/grossini.png") {
            Tag = "TestSprite";
            Zorder = int.MaxValue;
            Position = new Vector2(100, 100);
        }

        public override void Update(float dt) {

        }
    }
}
