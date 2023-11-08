using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class CameraStateMachine
    {
        
        public CameraPos CurrentCameraPos;
      
        public void Initialize(CameraPos startingCameraPos)
        {
            CurrentCameraPos = startingCameraPos;
        }

        public void ChangeState(CameraPos newPos)
        {
            CurrentCameraPos.Exit();
            CurrentCameraPos = newPos;
            newPos.Enter();
        }
    }
}
