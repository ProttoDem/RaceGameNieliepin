using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapTrigger1 : MonoBehaviour
{
    public GameObject lapTrigger1;
    public GameObject lapTrigger2;

    private void OnTriggerEnter()
    {
        lapTrigger1.SetActive(false);
        lapTrigger2.SetActive(true);
    }
}
