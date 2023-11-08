using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.CameraPositions
{
    public class CameraRoad : CameraPos
    {
        /*public float CarAngleX;
        public float CarAngleY;
        public float CarAngleZ;*/
        public float CarX;
        public float CarY;
        public float CarZ;
        public CameraRoad(Transform cameraTransform, Transform carTransform) : base(cameraTransform, carTransform)
        {
        }

        public override void SetCameraPos()
        {
            CarX = _carTransform.eulerAngles.x;
            CarY = _carTransform.eulerAngles.y;
            CarZ = _carTransform.eulerAngles.z;

            _cameraTransform.eulerAngles = new Vector3(CarX, CarY, CarZ);
        }

        public override void Enter()
        {
            _cameraTransform.Translate(0, -1.3f, 6.8f);
        }

        public override void Exit()
        {
            _cameraTransform.Translate(0, 1.3f, -6.8f);
        }
    }
}
