using Assets.Scripts;
using Assets.Scripts.CameraPositions;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private CameraStateMachine cameraSM;
    private CameraRoad cameraRoad;
    private CameraDefault cameraDefault;

    private bool cameraChanging;
    private bool blockCameraChange = false;
    [SerializeField] public int currentCameraPosNumber;
    public GameObject Car;
    
    private void Start()
    {
        cameraSM = new CameraStateMachine();
        cameraDefault = new CameraDefault(transform, Car.transform);
        cameraRoad = new CameraRoad(transform, Car.transform);

        cameraSM.Initialize(cameraDefault);

    }
    // Update is called once per frame
    void Update()
    {
        cameraChanging = Input.GetKey(KeyCode.C);
        if (cameraChanging && !blockCameraChange)
        {
            currentCameraPosNumber++;
            if (currentCameraPosNumber >= 2)
            {
                currentCameraPosNumber = 0;
            }
            switch (currentCameraPosNumber)
            {
                case 0 : 
                    cameraSM.ChangeState(cameraDefault);
                    break;
                case 1:
                    cameraSM.ChangeState(cameraRoad);
                    break;
                default:
                    break;
                    
            }
            BlockCameraAsync();
            cameraSM.CurrentCameraPos.SetCameraPos();
        }
    }

    async Task BlockCameraAsync()
    {
        blockCameraChange = true;
        await Task.Delay(1000);
        blockCameraChange = false;
    }
}