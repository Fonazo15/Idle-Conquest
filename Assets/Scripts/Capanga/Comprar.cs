using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Comprar : Buy
{

    [Header("Events")]
    public UnityEvent onCapangaBuyEvent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isBought)
        {
        onCapangaBuyEvent.Invoke();
        }
    }
}
