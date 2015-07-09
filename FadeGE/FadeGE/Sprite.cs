using SharpDX;
using SharpDX.Direct2D1;

namespace FadeGE
{
    public class Sprite : IUpdatable
    {
        public Sprite(string path) {
            TextureId = Game.Instance.ResourcesManager.LoadBitmapFromFile(path);
            Texture = Game.Instance.ResourcesManager.GetResourceFromId(TextureId);
        }
        
        public int TextureId { get; set; }
        public Bitmap Texture { get; private set; }
        public Vector2 Position { get; set; }
        public float PositionX { get { return Position.X; } }
        public float PositionY { get { return Position.Y; } }
        public string Tag { get; set; }
        public int Zorder { get; set; }

        public virtual void Update(float dt) {
        }
    }
}
