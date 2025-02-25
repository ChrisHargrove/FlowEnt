using UnityEngine;
using FriedSynapse.FlowEnt.Motions.Transforms;

namespace FriedSynapse.FlowEnt
{
    public static class TransformMotionExtensions
    {
        #region Move

        #region Move

        public static TweenMotion<TTransform> Move<TTransform>(this TweenMotion<TTransform> motionWrapper, Vector3 value)
            where TTransform : Transform
            => motionWrapper.Apply(new MoveVectorMotion<TTransform>(motionWrapper.Item, value));

        public static TweenMotion<TTransform> MoveX<TTransform>(this TweenMotion<TTransform> motionWrapper, float x)
            where TTransform : Transform
            => motionWrapper.Apply(new MoveVectorMotion<TTransform>(motionWrapper.Item, new Vector3(x, 0f, 0f)));

        public static TweenMotion<TTransform> MoveY<TTransform>(this TweenMotion<TTransform> motionWrapper, float y)
            where TTransform : Transform
            => motionWrapper.Apply(new MoveVectorMotion<TTransform>(motionWrapper.Item, new Vector3(0f, y, 0f)));

        public static TweenMotion<TTransform> MoveZ<TTransform>(this TweenMotion<TTransform> motionWrapper, float z)
            where TTransform : Transform
            => motionWrapper.Apply(new MoveVectorMotion<TTransform>(motionWrapper.Item, new Vector3(0f, 0f, z)));

        public static TweenMotion<TTransform> MoveLocal<TTransform>(this TweenMotion<TTransform> motionWrapper, Vector3 value)
            where TTransform : Transform
            => motionWrapper.Apply(new MoveLocalVectorMotion<TTransform>(motionWrapper.Item, value));

        public static TweenMotion<TTransform> MoveLocalX<TTransform>(this TweenMotion<TTransform> motionWrapper, float x)
            where TTransform : Transform
            => motionWrapper.Apply(new MoveLocalVectorMotion<TTransform>(motionWrapper.Item, new Vector3(x, 0f, 0f)));

        public static TweenMotion<TTransform> MoveLocalY<TTransform>(this TweenMotion<TTransform> motionWrapper, float y)
            where TTransform : Transform
            => motionWrapper.Apply(new MoveLocalVectorMotion<TTransform>(motionWrapper.Item, new Vector3(0f, y, 0f)));

        public static TweenMotion<TTransform> MoveLocalZ<TTransform>(this TweenMotion<TTransform> motionWrapper, float z)
            where TTransform : Transform
            => motionWrapper.Apply(new MoveLocalVectorMotion<TTransform>(motionWrapper.Item, new Vector3(0f, 0f, z)));

        #endregion

        #region MoveTo

        public static TweenMotion<TTransform> MoveTo<TTransform>(this TweenMotion<TTransform> motionWrapper, Vector3 to)
            where TTransform : Transform
            => motionWrapper.Apply(new MoveToVectorMotion<TTransform>(motionWrapper.Item, to));

        public static TweenMotion<TTransform> MoveTo<TTransform>(this TweenMotion<TTransform> motionWrapper, Vector3 from, Vector3 to)
            where TTransform : Transform
            => motionWrapper.Apply(new MoveToVectorMotion<TTransform>(motionWrapper.Item, from, to));

        public static TweenMotion<TTransform> MoveLocalTo<TTransform>(this TweenMotion<TTransform> motionWrapper, Vector3 to)
            where TTransform : Transform
            => motionWrapper.Apply(new MoveLocalToVectorMotion<TTransform>(motionWrapper.Item, to));

        public static TweenMotion<TTransform> MoveLocalTo<TTransform>(this TweenMotion<TTransform> motionWrapper, Vector3 from, Vector3 to)
            where TTransform : Transform
            => motionWrapper.Apply(new MoveLocalToVectorMotion<TTransform>(motionWrapper.Item, from, to));

        #endregion

        #region MoveTo AnimationCurve3d

        public static TweenMotion<TTransform> MoveTo<TTransform>(this TweenMotion<TTransform> motionWrapper, AnimationCurve3d animationCurve)
            where TTransform : Transform
            => motionWrapper.Apply(new MoveToAnimationCurve3dMotion<TTransform>(motionWrapper.Item, animationCurve));

