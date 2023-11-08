using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfLapTrigger : MonoBehaviour
{
    public GameObject halfLapTrigger;
    public GameObject lapTrigger4;

    private void OnTriggerEnter()
    {
        halfLapTrigger.SetActive(false);
        lapTrigger4.SetActive(true);
    }
}
