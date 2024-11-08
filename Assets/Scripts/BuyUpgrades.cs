using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BuyUpgrades : MonoBehaviour
{
    public GanharDinheiro dinheiroPlayer;

    public TextMeshProUGUI comprarUpgradeTxt;

    public Button comprarUpgradeBtn;

    bool isUpBought;
    public void Upgrade()
    {
        if(dinheiroPlayer._dinheiro == 5)
        {
            dinheiroPlayer.dinheiroMultply += 1.2f;
            isUpBought = true;
        }
        if (isUpBought)
        {
            comprarUpgradeTxt.text = "Comprado!";
            comprarUpgradeBtn.interactable = false;
        }
    }
}
