using SharpDX;
using SharpDX.Direct2D1;

namespace FadeGE
{
    public class Sprite : IUpdatable
    {
        public readonly int FrameCount;
        public readonly RectangleF[] TrimAreaList;
        public readonly float Duration;
        private float elaspedTime;
        private int frameIndex;

        public Sprite(string path, bool isSpriteSheet = false, int row = 1, int col = 1, float duration = 1f) {
            TextureId = Game.Instance.ResourcesManager.LoadBitmapFromFile(path);
            Texture = Game.Instance.ResourcesManager.GetResourceFromId(TextureId);
            HasSpriteSheetAnimation = isSpriteSheet;
            Row = row;
            Col = col;
            Duration = duration;
            FrameIndex = 0;
            FrameCount = Row * Col;
            TrimAreaList = new RectangleF[FrameCount];
            if (HasSpriteSheetAnimation) {
                var rectWidth = TextureSize.Width / Col;
                var rectHeight = TextureSize.Height / Row;
                FrameSize = new Size2F(rectWidth, rectHeight);
                for (var i = 0; i < Col; i++) {
                    for (var j = 0; j < Row; j++) {
                        TrimAreaList[i + j * Col] = new RectangleF(
                            i * rectWidth, j * rectHeight, rectWidth, rectHeight);
                    }
                }
            }
        }

        public int FrameIndex {
            get { return frameIndex % FrameCount; }
            private set { frameIndex = value; }
        }

        public Size2F FrameSize { get; private set; }

        public bool HasSpriteSheetAnimation { get; private set; }

        public Vector2 Position { get; set; }

        public float PositionX {
            get { return Position.X; }
        }

        public float PositionY {
            get { return Position.Y; }
        }

        public string Tag { get; set; }

        public Bitmap Texture { get; private set; }

        public int TextureId { get; set; }

        public Size2F TextureSize {
            get { return Texture.Size; }
        }

        public int Zorder { get; set; }

        private int Col { get; set; }

        private int Row { get; set; }

        public virtual void Update(float dt) {
            elaspedTime += dt;
            if (elaspedTime > Duration) {
                elaspedTime -= Duration;
                frameIndex++;
            }
        }
    }
}