        public static TweenMotion<TTransform> MoveLocalTo<TTransform>(this TweenMotion<TTransform> motionWrapper, AnimationCurve3d animationCurve)
            where TTransform : Transform
            => motionWrapper.Apply(new MoveLocalToAnimationCurve3dMotion<TTransform>(motionWrapper.Item, animationCurve));

        #endregion

        #region MoveTo Axis

        public static TweenMotion<TTransform> MoveToX<TTransform>(this TweenMotion<TTransform> motionWrapper, float to)
                    where TTransform : Transform
                    => motionWrapper.Apply(new MoveToAxisMotion<TTransform>(motionWrapper.Item, Axis.X, to));

        public static TweenMotion<TTransform> MoveToX<TTransform>(this TweenMotion<TTransform> motionWrapper, float from, float to)
            where TTransform : Transform
            => motionWrapper.Apply(new MoveToAxisMotion<TTransform>(motionWrapper.Item, Axis.X, from, to));

        public static TweenMotion<TTransform> MoveToY<TTransform>(this TweenMotion<TTransform> motionWrapper, float to)
            where TTransform : Transform
            => motionWrapper.Apply(new MoveToAxisMotion<TTransform>(motionWrapper.Item, Axis.Y, to));

        public static TweenMotion<TTransform> MoveToY<TTransform>(this TweenMotion<TTransform> motionWrapper, float from, float to)
            where TTransform : Transform
            => motionWrapper.Apply(new MoveToAxisMotion<TTransform>(motionWrapper.Item, Axis.Y, from, to));

        public static TweenMotion<TTransform> MoveToZ<TTransform>(this TweenMotion<TTransform> motionWrapper, float to)
            where TTransform : Transform
            => motionWrapper.Apply(new MoveToAxisMotion<TTransform>(motionWrapper.Item, Axis.Z, to));

        public static TweenMotion<TTransform> MoveToZ<TTransform>(this TweenMotion<TTransform> motionWrapper, float from, float to)
            where TTransform : Transform
            => motionWrapper.Apply(new MoveToAxisMotion<TTransform>(motionWrapper.Item, Axis.Z, from, to));

        public static TweenMotion<TTransform> MoveLocalToX<TTransform>(this TweenMotion<TTransform> motionWrapper, float to)
                    where TTransform : Transform
                    => motionWrapper.Apply(new MoveLocalToAxisMotion<TTransform>(motionWrapper.Item, Axis.X, to));

        public static TweenMotion<TTransform> MoveLocalToX<TTransform>(this TweenMotion<TTransform> motionWrapper, float from, float to)
            where TTransform : Transform
            => motionWrapper.Apply(new MoveLocalToAxisMotion<TTransform>(motionWrapper.Item, Axis.X, from, to));

        public static TweenMotion<TTransform> MoveLocalToY<TTransform>(this TweenMotion<TTransform> motionWrapper, float to)
            where TTransform : Transform
            => motionWrapper.Apply(new MoveLocalToAxisMotion<TTransform>(motionWrapper.Item, Axis.Y, to));

        public static TweenMotion<TTransform> MoveLocalToY<TTransform>(this TweenMotion<TTransform> motionWrapper, float from, float to)
            where TTransform : Transform
            => motionWrapper.Apply(new MoveLocalToAxisMotion<TTransform>(motionWrapper.Item, Axis.Y, from, to));

        public static TweenMotion<TTransform> MoveLocalToZ<TTransform>(this TweenMotion<TTransform> motionWrapper, float to)
            where TTransform : Transform
            => motionWrapper.Apply(new MoveLocalToAxisMotion<TTransform>(motionWrapper.Item, Axis.Z, to));

        public static TweenMotion<TTransform> MoveLocalToZ<TTransform>(this TweenMotion<TTransform> motionWrapper, float from, float to)
            where TTransform : Transform
            => motionWrapper.Apply(new MoveLocalToAxisMotion<TTransform>(motionWrapper.Item, Axis.Z, from, to));

        #endregion

        #region MoveTo Spline

        public static TweenMotion<TTransform> MoveTo<TTransform>(this TweenMotion<TTransform> motionWrapper, ISpline spline)
            where TTransform : Transform
            => motionWrapper.Apply(new MoveToSplineMotion<TTransform>(motionWrapper.Item, spline));

