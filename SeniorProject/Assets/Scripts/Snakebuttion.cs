using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Snakebuttion : MonoBehaviour
{
    // Start is called before the first frame update
    public string sceneName;
    void Start()
    {
        
    }

    private void OnMouseUpAsButton()
    {
        SceneManager.LoadScene(sceneName);
    }
}
