using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.IO;
using System;
using System.Linq;

public class PLeaderboard : MonoBehaviour
{
    public TMP_Text PlatUser1;
    public TMP_Text PlatUser2;
    public TMP_Text PlatUser3;
    public TMP_Text PlatUser4;
    public TMP_Text PlatUser5;


    public TMP_Text Time1;
    public TMP_Text Time2;
    public TMP_Text Time3;
    public TMP_Text Time4;
    public TMP_Text Time5;







    // use the following code also add using System.IO;

    private string paths = "Assets/Data/userD.txt";
    void userScore()
    {
        string[] Lines = System.IO.File.ReadAllLines(paths);
        int size = Lines.Length;

        string[] name = new string[size];
        float[] PlatformerTime = new float[size];
        IDictionary<string, float> NameScore = new Dictionary<string, float>();
        IDictionary<string, float> Sorted = new Dictionary<string, float>();
        int count = 0;


        foreach (string line in File.ReadAllLines(paths))
        {
            string[] data = line.Split(';');

            // assigning all the variables
            name[count] = data[0];// this is the name
            float.TryParse(data[9], out PlatformerTime[count]);// this is the scores
            if (PlatformerTime[count] == 0)
            {
              
            }
            else
            {
                NameScore.Add(name[count], PlatformerTime[count]);
            }
                //Debug.Log(name[count]);
            //Debug.Log(PlatformerTime[count]);
            count++;

        }

        // add code here

        //foreach (KeyValuePair<string, float> kvp in NameScore)
        //{
        //    Debug.Log("Key: {0}, Value: {1}" + kvp.Key + kvp.Value);
        //}
        foreach (KeyValuePair<string, float> kvp in NameScore.OrderBy(key => key.Value))
        {
            //if (NameScore.Values.Equals(0))
            //{

            //}
            //else
            //{
                Sorted.Add(kvp.Key, kvp.Value);
            //}
        }
        foreach (KeyValuePair<string, float> kvp in Sorted)
        {
            //Debug.Log("Key: {0}, Value: {1}" + kvp.Key + kvp.Value);
        }
        //Debug.Log($"Just Key: {Sorted.ElementAt(1).Key}");

        PlatUser1.text = " " + Sorted.ElementAt(0).Key;
        Time1.text = " " + Sorted.ElementAt(0).Value;
        
        float iye = float.Parse(Time1.text, System.Globalization.NumberStyles.Float);
        
        Time1.text = string.Format("{0:##}", iye);
        Time1.text = Time1.text.Insert(1, ":");
        if (iye < 960f)
        {

            Time1.text = Time1.text.Insert(0, "0");
        }

        PlatUser2.text = " " + Sorted.ElementAt(1).Key;
        Time2.text = " " + Sorted.ElementAt(1).Value;
        PlatUser3.text = " " + Sorted.ElementAt(2).Key;
        Time3.text = " " + Sorted.ElementAt(2).Value;
        PlatUser4.text = " " + Sorted.ElementAt(3).Key;
        Time4.text = " " + Sorted.ElementAt(3).Value;
        PlatUser5.text = " " + Sorted.ElementAt(4).Key;
        Time5.text = " " + Sorted.ElementAt(4).Value;
        //user6.text = " " + Sorted.ElementAt(5).Key;
        //HS6.text = " " + Sorted.ElementAt(5).Value;
        //user7.text = " " + Sorted.ElementAt(6).Key;
        //HS7.text = " " + Sorted.ElementAt(6).Value;
        //user8.text = " " + Sorted.ElementAt(7).Key;
        //HS8.text = " " + Sorted.ElementAt(7).Value;
        //user9.text = " " + Sorted.ElementAt(8).Key;
        //HS9.text = " " + Sorted.ElementAt(8).Value;
        //user10.text = " " + Sorted.ElementAt(9).Key;
        //HS10.text = " " + Sorted.ElementAt(9).Value;
        //user11.text = " " + Sorted.ElementAt(0).Key;
        //HS11.text = " " + Sorted.ElementAt(0).Value;
        Debug.Log($"Just Value: {Sorted.ElementAt(0).Value}");
    }

