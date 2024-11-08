using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyAscend : MonoBehaviour
{
    public UpdTextAsc AscendPoints;
    public Button AscendClick;

    private void Update()
    {
        Ascend();
    }
    public void Ascend()
    {
        if (AscendPoints.pontosAsc >= 1)
        {
            AscendPoints.pontosAscTxt.text = AscendPoints.pontosAsc.ToString() + " Pontos de Ascenção serão ganhados";
            AscendClick.enabled = true;
        }
        else if (AscendPoints.pontosAsc == 0)
        {
            AscendClick.enabled = false;
            AscendPoints.pontosAscTxt.text = "Você ainda não tem dinheiro para ascender";
        }
    }
}
