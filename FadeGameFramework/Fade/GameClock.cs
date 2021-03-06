﻿using System.Diagnostics;
using System.Linq;

namespace Fade
{
    public sealed class GameClock
    {
        private readonly Stopwatch stopwatch= new Stopwatch();
        private float cacheDeltaTime = 1 / 60f;

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
