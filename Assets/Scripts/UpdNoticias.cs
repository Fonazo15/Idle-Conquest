using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpdNoticias : MonoBehaviour
{
    public TextMeshProUGUI noticiasTxt;
    public GanharDinheiro dinheiroRef;

    public void UpdateNoticiasText()
    {
        switch(dinheiroRef._dinheiro)
        {
            case 5:
                noticiasTxt.text = "- Noticia 1: aaaaaaaaa";
                break;
            case 15:
                noticiasTxt.text = "- Noticia 2: bbbbbbbbbb";
                break;
            case 25:
                noticiasTxt.text = "- Noticia 3: ccccccccccc";
                break;
            default:break;
        }
    }
}