        public static TweenMotion<TTransform> MoveLocalTo<TTransform>(this TweenMotion<TTransform> motionWrapper, ISpline spline)
            where TTransform : Transform
            => motionWrapper.Apply(new MoveLocalToSplineMotion<TTransform>(motionWrapper.Item, spline));

        #endregion

        #endregion

        #region Rotate

        #region Rotate

        public static TweenMotion<TTransform> Rotate<TTransform>(this TweenMotion<TTransform> motionWrapper, Quaternion value)
            where TTransform : Transform
            => motionWrapper.Apply(new RotateQuaternionMotion<TTransform>(motionWrapper.Item, value));

        public static TweenMotion<TTransform> Rotate<TTransform>(this TweenMotion<TTransform> motionWrapper, Vector3 value)
            where TTransform : Transform
            => motionWrapper.Apply(new RotateVectorMotion<TTransform>(motionWrapper.Item, value));

        public static TweenMotion<TTransform> RotateX<TTransform>(this TweenMotion<TTransform> motionWrapper, float x)
            where TTransform : Transform
            => motionWrapper.Apply(new RotateVectorMotion<TTransform>(motionWrapper.Item, new Vector3(x, 0f, 0f)));

        public static TweenMotion<TTransform> RotateY<TTransform>(this TweenMotion<TTransform> motionWrapper, float y)
            where TTransform : Transform
            => motionWrapper.Apply(new RotateVectorMotion<TTransform>(motionWrapper.Item, new Vector3(0f, y, 0f)));

        public static TweenMotion<TTransform> RotateZ<TTransform>(this TweenMotion<TTransform> motionWrapper, float z)
            where TTransform : Transform
            => motionWrapper.Apply(new RotateVectorMotion<TTransform>(motionWrapper.Item, new Vector3(0f, 0f, z)));

        #endregion

        #region RotateTo

        public static TweenMotion<TTransform> RotateTo<TTransform>(this TweenMotion<TTransform> motionWrapper, Quaternion to)
            where TTransform : Transform
            => motionWrapper.Apply(new RotateToQuaternionMotion<TTransform>(motionWrapper.Item, to));

        public static TweenMotion<TTransform> RotateTo<TTransform>(this TweenMotion<TTransform> motionWrapper, Quaternion from, Quaternion to)
            where TTransform : Transform
            => motionWrapper.Apply(new RotateToQuaternionMotion<TTransform>(motionWrapper.Item, from, to));

        public static TweenMotion<TTransform> RotateTo<TTransform>(this TweenMotion<TTransform> motionWrapper, Vector3 to)
            where TTransform : Transform
            => motionWrapper.Apply(new RotateToVectorMotion<TTransform>(motionWrapper.Item, to));

        public static TweenMotion<TTransform> RotateTo<TTransform>(this TweenMotion<TTransform> motionWrapper, Vector3 from, Vector3 to)
            where TTransform : Transform
            => motionWrapper.Apply(new RotateToVectorMotion<TTransform>(motionWrapper.Item, from, to));

        public static TweenMotion<TTransform> RotateToX<TTransform>(this TweenMotion<TTransform> motionWrapper, float to)
            where TTransform : Transform
            => motionWrapper.Apply(new RotateToAxisMotion<TTransform>(motionWrapper.Item, Axis.X, to));

        public static TweenMotion<TTransform> RotateToX<TTransform>(this TweenMotion<TTransform> motionWrapper, float from, float to)
            where TTransform : Transform
            => motionWrapper.Apply(new RotateToAxisMotion<TTransform>(motionWrapper.Item, Axis.X, from, to));

        public static TweenMotion<TTransform> RotateToY<TTransform>(this TweenMotion<TTransform> motionWrapper, float to)
            where TTransform : Transform
            => motionWrapper.Apply(new RotateToAxisMotion<TTransform>(motionWrapper.Item, Axis.Y, to));

        public static TweenMotion<TTransform> RotateToY<TTransform>(this TweenMotion<TTransform> motionWrapper, float from, float to)
            where TTransform : Transform
            => motionWrapper.Apply(new RotateToAxisMotion<TTransform>(motionWrapper.Item, Axis.Y, from, to));

        public static TweenMotion<TTransform> RotateToZ<TTransform>(this TweenMotion<TTransform> motionWrapper, float to)
            where TTransform : Transform
            => motionWrapper.Apply(new RotateToAxisMotion<TTransform>(motionWrapper.Item, Axis.Z, to));

