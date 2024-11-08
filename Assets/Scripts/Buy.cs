using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buy : MonoBehaviour
{
    public float progress = 0f;

    public Slider progressSlider;
    // Start is called before the first frame update

    public void Bought()
    { 
        StartCoroutine(ProgressCotinue());
    }

    public IEnumerator ProgressCotinue()
    {
        if(progress < progressSlider.maxValue)
        {
            progress++;
            progressSlider.value = progress;
        }
        else if (progress >= progressSlider.maxValue)
        {
            progress = 0;
            progressSlider.value = progress;
        }
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(ProgressCotinue());
    }
}
