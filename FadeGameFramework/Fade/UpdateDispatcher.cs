using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fade;

namespace Fade
{
    public sealed class UpdateDispatcher : IUpdatable
    {
        public delegate void UpdateDelegate(float dt);

        public double TotalSeconds { get; private set; }
        public int UpdatableListCount => updatableList.Count;

        private readonly List<UpdateDelegate> updatableList = new List<UpdateDelegate>();
        private readonly List<float> durationList = new List<float>();
        private readonly List<float> pastTimeList = new List<float>();

        public void Update(float dt) {
            TotalSeconds += dt;
            for (var i = 0; i < pastTimeList.Count; i++) {
                pastTimeList[i] += dt;
                if (pastTimeList[i] > durationList[i]) {
                    pastTimeList[i] -= durationList[i];
                    updatableList[i](dt);
                }
            }
        }

        /// <summary>
        /// 添加需要定时调用的方法
        /// </summary>
        /// <param name="updateMethod">需要定时调用的方法</param>
        /// <param name="duration">更新周期。单位是秒</param>
        public void Schedule(UpdateDelegate updateMethod, float duration = 0) {
            updatableList.Add(updateMethod);
            durationList.Add(duration);
            pastTimeList.Add(0);
        }

    }
}
