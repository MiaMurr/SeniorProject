using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logoutSetting : MonoBehaviour
{
    private int LoginState = 0;
    public GameObject loginScreen;
    public GameObject menuscreen;
    public GameObject LogoutButtion;
    // Start is called before the first frame update
    void Start()
    {
        LoginState = PlayerPrefs.GetInt("Playerlogin");
        if (LoginState == 1)
        {
            loginScreen.SetActive(false);
            menuscreen.SetActive(true);
            LogoutButtion.SetActive(true);
        }
    }

    // Update is called once per frame

    public void logout()
    {
        PlayerPrefs.SetInt("Playerlogin", 0);
        loginScreen.SetActive(true);
        menuscreen.SetActive(false);
        LogoutButtion.SetActive(false);
    }

    public void logoutButtion()
    {
        LogoutButtion.SetActive(true) ;
    }
}