        public static TweenMotion<TTransform> RotateToZ<TTransform>(this TweenMotion<TTransform> motionWrapper, float from, float to)
            where TTransform : Transform
            => motionWrapper.Apply(new RotateToAxisMotion<TTransform>(motionWrapper.Item, Axis.Z, from, to));

        public static TweenMotion<TTransform> RotateLocalTo<TTransform>(this TweenMotion<TTransform> motionWrapper, Quaternion to)
            where TTransform : Transform
            => motionWrapper.Apply(new RotateLocalToQuaternionMotion<TTransform>(motionWrapper.Item, to));

        public static TweenMotion<TTransform> RotateLocalTo<TTransform>(this TweenMotion<TTransform> motionWrapper, Quaternion from, Quaternion to)
            where TTransform : Transform
            => motionWrapper.Apply(new RotateLocalToQuaternionMotion<TTransform>(motionWrapper.Item, from, to));

        public static TweenMotion<TTransform> RotateLocalTo<TTransform>(this TweenMotion<TTransform> motionWrapper, Vector3 to)
            where TTransform : Transform
            => motionWrapper.Apply(new RotateLocalToVectorMotion<TTransform>(motionWrapper.Item, to));

        public static TweenMotion<TTransform> RotateLocalTo<TTransform>(this TweenMotion<TTransform> motionWrapper, Vector3 from, Vector3 to)
            where TTransform : Transform
            => motionWrapper.Apply(new RotateLocalToVectorMotion<TTransform>(motionWrapper.Item, from, to));

        public static TweenMotion<TTransform> RotateLocalToX<TTransform>(this TweenMotion<TTransform> motionWrapper, float to)
            where TTransform : Transform
            => motionWrapper.Apply(new RotateLocalToAxisMotion<TTransform>(motionWrapper.Item, Axis.X, to));

        public static TweenMotion<TTransform> RotateLocalToX<TTransform>(this TweenMotion<TTransform> motionWrapper, float from, float to)
            where TTransform : Transform
            => motionWrapper.Apply(new RotateLocalToAxisMotion<TTransform>(motionWrapper.Item, Axis.X, from, to));

        public static TweenMotion<TTransform> RotateLocalToY<TTransform>(this TweenMotion<TTransform> motionWrapper, float to)
            where TTransform : Transform
            => motionWrapper.Apply(new RotateLocalToAxisMotion<TTransform>(motionWrapper.Item, Axis.Y, to));

        public static TweenMotion<TTransform> RotateLocalToY<TTransform>(this TweenMotion<TTransform> motionWrapper, float from, float to)
            where TTransform : Transform
            => motionWrapper.Apply(new RotateLocalToAxisMotion<TTransform>(motionWrapper.Item, Axis.Y, from, to));

        public static TweenMotion<TTransform> RotateLocalToZ<TTransform>(this TweenMotion<TTransform> motionWrapper, float to)
            where TTransform : Transform
            => motionWrapper.Apply(new RotateLocalToAxisMotion<TTransform>(motionWrapper.Item, Axis.Z, to));

        public static TweenMotion<TTransform> RotateLocalToZ<TTransform>(this TweenMotion<TTransform> motionWrapper, float from, float to)
            where TTransform : Transform
            => motionWrapper.Apply(new RotateLocalToAxisMotion<TTransform>(motionWrapper.Item, Axis.Z, from, to));

        #endregion

        #region LookAt

        public static TweenMotion<TTransform> LookAt<TTransform>(this TweenMotion<TTransform> motionWrapper, Transform target)
            where TTransform : Transform
            => motionWrapper.Apply(new LookAtTransformMotion<TTransform>(motionWrapper.Item, target));

        public static TweenMotion<TTransform> LookAt<TTransform>(this TweenMotion<TTransform> motionWrapper, Vector3 target)
            where TTransform : Transform
            => motionWrapper.Apply(new LookAtVector3Motion<TTransform>(motionWrapper.Item, target));

        #endregion

        #region OrientToPath

        public static TweenMotion<TTransform> OrientToPath<TTransform>(this TweenMotion<TTransform> motionWrapper)
            where TTransform : Transform
            => motionWrapper.Apply(new OrientToPathMotion<TTransform>(motionWrapper.Item));

