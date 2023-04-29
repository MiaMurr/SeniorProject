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
    private string qestion;
    private string ansewer;

    public string InputUsername;
    public string InputPassword;
    public string InputQuestion;
    public string InputAnswer;
    private int lineinText = 0;
    private string copy;
    
    public int counter = 0;
    private bool isAUser = false;
    

    public TMP_InputField userName;
    public TMP_InputField userPassword;
    public GameObject userPasswordOBJ;

    public TMP_InputField questionText;
    public GameObject questionTextOBJ;
    public TMP_InputField ansewerText;
    public GameObject ansewerTextOBJ;


    public GameObject newuserError;
    public GameObject LogInError;
    public GameObject UserError;
    public MenuButtionChange MenuChange;
    public logoutSetting logoutSetting;
    public GameObject userButtion;
    public GameObject passwordresetButtion;
    [SerializeField] bool login = false;


    public void ButtonClicked()
    {
        userPassword.contentType = TMP_InputField.ContentType.Password;
        InputUsername = userName.GetComponent<TMP_InputField>().text;
        InputPassword = userPassword.text;
        
        ReadString(paths);
        
    }

    private void Start()
    {
        PlayerPrefs.SetInt("soundIn", 0);
        PlayerPrefs.SetInt("brightnessSwitch", 0);
        //newuserError.SetActive(false);
        //LogInError.SetActive(false);

    }

    public void Gamescore()
    {
        //ReadString(paths);
        WriteString();

    }
    public void WriteString()
    {
        string[]Lines = System.IO.File.ReadAllLines(paths);
        username = PlayerPrefs.GetString("username");
        password = PlayerPrefs.GetString("password");
        brightness = PlayerPrefs.GetFloat("Brightness");
        sound = PlayerPrefs.GetFloat("volume");
        snakeup = PlayerPrefs.GetString("snakeup");
        snakedown = PlayerPrefs.GetString("snakedown");
        snakeleft = PlayerPrefs.GetString("snakeleft");
        snakeright = PlayerPrefs.GetString("snakeright");
        snakeScore1 = PlayerPrefs.GetFloat("HighScore");
        snakeScore2 = PlayerPrefs.GetFloat("HighScore2");
        snakeScore3 = PlayerPrefs.GetFloat("HighScore3");
        qestion = PlayerPrefs.GetString("Question");
        ansewer = PlayerPrefs.GetString("Answer");
        copy = username +";"+ password +";" + brightness + ";" + sound + ";" + snakeup + ";" +
            snakedown + ";" + snakeleft + ";" + snakeright + ";" +snakeScore1 + ";" +
            snakeScore2 + ";" +snakeScore3 + ";" + qestion + ";" + ansewer;
        lineinText = PlayerPrefs.GetInt("lineText");
        Lines[lineinText] = copy;
        File.WriteAllLines(paths,Lines);
        
    }


    void ReadString(string path)
    {
        // will read the file line by line
        foreach (string line in File.ReadAllLines(path))
        {
            string[] data = line.Split(';');

            // assigning all the variables
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
            qestion = data[11];
            ansewer = data[12];


            if (username == InputUsername && password == InputPassword)
            {

                PlayerPrefs.SetString("username", username);
                PlayerPrefs.SetString("password", password);
                PlayerPrefs.SetFloat("Brightness", brightness);
                PlayerPrefs.SetInt( "brightnessSwitch",1);
                PlayerPrefs.SetFloat("volume", sound);
                PlayerPrefs.SetInt("soundIn", 1);
                PlayerPrefs.SetString("snakeup", snakeup);
                PlayerPrefs.SetString("snakedown", snakedown);
                PlayerPrefs.SetString("snakeleft", snakeleft);
                PlayerPrefs.SetString("snakeright", snakeright);
                PlayerPrefs.SetFloat("HighScore", snakeScore1);
                PlayerPrefs.SetFloat("HighScore2", snakeScore2);
                PlayerPrefs.SetFloat("HighScore3", snakeScore3);
                PlayerPrefs.SetString("Question",qestion);
                PlayerPrefs.GetString("Answer", ansewer);
                Debug.Log("it's finally working right now with what we have");
                // saved line location
                lineinText = counter;
                PlayerPrefs.SetInt("lineText", lineinText);
                Debug.Log(lineinText);
                isAUser = true;
                if (login == true)
                {
                    MenuChange.OnMouseUpAsButton();
                    logoutSetting.logoutButtion();
                }
                PlayerPrefs.SetInt("Playerlogin", 1);
            }
            if (isAUser == false)
            {
                LogInError.SetActive(true);   
            }
            counter++;
        }
    }

    public void NewUserButtion()
    {
        InputUsername = userName.GetComponent<TMP_InputField>().text;
        userPassword.contentType = TMP_InputField.ContentType.Password;
        InputPassword = userPassword.text;

        InputQuestion = questionText.GetComponent<TMP_InputField>().text;
        InputAnswer = ansewerText.GetComponent<TMP_InputField>().text;

        foreach (string line in File.ReadAllLines(paths))
        {
            string[] data = line.Split(';');

            // assigning all the variables
            username = data[0];
            password = data[1];
            float.TryParse(data[2], out brightness);
            float.TryParse(data[3], out sound);
            snakeup = data[4];
            snakedown = data[5];
            snakeleft = data[6];
            snakeright = data[7];
            float.TryParse(data[8], out snakeScore1);
            float.TryParse(data[9], out snakeScore2);
            float.TryParse(data[10], out snakeScore3);
            qestion = data[11];
            ansewer = data[12];



            if (username == InputUsername)
            {
                isAUser = true;
            }

            
        }
        if (isAUser == true)
        {
            newuserError.SetActive(true);
        }
        else
        {
            string newUser = InputUsername + ";" + InputPassword + ";1.0;1.0;w;s;a;d;0.0;0.0;0.0"+ ";" + InputQuestion + ";"+ InputAnswer;
            File.AppendAllText(paths, newUser + Environment.NewLine);
            ReadString(paths);
            MenuChange.OnMouseUpAsButton();

        }
        isAUser = false;

    }
    public void passwordResetQuestion()
    {
        InputUsername = userName.GetComponent<TMP_InputField>().text;
        string tmpUsername;
        string tmpQestion;

        isAUser= false;
        foreach (string line in File.ReadAllLines(paths))
        {
            string[] data = line.Split(';');

            tmpUsername = data[0];
            tmpQestion = data[11];
            if(tmpUsername == InputUsername)
            {
                isAUser = true;
                lineinText = counter;
                qestion = tmpQestion;
            }

        }
        if (isAUser == true)
        {
            questionTextOBJ.SetActive(true);
            userPasswordOBJ.SetActive(true);
            ansewerTextOBJ.SetActive(true) ;
            questionText.text = qestion.ToString();
            userButtion.SetActive(false);
            passwordresetButtion.SetActive(true);
            UserError.SetActive(false);
        }
        if(isAUser == false)
        {
            UserError.SetActive(true);
            
        }
        isAUser = false;

    }
    public void passwordReset()
    {
        userPassword.contentType = TMP_InputField.ContentType.Password;
        InputUsername = userName.GetComponent<TMP_InputField>().text;
        InputPassword = userPassword.text;
        InputAnswer = ansewerText.text;

        //will look through the file to find the user name
        foreach (string line in File.ReadAllLines(paths))
        {
            string[] data = line.Split(';');

            username = data[0];
            password = data[1];
            float.TryParse(data[2], out brightness);
            float.TryParse(data[3], out sound);
            snakeup = data[4];
            snakedown = data[5];
            snakeleft = data[6];
            snakeright = data[7];
            float.TryParse(data[8], out snakeScore1);
            float.TryParse(data[9], out snakeScore2);
            float.TryParse(data[10], out snakeScore3);
            qestion = data[11];
            ansewer = data[12];
            Debug.Log(username + " " + password + " " + ansewer);

            if (username == InputUsername && ansewer == InputAnswer)
            {
                Debug.Log("it is writing");
                PlayerPrefs.SetString("username", username);
                PlayerPrefs.SetString("password", InputPassword);
                PlayerPrefs.SetFloat("Brightness", brightness);
                PlayerPrefs.SetInt("brightnessSwitch", 1);
                PlayerPrefs.SetFloat("volume", sound);
                PlayerPrefs.SetInt("soundIn", 1);
                PlayerPrefs.SetString("snakeup", snakeup);
                PlayerPrefs.SetString("snakedown", snakedown);
                PlayerPrefs.SetString("snakeleft", snakeleft);
                PlayerPrefs.SetString("snakeright", snakeright);
                PlayerPrefs.SetFloat("HighScore", snakeScore1);
                PlayerPrefs.SetFloat("HighScore2", snakeScore2);
                PlayerPrefs.SetFloat("HighScore3", snakeScore3);
                PlayerPrefs.SetString("Question", qestion);
                PlayerPrefs.GetString("Answer", ansewer);
                isAUser = true;
                lineinText = counter;

                copy = username + ";" + InputPassword + ";" + brightness + ";" + sound + ";" + snakeup + ";" +
            snakedown + ";" + snakeleft + ";" + snakeright + ";" + snakeScore1 + ";" +
            snakeScore2 + ";" + snakeScore3 + ";" + qestion + ";" + ansewer;
            }
            counter++;
        }

        if (isAUser == true)
        {
            

            string[] Lines = System.IO.File.ReadAllLines(paths);
            Lines[lineinText] = copy;
            File.WriteAllLines(paths, Lines);
            MenuChange.OnMouseUpAsButton();
        }

        if (isAUser == false)
        {
            LogInError.SetActive(true);
        }
        isAUser = false;
        counter = 0;
    }

    public void questionResetPass()
    {
        userPassword.contentType = TMP_InputField.ContentType.Password;
        InputUsername = userName.GetComponent<TMP_InputField>().text;
        InputQuestion = questionText.text;
        InputPassword = userPassword.text;
        InputAnswer = ansewerText.text;

        //will look through the file to find the user name
        foreach (string line in File.ReadAllLines(paths))
        {
            string[] data = line.Split(';');

            username = data[0];
            password = data[1];
            float.TryParse(data[2], out brightness);
            float.TryParse(data[3], out sound);
            snakeup = data[4];
            snakedown = data[5];
            snakeleft = data[6];
            snakeright = data[7];
            float.TryParse(data[8], out snakeScore1);
            float.TryParse(data[9], out snakeScore2);
            float.TryParse(data[10], out snakeScore3);
            qestion = data[11];
            ansewer = data[12];

            if (username == InputUsername && password == InputPassword)
            {
                Debug.Log("it is writing");
                PlayerPrefs.SetString("username", username);
                PlayerPrefs.SetString("password", password);
                PlayerPrefs.SetFloat("Brightness", brightness);
                PlayerPrefs.SetInt("brightnessSwitch", 1);
                PlayerPrefs.SetFloat("volume", sound);
                PlayerPrefs.SetInt("soundIn", 1);
                PlayerPrefs.SetString("snakeup", snakeup);
                PlayerPrefs.SetString("snakedown", snakedown);
                PlayerPrefs.SetString("snakeleft", snakeleft);
                PlayerPrefs.SetString("snakeright", snakeright);
                PlayerPrefs.SetFloat("HighScore", snakeScore1);
                PlayerPrefs.SetFloat("HighScore2", snakeScore2);
                PlayerPrefs.SetFloat("HighScore3", snakeScore3);
                PlayerPrefs.SetString("Question", InputPassword);
                PlayerPrefs.GetString("Answer", InputAnswer);
                isAUser = true;
                lineinText = counter;

                copy = username + ";" + password + ";" + brightness + ";" + sound + ";" + snakeup + ";" +
            snakedown + ";" + snakeleft + ";" + snakeright + ";" + snakeScore1 + ";" +
            snakeScore2 + ";" + snakeScore3 + ";" + InputQuestion + ";" + InputAnswer;
            }
            counter++;
        }

        if (isAUser == true)
        {


            string[] Lines = System.IO.File.ReadAllLines(paths);
            Lines[lineinText] = copy;
            File.WriteAllLines(paths, Lines);
            MenuChange.OnMouseUpAsButton();
        }

        if (isAUser == false)
        {
            LogInError.SetActive(true);
        }
        isAUser = false;
        counter = 0;
    }

    //void addProperty()
    //{
    //    int count = 0;

        
    //    string[] sizing = System.IO.File.ReadAllLines(paths);
    //    int size = sizing.Length;

    //    string[] Lines = new string[size];

    //    foreach (string line in File.ReadAllLines(paths))
    //    {
    //        string[] data = line.Split(';');
    //        username = data[0];
    //        password = data[2];
    //        float.TryParse(data[2], out brightness);
    //        float.TryParse(data[3], out sound);
    //        snakeup = data[0];
    //        snakedown = data[0];
    //        snakeleft = data[0];
    //        snakeright = data[0];
    //        float.TryParse(data[8], out snakeScore1);
    //        float.TryParse(data[9], out snakeScore2);
    //        float.TryParse(data[10], out snakeScore3);
    //        // the new data
    //        // question
    //        //answer 
    //        qestion = "";
    //        ansewer = "";
            
    //        copy = username + ";" + password + ";" + brightness + ";" + sound + ";" + snakeup + ";" +
    //            snakedown + ";" + snakeleft + ";" + snakeright + ";" + snakeScore1 + ";" +
    //            snakeScore2 + ";" + snakeScore3
    //            // adding
    //            + ";" + qestion + ";" + ansewer;
            
            

    //    }
    //}
}
