using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using System;
using System.Reflection;

public class userLoading : MonoBehaviour
{

    string paths = "Assets/Data/userD.txt";
    string lines;
    string username;
    string password;
    string brightness;
    string sound;
    string snakeup;
    string snakedown;
    string snakeleft;
    string snakeright;
    string snakeScore1;
    string snakeScore2;
    string snakeScore3;

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
        
        foreach(string line in File.ReadAllLines(path))
        {
            string[] data = line.Split(';') ;
            username =      data[0];
            password =      data[1];
            brightness=     data[2];
            sound =         data[3];
            snakeup =       data[4];
            snakedown =     data[5];
            snakeleft =     data[6];
            snakeright =    data[7];
            snakeScore1 =   data[8];
            snakeScore2 =   data[9];
            snakeScore3 =   data[10];
            String outputinfo = username + " " + password + ""
                + brightness + " " + sound + " " + snakeup + " " + snakedown
                + snakeleft + " " + snakeright + " " + snakeScore1 + " "
                + snakeScore2 + " " + snakeScore3;
            Debug.Log(outputinfo);

        }
    }
}
