using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AplicarBonusAsc : MonoBehaviour
{
    public UpdTextAsc pointsToBonus;
    public float storeBonus;
    public float bonus;
    // Start is called before the first frame update
    void Start()
    {
        bonus = storeBonus;
    }
    private void Update()
    {
        storeBonus = pointsToBonus.pontosAsc * 1.02f;
    }
}
