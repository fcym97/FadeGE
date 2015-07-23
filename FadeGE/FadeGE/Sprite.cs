using SharpDX;
using SharpDX.Direct2D1;
using System.Collections.Generic;

namespace FadeGE
{
    public class Sprite : IUpdatable
    {

        public delegate void SpriteActionDelegate(float dt);
        public readonly float AnimationDuration;
        public readonly int FrameCount;
        public readonly RectangleF[] TrimAreaList;
        private int frameIndex;

        public Sprite(string path, int row = 1, int col = 1, float animationDuration = 1f) {
            TextureId = Game.Instance.ResourcesManager.GetTextureIdFromPath(path);
            Texture = Game.Instance.ResourcesManager.GetResourceFromId(TextureId);
            Row = row;
            Col = col;
            AnimationDuration = animationDuration;
            FrameIndex = 0;
            FrameCount = Row * Col;
            TrimAreaList = new RectangleF[FrameCount];

            var rectWidth = TextureSize.Width / Col;
            var rectHeight = TextureSize.Height / Row;
            FrameSize = new Size2F(rectWidth, rectHeight);
            for (var i = 0; i < Col; i++) {
                for (var j = 0; j < Row; j++) {
                    TrimAreaList[i + j * Col] = new RectangleF(
                        i * rectWidth, j * rectHeight, rectWidth, rectHeight);
                }
            }
            Game.Instance.UpdateDispatcher.Schedule(AnimationUpdate, AnimationDuration);
            Game.Instance.UpdateDispatcher.Schedule(Update);
            //Game.Instance.UpdateDispatcher.Schedule(ActionUpdate);
        }

        private SpriteActionDelegate currentSpriteAction;

        private void ActionUpdate(float dt) {
        }

        public void StopAllActions() {
        }

        public int FrameIndex {
            get { return frameIndex % FrameCount; }
            private set { frameIndex = value; }
        }

        public Size2F FrameSize { get; private set; }

        public bool HasSpriteSheetAnimation => !(Row == 1 && Col == 1);

        public Vector2 Position { get; set; }

        public float PositionX {
            get { return Position.X; }
            set { Position = new Vector2(value, PositionY); }
        }

        public float PositionY {
            get { return Position.Y; }
            set { Position = new Vector2(PositionX, value); }
        }

        public string Tag { get; set; }

        public Bitmap Texture { get; private set; }

        public int TextureId { get; set; }

        public Size2F TextureSize => Texture.Size;

        public int Zorder { get; set; }

        public int Col { get; }

        public int Row { get; }

        public virtual void Update(float dt) { }

        public virtual void AnimationUpdate(float dt) {
            frameIndex++;
        }
    }
}