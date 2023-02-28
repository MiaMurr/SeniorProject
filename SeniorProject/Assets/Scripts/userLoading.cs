using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using System;
using System.Reflection;
using UnityEngine.UI;
using TMPro;
using System.ComponentModel;


public class userLoading : MonoBehaviour
{

    private string paths = "Assets/Data/userD.txt";
    private string username;
    private string password;
    private float brightness;
    private float sound;
    private string snakeup;
    private string snakedown;
    private string snakeleft;
    private string snakeright;
    private float snakeScore1;
    private float snakeScore2;
    private float snakeScore3;

    public string InputUsername;
    public string InputPassword;
    
    int counter = 0;

    public TMP_Text userName;
    public TMP_Text userPassword;
    

    public void ButtonClicked()
    {
        //InputPassword = userPassword.GetComponent<TMP_Text>().text;
        userName = GameObject.FindWithTag("UserText").GetComponent<TMP_Text>();
        userPassword = GameObject.FindWithTag("PassText").GetComponent<TMP_Text>();
        InputUsername = userName.text;
        InputPassword = userPassword.text;
        ReadString(paths);
    }

    //private void Start()
    //{
        
    //    WriteString(paths);
    //    ReadString(paths);
        
    //}
    void WriteString(string path)
    {
        
        StreamWriter writer = new StreamWriter(path, true);
        //writer.WriteLine("Test");
        writer.Close();
    }


    void ReadString(string path)
    {
        
        foreach (string line in File.ReadAllLines(path))
        {
            string[] data = line.Split(';');

            username = data[0];
            password = data[1];
            float.TryParse(data[2],out brightness);
            float.TryParse(data[3],out sound);
            snakeup = data[4];
            snakedown = data[5];
            snakeleft = data[6];
            snakeright = data[7];
            float.TryParse(data[8], out snakeScore1);
            float.TryParse(data[9], out snakeScore2);
            float.TryParse(data[10], out snakeScore3);
            counter++;
            //for testing----------------------------------
            InputUsername = username;
            InputPassword = password;
            //-----------------------------------------------
            bool nametest = InputUsername.Equals(username);
            bool passtest = InputPassword.Equals(password);
            
            if (username == InputUsername)
            {
                Debug.Log("it's finally working");
            }
            else
            {
                Debug.Log("still does not work"+ "[" + InputUsername + "]"+ "[" + username + "]");
            }


            if (nametest == true && passtest == true)
            {
                PlayerPrefs.SetString("username", username);
                PlayerPrefs.SetFloat("Brightness", brightness);
                PlayerPrefs.SetFloat("volume", sound);
                PlayerPrefs.SetInt("soundIn", 1);
                //snakeup
                //snakedown
                //snakeleft
                //snakeright
                PlayerPrefs.SetFloat("HighScore", sound);

            }
            else
            {
                Debug.Log("still does not work" + "[" + InputUsername + "]" + "[" + username + "]");
                Debug.Log("and" + "[" + InputPassword + "]" + "[" + password + "]");
                Debug.Log("not the same");
            }

            
        }
        
    }
}
