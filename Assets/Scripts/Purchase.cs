using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Purchase : MonoBehaviour
{
    public EnableUpgrades Upgrade;
    public int Cost;
    public Currencyfloat UserMoney;
    public void PurchaseUpgrade()
    {
        if(UserMoney.Currency >= Cost){
            UserMoney.Currency -= Cost;
            Upgrade.EnableValue = true;

          }
    }
}

   