        #endregion

        #endregion

        #region Scale

        #region Scale

        public static TweenMotion<TTransform> Scale<TTransform>(this TweenMotion<TTransform> motionWrapper, Vector3 value)
            where TTransform : Transform
            => motionWrapper.Apply(new ScaleVectorMotion<TTransform>(motionWrapper.Item, value));

        public static TweenMotion<TTransform> ScaleX<TTransform>(this TweenMotion<TTransform> motionWrapper, float x)
            where TTransform : Transform
            => motionWrapper.Apply(new ScaleVectorMotion<TTransform>(motionWrapper.Item, new Vector3(x, 1f, 1f)));

        public static TweenMotion<TTransform> ScaleY<TTransform>(this TweenMotion<TTransform> motionWrapper, float y)
            where TTransform : Transform
            => motionWrapper.Apply(new ScaleVectorMotion<TTransform>(motionWrapper.Item, new Vector3(1f, y, 1f)));

        public static TweenMotion<TTransform> ScaleZ<TTransform>(this TweenMotion<TTransform> motionWrapper, float z)
            where TTransform : Transform
            => motionWrapper.Apply(new ScaleVectorMotion<TTransform>(motionWrapper.Item, new Vector3(1f, 1f, z)));

        #endregion

        #region ScaleToLocal

        public static TweenMotion<TTransform> ScaleLocalTo<TTransform>(this TweenMotion<TTransform> motionWrapper, Vector3 to)
            where TTransform : Transform
            => motionWrapper.Apply(new ScaleLocalToVectorMotion<TTransform>(motionWrapper.Item, to));

        public static TweenMotion<TTransform> ScaleLocalTo<TTransform>(this TweenMotion<TTransform> motionWrapper, Vector3 from, Vector3 to)
            where TTransform : Transform
            => motionWrapper.Apply(new ScaleLocalToVectorMotion<TTransform>(motionWrapper.Item, from, to));

        #endregion

        #region ScaleToLocal AnimationCurve3d

        public static TweenMotion<TTransform> ScaleLocalTo<TTransform>(this TweenMotion<TTransform> motionWrapper, AnimationCurve3d animationCurve)
            where TTransform : Transform
            => motionWrapper.Apply(new ScaleLocalToAnimationCurve3dMotion<TTransform>(motionWrapper.Item, animationCurve));

        #endregion

        #region ScaleToLocal Axis

        public static TweenMotion<TTransform> ScaleLocalToX<TTransform>(this TweenMotion<TTransform> motionWrapper, float to)
            where TTransform : Transform
            => motionWrapper.Apply(new ScaleLocalToAxisMotion<TTransform>(motionWrapper.Item, Axis.X, to));

        public static TweenMotion<TTransform> ScaleLocalToX<TTransform>(this TweenMotion<TTransform> motionWrapper, float from, float to)
            where TTransform : Transform
            => motionWrapper.Apply(new ScaleLocalToAxisMotion<TTransform>(motionWrapper.Item, Axis.X, from, to));

        public static TweenMotion<TTransform> ScaleLocalToY<TTransform>(this TweenMotion<TTransform> motionWrapper, float to)
            where TTransform : Transform
            => motionWrapper.Apply(new ScaleLocalToAxisMotion<TTransform>(motionWrapper.Item, Axis.Y, to));

        public static TweenMotion<TTransform> ScaleLocalToY<TTransform>(this TweenMotion<TTransform> motionWrapper, float from, float to)
            where TTransform : Transform
            => motionWrapper.Apply(new ScaleLocalToAxisMotion<TTransform>(motionWrapper.Item, Axis.Y, from, to));

        public static TweenMotion<TTransform> ScaleLocalToZ<TTransform>(this TweenMotion<TTransform> motionWrapper, float to)
            where TTransform : Transform
            => motionWrapper.Apply(new ScaleLocalToAxisMotion<TTransform>(motionWrapper.Item, Axis.Z, to));

        public static TweenMotion<TTransform> ScaleLocalToZ<TTransform>(this TweenMotion<TTransform> motionWrapper, float from, float to)
            where TTransform : Transform
            => motionWrapper.Apply(new ScaleLocalToAxisMotion<TTransform>(motionWrapper.Item, Axis.Z, from, to));

        #endregion

        #endregion
    }
}