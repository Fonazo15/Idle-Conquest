using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BuyUpgrades : MonoBehaviour
{
    [Header ("Events")]
    public UnityEvent onBuyUpgrEvent;

    public void InvokeUpgrade()
    {
        onBuyUpgrEvent.Invoke();
    }
}
