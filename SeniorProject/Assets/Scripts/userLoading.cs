using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using System;
using System.Reflection;
using UnityEngine.UI;
//using System.Diagnostics;

public class userLoading : MonoBehaviour
{

    string paths = "Assets/Data/userD.txt";
    string username;
    string password;
    float brightness;
    float sound;
    string snakeup;
    string snakedown;
    string snakeleft;
    string snakeright;
    string snakeScore1;
    string snakeScore2;
    string snakeScore3;

    public string InputUsername;
    public string InputPassword;
    
    int counter = 0;

    [SerializeField] public GameObject userName;
    [SerializeField] public GameObject userPassword;

    //public void ButtonClicked()
    //{
    //    InputUsername = userName.GetComponent<Text>().text;
    //    InputPassword = userPassword.GetComponent<Text>().text;
    //    //Debug.Log("first " + InputUsername);
    //    //Debug.Log("second" + InputPassword);
    //    //ReadString(paths);
    //}

    private void Start()
    {
        
        WriteString(paths);
        ReadString(paths);
        
    }
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
            snakeScore1 = data[8];
            snakeScore2 = data[9];
            snakeScore3 = data[10];
            Debug.Log(counter);
            counter++;

            if (InputUsername == username && InputPassword == password)
            {
                PlayerPrefs.SetString("username", username);
                PlayerPrefs.SetFloat("Brightness", brightness);
                PlayerPrefs.SetFloat("volume", sound);
            }

            
        }
        
    }
}
