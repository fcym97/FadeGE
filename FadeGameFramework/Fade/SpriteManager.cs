using System.Collections.Generic;

namespace Fade
{
    public class SpriteManager : IDrawable
    {
        private readonly List<Sprite> spriteList = new List<Sprite>();

        public int SpriteCount => spriteList.Count;

        public void AddSprite(Sprite sprite) {
            spriteList.Add(sprite);
        }

        public void RemoveSprite(Sprite sprite) {
            spriteList.Remove(sprite);
        }

        public void RemoveSpritesByTag(string tag) {
            spriteList.RemoveAll(sprite => sprite.Tag == tag);
        }

        public void Draw(SimpleRenderTarget simpleRenderTarget) {
            foreach (var sprite in spriteList) {
                simpleRenderTarget.DrawBitmap(sprite.Texture, sprite.FrameSize, sprite.Position,
                    sprite.TrimAreaList[sprite.FrameIndex]);
            }
        }
    }
}
