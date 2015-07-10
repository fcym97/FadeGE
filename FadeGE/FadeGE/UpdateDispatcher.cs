using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FadeGE;

namespace FadeGE
{
    public class UpdateDispatcher : IUpdatable
    {
        public double TotalSeconds { get; private set; }
        private readonly List<IUpdatable> updatableList = new List<IUpdatable>();
        private readonly List<float>  durationList = new List<float>();
        private readonly  List<float> pastTimeList = new List<float>();

        public void Update(float dt) {
            TotalSeconds += dt;
            for (var i = 0; i < pastTimeList.Count; i++) {
                pastTimeList[i] += dt;
                if (pastTimeList[i] > durationList[i]) {
                    pastTimeList[i] -= durationList[i];
                    updatableList[i].Update(dt);
                }
            }
        }

        public void AddComponent(IUpdatable updatable, float duration) {
            updatableList.Add(updatable);
            durationList.Add(duration);
            pastTimeList.Add(0);
        }

    }
}
