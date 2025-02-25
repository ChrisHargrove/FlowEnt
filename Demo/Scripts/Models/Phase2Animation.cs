using System;
using System.Collections.Generic;
using UnityEngine;

namespace FriedSynapse.FlowEnt.Demo
{
    [Serializable]
    public class Phase2Animation : AbstractDemoAnimation
    {
        [SerializeField]
        private List<Transform> blowers;
        private List<Transform> Blowers => blowers;

        public override AbstractAnimation GetAnimation()
            => new Flow()
                .Queue(GetAnimation(Blowers[0]))
                .At(1f, GetAnimation(Blowers[1]))
                .At(2f, GetAnimation(Blowers[2]))
                .At(3f, GetAnimation(Blowers[3]));

        private AbstractAnimation GetAnimation(Transform transform)
            => new Tween(3f)
                .For(transform).MoveLocalToY(2f).ScaleLocalTo(Vector3.one * 5f)
                .For(transform.GetComponent<MeshRenderer>()).LateAlphaTo(0, 0.8f)
                .OnCompleted(() => transform.gameObject.SetActive(false));
    }
}
