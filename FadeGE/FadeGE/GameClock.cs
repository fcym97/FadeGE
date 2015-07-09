using System.Diagnostics;
using System.Linq;

namespace FadeGE
{
    public sealed class GameClock
    {
        private const int BUFFER_SIZE = 3;
        private const int DEFAULT_FPS = 60;
        private readonly Stopwatch stopwatch= new Stopwatch();
        private int index;
        private readonly float[] deltaTimes;
        private bool isDirty = true;
        private float cacheDeltaTime;

        public GameClock()
            : this(DEFAULT_FPS) {
        }

        public GameClock(int prefferedFps) {
            deltaTimes = new float[BUFFER_SIZE];
            var interval = 1f / prefferedFps;
            for (var i = 0; i < deltaTimes.Length; i++) {
                deltaTimes[i] = interval;
            }
        }

        public void Start() {
            stopwatch.Start();
        }

        public void StopAndReset() {
            stopwatch.Stop();
            index %= BUFFER_SIZE;
            deltaTimes[index++] = stopwatch.ElapsedMilliseconds / 1000f;
            isDirty = true;
            stopwatch.Reset();
        }

        public float GetDeltaTime() {
            if (!isDirty) {
                return cacheDeltaTime;
            }
            cacheDeltaTime = deltaTimes.Average();
            isDirty = false;
            return cacheDeltaTime;
        }

    }
}
