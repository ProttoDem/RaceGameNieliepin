using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unlockables : MonoBehaviour
{
    public GameObject BuyCarButton;
    private static bool Car2Unlocked = false;

    public void Update()
    {
        if (GlobalCash.CashAmount >= 100)
        {
            BuyCarButton.GetComponent<Button>().interactable = true;
        }
    }

    public void BuyCar()
    {
        BuyCarButton.SetActive(false);
        GlobalCash.CashAmount -= 100;
        Car2Unlocked = true;
    }

    public void Start()
    {
        if (Car2Unlocked)
        {
            BuyCarButton.SetActive(false);
        }
    }
}
