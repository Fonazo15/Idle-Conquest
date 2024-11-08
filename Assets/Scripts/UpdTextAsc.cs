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

    private void Start()
    {
        pontosAscTxt.text = "Você ainda não tem dinheiro para ascender";
    }
    public void CheckForDinheiro(bool canAscend, float tempDinheiro)
    {
        tempDinheiro = dinheiroForAsc._dinheiro;
        if (tempDinheiro == 10)
        {
            canAscend = true;
        }
        else if(tempDinheiro == 20)
        {
            canAscend = true;
        }

        switch(tempDinheiro)
        {
            case 10:
                canAscend = true;
                break;
            case 20:
                canAscend = true;
                break;
            case 40:
                canAscend = true;
                break;
            default:
                break;
        }

        if (canAscend)
        {
            pontosAsc++;
            pontosAscTxt.text = pontosAsc.ToString() + " Pontos de Ascenção serão ganhados";
            canAscend = false;
        }
    }

}
