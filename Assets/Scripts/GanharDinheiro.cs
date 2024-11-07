using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GanharDinheiro : MonoBehaviour
{
    public TextMeshProUGUI dinheiroText;
    public Buy buy;
    float _dinheiro;

    // Start is called before the first frame update
    public void UpdateSum()
    {
        if (buy.progress == 10f)
        {
            _dinheiro++;
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
