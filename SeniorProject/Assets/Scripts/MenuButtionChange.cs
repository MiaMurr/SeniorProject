using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtionChange : MonoBehaviour
{
    public string type = "0";
    public string sceneName;
    void OnMouseUpAsButton()
    {
        
        if (type.Equals("level"))
        {
            SceneManager.LoadScene(sceneName);
        }

        if (type.Equals( "quite"))
        {
            Application.Quit();
        }
    }
    
    
    
    
}
