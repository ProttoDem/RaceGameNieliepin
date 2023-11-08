using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarManager : MonoBehaviour
{
    public GameObject car1;
    public GameObject car2;
    // Start is called before the first frame update
    void Start()
    {
        switch (GlobalCar.CarType)
        {
            case 1: 
                car1.SetActive(true);
                car2.SetActive(false);
                break;
            case 2:
                car1.SetActive(false);
                car2.SetActive(true);
                break;
            default:
                break;
        }
    }
}
