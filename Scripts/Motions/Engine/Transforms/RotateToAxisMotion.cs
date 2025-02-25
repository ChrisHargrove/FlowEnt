using UnityEngine;

namespace FriedSynapse.FlowEnt.Motions.Transforms
{
    public class RotateToAxisMotion<TTransform> : AbstractMotion<TTransform>
        where TTransform : Transform
    {
        public RotateToAxisMotion(TTransform item, Axis axis, float to) : base(item)
        {
            this.to = to;
            this.axis = axis;
        }

        public RotateToAxisMotion(TTransform item, Axis axis, float from, float to) : this(item, axis, to)
        {
            hasFrom = true;
            this.from = from;
        }

        private readonly Axis axis;
        private readonly bool hasFrom;
        private float from;
        private readonly float to;

        private float valueCache;
        private Vector3 rotationCache;

        public override void OnStart()
        {
            if (!hasFrom)
            {
                switch (axis)
                {
                    case Axis.X:
                    case Axis.XY:
                    case Axis.XZ:
                    case Axis.XYZ:
                        from = item.eulerAngles.x;
                        break;
                    case Axis.Y:
                    case Axis.YZ:
                        from = item.eulerAngles.y;
                        break;
                    case Axis.Z:
                        from = item.eulerAngles.z;
                        break;
                }
            }
        }

        public override void OnUpdate(float t)
        {
            rotationCache = item.eulerAngles;
            valueCache = Mathf.LerpUnclamped(from, to, t);

            if ((axis & Axis.X) != 0)
            {
                rotationCache.x = valueCache;
            }
            if ((axis & Axis.Y) != 0)
            {
                rotationCache.y = valueCache;
            }
            if ((axis & Axis.Z) != 0)
            {
                rotationCache.z = valueCache;
            }

            item.eulerAngles = rotationCache;
        }
    }
}