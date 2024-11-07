using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buy : MonoBehaviour
{
    public bool isBought;
    public float progress = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ProgressCotinue()
    {
        if(isBought)
        {
            progress++;
        }
        yield return new WaitForSeconds(0.5f);
    }
}
