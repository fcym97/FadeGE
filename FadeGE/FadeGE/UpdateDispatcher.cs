using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FadeGE;

namespace FadeGE
{
    public sealed class UpdateDispatcher : IUpdatable
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

        /// <summary>
        /// 添加需要定时更新IUpdatable
        /// </summary>
        /// <param name="updatable">要更新的对象</param>
        /// <param name="duration">更新周期。单位是秒</param>
        public void AddIUpdatable(IUpdatable updatable, float duration) {
            updatableList.Add(updatable);
            durationList.Add(duration);
            pastTimeList.Add(0);
        }

    }
}
