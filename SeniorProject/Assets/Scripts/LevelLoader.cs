using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("brightnessSwitch", 1);
        Debug.Log("the start of the code brightness switch" + PlayerPrefs.GetInt("brightnessSwitch"));
        PlayerPrefs.SetInt("soundIn", 1);
    }

    
}
