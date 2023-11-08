using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapTrigger3 : MonoBehaviour
{
    public GameObject lapTrigger3;
    public GameObject halfLapTrigger;

    private void OnTriggerEnter()
    {
        lapTrigger3.SetActive(false);
        halfLapTrigger.SetActive(true);
    }
}
