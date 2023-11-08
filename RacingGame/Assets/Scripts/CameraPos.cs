using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public abstract class CameraPos
    {
        protected Transform _cameraTransform;
        protected Transform _carTransform;
        public CameraPos(Transform cameraTransform, Transform carTransform)
        {
            _cameraTransform = cameraTransform;
            _carTransform = carTransform;
        }
        public abstract void Enter();
        public abstract void SetCameraPos();
        public abstract void Exit();
    }
}
