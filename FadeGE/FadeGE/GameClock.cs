using System.Diagnostics;
using System.Linq;

namespace FadeGE
{
    public sealed class GameClock
    {
        private readonly Stopwatch stopwatch= new Stopwatch();
        private float cacheDeltaTime;

        public void Start() {
            stopwatch.Start();
        }

        public void StopAndReset() {
            stopwatch.Stop();
            cacheDeltaTime = stopwatch.ElapsedMilliseconds / 1000f;
            stopwatch.Reset();
        }

        public float DeltaTime { get { return cacheDeltaTime; } }
    }
}
