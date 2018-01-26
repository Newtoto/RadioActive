using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StationChanger : MonoBehaviour
{

    private float currentFreq;
    public Text currentFreqText;
    public GameObject pin;

	void Start ()
    {
        currentFreq = 88.0f;
    }
	
	void Update ()
    { 
        if (Input.GetAxis("Mouse ScrollWheel") > 0.0f && currentFreq < 108.0f) // forward
        {
            currentFreq = currentFreq + 0.1f;
            currentFreq = Mathf.Round(currentFreq * 100f) / 100f;
            if (currentFreq % 1 == 0)
            {
                currentFreqText.text = ("Current Frequency: " + currentFreq + ".0");
            }
            else
            {
                currentFreqText.text = ("Current Frequency: " + currentFreq);
            }

            pin.transform.Translate(0.1f, 0.0f, 0.0f);
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0.0f && currentFreq > 88.0f) // backwards
        {
            currentFreq = currentFreq - 0.1f;
            currentFreq = Mathf.Round(currentFreq * 100f) / 100f;
            if (currentFreq % 1 == 0)
            {
                currentFreqText.text = ("Current Frequency: " + currentFreq + ".0");
            } else
            {
                currentFreqText.text = ("Current Frequency: " + currentFreq);
            }
            pin.transform.Translate(-0.1f, 0.0f, 0.0f);
        }
    }
}
