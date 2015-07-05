using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FadeGE
{
    public sealed class GameClock
    {
        private readonly Stopwatch stopwatch= new Stopwatch();
        private int p = 0;
        private readonly float[] deltaTimes = { 1 / 60f, 1 / 60f, 1 / 60f };

        public void Start() {
            stopwatch.Start();
        }

        public void StopAndReset() {
            stopwatch.Stop();
            deltaTimes[p++ % 3] = stopwatch.ElapsedMilliseconds / 1000f;
            stopwatch.Reset();
        }

        public float GetDeltaTime() {
            return deltaTimes.Average();
        }

    }
}
