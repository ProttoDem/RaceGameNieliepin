using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Purchasing;
using Product = UnityEngine.Purchasing.Product;

public class Purchaser : MonoBehaviour
{ 
    public void OnPurchaseCompleted(Product product)
    {
        switch (product.definition.id)
        {
            case "com.nieliepin.buymoney":
                Add100Money();
                break;
            default:
                break;
        }
    }

    private void Add100Money()
    {
        GlobalCash.CashAmount += 100;
    }
}
