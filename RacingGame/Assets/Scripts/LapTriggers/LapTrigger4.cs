using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapTrigger4 : MonoBehaviour
{
    public GameObject lapTrigger4;
    public GameObject lapCompleteTrigger;

    private void OnTriggerEnter()
    {
        lapTrigger4.SetActive(false);
        lapCompleteTrigger.SetActive(true);
    }
}
