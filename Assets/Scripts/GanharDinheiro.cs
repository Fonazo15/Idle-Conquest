using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GanharDinheiro : MonoBehaviour
{
    public TextMeshProUGUI dinheiroText;
    public Buy buy;
    public BuyUpgrades upgradeModf;
    public float _dinheiro;
    public float dinheiroMultply;

    // Start is called before the first frame update
    public void UpdateSum()
    {
        if (buy.progress == 10f && dinheiroMultply == 0)
        {
            _dinheiro++;
        }
        else if (buy.progress == 10f && dinheiroMultply != 0)
        {
            _dinheiro += 1 * dinheiroMultply;
        }
        dinheiroText.text = "Dinheiro: " + _dinheiro.ToString();
    }
    /*
            // Fazer para os Upgrades aumentarem o dinheiro ganho
    public void MoneyEarnerMultiplyer(float multiplyer)
    {

    }
    
    */
}
