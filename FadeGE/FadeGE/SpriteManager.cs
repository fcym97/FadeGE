using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FadeGE
{
    public class SpriteManager :  IDrawable
    {
        private readonly List<Sprite> sprites = new List<Sprite>();

        public void AddSprite(Sprite sprite) {
            sprites.Add(sprite);
        }

        public void RemoveSprite(Sprite sprite) {
            sprites.Remove(sprite);
        }

        public void RemoveSpritesByTag(string tag) {
            sprites.RemoveAll(sprite => sprite.Tag == tag);
        }

        public void Draw(SimpleRenderTarget simpleRenderTarget) {
            foreach (var sprite in sprites) {
                simpleRenderTarget.DrawBitmap(sprite.Texture, sprite.FrameSize, sprite.Position, 
                    sprite.TrimAreaList[sprite.FrameIndex]);
            }
        }
    }
}
