using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpdTextAsc : MonoBehaviour
{
    public GanharDinheiro dinheiroForAsc;

    public TextMeshProUGUI pontosAscTxt;

    public int pontosAsc;
    public bool hasAsc;

    bool canAscend;
    float tempDinheiro;

    private void Start()
    {
        pontosAscTxt.text = "Voc� ainda n�o tem dinheiro para ascender";
    }
    public void CheckForDinheiro()
    {
        tempDinheiro = dinheiroForAsc._dinheiro;

        switch(tempDinheiro)
        {
            case >= 10:
                canAscend = true;
                break;
            case >= 20:
                canAscend = true;
                break;
            case >= 40:
                canAscend = true;
                break;
            default:
                break;
        }

        if (canAscend)
        {
            pontosAsc++;
            pontosAscTxt.text = pontosAsc.ToString() + " Pontos de Ascen��o ser�o ganhados";
            canAscend = false;
        }
    }

}
