using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneUseforanySceneChanges : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void GameOver()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        SnakeScore.score = 0f;
    }

}
