using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    public GameObject cashHolder;
    void Update()
    {
        cashHolder.GetComponent<Text>().text = "CASH: " + GlobalCash.CashAmount + "$";
    }
}
