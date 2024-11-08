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

    bool canAscend = true;
    float tempDinheiro;

    private void Start()
    {
        pontosAscTxt.text = "Voce ainda nao tem dinheiro para ascender";
    }
    public void CheckForDinheiro()
    {
        tempDinheiro = dinheiroForAsc._dinheiro;

        if (tempDinheiro >= 10 && tempDinheiro <= 11)
        {
            canAscend = true;
        }

        if (canAscend)
        {
            pontosAsc++;
            pontosAscTxt.text = pontosAsc.ToString() + " Pontos de Ascensao serao ganhados";
            canAscend = false;
        }
    }

}
