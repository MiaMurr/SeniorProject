using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtionChange : MonoBehaviour
{
    public string type = "0";
    public string sceneName;
    [SerializeField] protected GameObject presentMenu;
    [SerializeField] protected GameObject nextMenu;

    [SerializeField] protected GameObject presentMenu1;
    [SerializeField] protected GameObject nextMenu1;
    [SerializeField] protected GameObject presentMenu2;
    [SerializeField] protected GameObject nextMenu2;
    [SerializeField] protected GameObject presentMenu3;
    [SerializeField] protected GameObject nextMenu3;
    [SerializeField] protected GameObject presentMenu4;
    [SerializeField] protected GameObject nextMenu4;
    public AudioSource source;
    public void OnMouseUpAsButton()
    {

        if (type.Equals("level"))
        {
            SceneManager.LoadScene(sceneName);
            source.Play();
        }

        if (type.Equals("quite"))
        {
            Application.Quit();
            source.Play();
        }

        if (type.Equals("menuChange"))
        {
            presentMenu.SetActive(false);
            nextMenu.SetActive(true);
            source.Play();
        }

        if (type.Equals("menuChange2"))
        {
            presentMenu1.SetActive(false);
            nextMenu1.SetActive(true);
            presentMenu2.SetActive(false);
            nextMenu2.SetActive(true);
            presentMenu3.SetActive(false);
            nextMenu3.SetActive(true);
            presentMenu4.SetActive(false);
            nextMenu4.SetActive(true);
            source.Play();
        }


    }
}
