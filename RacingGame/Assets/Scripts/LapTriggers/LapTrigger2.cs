using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapTrigger2 : MonoBehaviour
{
    public GameObject lapTrigger2;
    public GameObject lapTrigger3;

    private void OnTriggerEnter()
    {
        lapTrigger2.SetActive(false);
        lapTrigger3.SetActive(true);
    }
}
