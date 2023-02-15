using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MenuPopUp : MonoBehaviour
{
    public GameObject SetScreen;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ButtonClicked(){

        if (SetScreen.activeInHierarchy == false)
        {

            SetScreen.SetActive(true);

        }
        else {

            SetScreen.SetActive(false);

        }
    
    
    
    }
}
