using FadeGE;

namespace Demo
{
    static class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args) {
            using (var game = new Game(1024,768,"FadeGameFramework Demo")) {
                game.RenderEvent += game_RenderEvent;
                game.Run();
            }
        }

        static void game_RenderEvent(RenderArgs e) {
            e.Target.Clear(Color.White);
        }
    }
}