    void Start()
    {
        if (PlatUser1 == null)
        {
            //Finds the tag on the text field and gets whats being held
            PlatUser1 = GameObject.FindWithTag("PlatUser1")
                .GetComponent<TMP_Text>();
        }
        //Checks if the text field has no value 
        if (PlatUser2 == null)
        {
            //Finds the tag on the text field and gets whats being held
            PlatUser2 = GameObject.FindWithTag("PlatUser2")
                .GetComponent<TMP_Text>();
        }

        if (PlatUser3 == null)
        {
            //Finds the tag on the text field and gets whats being held
            PlatUser3 = GameObject.FindWithTag("PlatUser3")
                .GetComponent<TMP_Text>();
        }

        if (PlatUser4 == null)
        {
            //Finds the tag on the text field and gets whats being held
            PlatUser4 = GameObject.FindWithTag("PlatUser4")
                .GetComponent<TMP_Text>();
        }

        if (PlatUser5 == null)
        {
            //Finds the tag on the text field and gets whats being held
            PlatUser5 = GameObject.FindWithTag("PlatUser5")
                .GetComponent<TMP_Text>();
        }
        //if (user6 == null)
        //{
        //    Finds the tag on the text field and gets whats being held
        //    user1 = GameObject.FindWithTag("user6")
        //        .GetComponent<TMP_Text>();
        //}
        //Checks if the text field has no value
        //if (user7 == null)
        //{
        //    Finds the tag on the text field and gets whats being held
        //    user2 = GameObject.FindWithTag("user7")
        //        .GetComponent<TMP_Text>();
        //}

        //if (user8 == null)
        //{
        //    Finds the tag on the text field and gets whats being held
        //    user3 = GameObject.FindWithTag("user8")
        //        .GetComponent<TMP_Text>();
        //}

        //if (user9 == null)
        //{
        //    Finds the tag on the text field and gets whats being held
        //    user4 = GameObject.FindWithTag("user9")
        //        .GetComponent<TMP_Text>();
        //}

        //if (user10 == null)
        //{
        //    Finds the tag on the text field and gets whats being held
        //    user5 = GameObject.FindWithTag("user10")
        //        .GetComponent<TMP_Text>();
        //}
        //if (user11 == null)
        //{
        //    //Finds the tag on the text field and gets whats being held
        //    user5 = GameObject.FindWithTag("user10")
        //        .GetComponent<TMP_Text>();
        //}

        if (Time1 == null)
        {
            //Finds the tag on the text field and gets whats being held
            Time1 = GameObject.FindWithTag("Time1")
                .GetComponent<TMP_Text>();
        }
        if (Time2 == null)
        {
            //Finds the tag on the text field and gets whats being held
            Time2 = GameObject.FindWithTag("Time2")
                .GetComponent<TMP_Text>();
        }
        if (Time3 == null)
        {
            //Finds the tag on the text field and gets whats being held
            Time3 = GameObject.FindWithTag("Time3")
                .GetComponent<TMP_Text>();
        }
        if (Time4 == null)
        {
            //Finds the tag on the text field and gets whats being held
            Time4 = GameObject.FindWithTag("Time4")
                .GetComponent<TMP_Text>();
        }
        if (Time5 == null)
        {
            //Finds the tag on the text field and gets whats being held
            Time5 = GameObject.FindWithTag("Time5")
                .GetComponent<TMP_Text>();
        }
        //if (HS6 == null)
        //{
        //    //Finds the tag on the text field and gets whats being held
        //    HS1 = GameObject.FindWithTag("HS6")
        //        .GetComponent<TMP_Text>();
        //}
        //if (HS7 == null)
        //{
        //    //Finds the tag on the text field and gets whats being held
        //    HS2 = GameObject.FindWithTag("HS7")
        //        .GetComponent<TMP_Text>();
        //}
        //if (HS8 == null)
        //{
        //    //Finds the tag on the text field and gets whats being held
        //    HS3 = GameObject.FindWithTag("HS8")
        //        .GetComponent<TMP_Text>();
        //}
        //if (HS9 == null)
        //{
        //    //Finds the tag on the text field and gets whats being held
        //    HS4 = GameObject.FindWithTag("HS9")
        //        .GetComponent<TMP_Text>();
        //}
        //if (HS10 == null)
        //{
        //    //Finds the tag on the text field and gets whats being held
        //    HS5 = GameObject.FindWithTag("HS10")
        //        .GetComponent<TMP_Text>();
        //}
        //if (HS11 == null)
        //{
        //    //Finds the tag on the text field and gets whats being held
        //    HS5 = GameObject.FindWithTag("HS11")
        //        .GetComponent<TMP_Text>();
        //}

        userScore();
    }

    void Update()
    {

        userScore();

    }

}
