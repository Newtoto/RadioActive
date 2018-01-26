using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StationChanger : MonoBehaviour
{

    private float currentFreq;
    public Text currentFreqText;
	void Start ()
    {
        
	}
	
	void Update ()
    {
        if (Input.GetAxis("Mouse ScrollWheel") != 0.0f) // forward
        {
            currentFreq = currentFreq + 0.5f;
            currentFreqText.text = ("Current Frequency: " + currentFreq);
            Debug.Log(currentFreqText.text);
        }

        if (Input.GetAxis("Mouse ScrollWheel")) // backwards
        {
            minimap.orthographicSize--;
        }
    }
}
