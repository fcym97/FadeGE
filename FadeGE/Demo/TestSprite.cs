using FadeGE;
using SharpDX;


namespace Demo
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
