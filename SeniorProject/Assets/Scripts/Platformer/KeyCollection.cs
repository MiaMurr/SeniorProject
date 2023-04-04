using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class KeyCollection : MonoBehaviour
{
    public static float score = 0f;
    // Start is called before the first frame update

    // Current keys
    public TMP_Text KeysCollected;

    void Start()
    {
        if (KeysCollected == null)
        {
            //Finds the tag on the text field and gets whats being held
            KeysCollected = GameObject.FindWithTag("KeysC")
                .GetComponent<TMP_Text>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        KeysCollected.text = "" + score;
    }

}
