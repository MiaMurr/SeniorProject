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

    public TMP_Text PlatV;

    public TMP_Text Time1;
    public TMP_Text Time2;
    public TMP_Text Time3;
    public TMP_Text Time4;
    public TMP_Text Time5;

    public TMP_Text TimeV;






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

        PlatV.text = " " + Sorted.ElementAt(0).Key;
        TimeV.text = " " + Sorted.ElementAt(0).Value;

        float V1 = float.Parse(TimeV.text, System.Globalization.NumberStyles.Float);

        if (V1 < 960f)
        {
            TimeV.text = string.Format("{0:##}", V1);
            TimeV.text = TimeV.text.Insert(1, ":");
            TimeV.text = TimeV.text.Insert(0, "0");

        }
        else
        {
            TimeV.text = TimeV.text.Insert(3, ":");
        }

        PlatUser1.text = " " + Sorted.ElementAt(0).Key;
        Time1.text = " " + Sorted.ElementAt(0).Value;
        
        float T1 = float.Parse(Time1.text, System.Globalization.NumberStyles.Float);

        if (T1 < 960f)
        {
            Time1.text = string.Format("{0:##}", T1);
            Time1.text = Time1.text.Insert(1, ":");
            Time1.text = Time1.text.Insert(0, "0");

        }
        else
        {
            Time1.text = Time1.text.Insert(3, ":");
        }

        PlatUser2.text = " " + Sorted.ElementAt(1).Key;
        Time2.text = " " + Sorted.ElementAt(1).Value;


        float T2 = float.Parse(Time2.text, System.Globalization.NumberStyles.Float);

        if (T2 < 960f)
        {
            Time2.text = string.Format("{0:##}", T2);
            Time2.text = Time2.text.Insert(1, ":");
            Time2.text = Time2.text.Insert(0, "0");

        }
        else
        {
            Time2.text = Time2.text.Insert(3, ":");
        }

        PlatUser3.text = " " + Sorted.ElementAt(2).Key;
        Time3.text = " " + Sorted.ElementAt(2).Value;

        float T3 = float.Parse(Time3.text, System.Globalization.NumberStyles.Float);

        if (T3 < 960f)
        {
            Time3.text = string.Format("{0:##}", T3);
            Time3.text = Time3.text.Insert(1, ":");
            Time3.text = Time3.text.Insert(0, "0");

        }
        else
        {
            Time3.text = Time3.text.Insert(3, ":");
        }

        PlatUser4.text = " " + Sorted.ElementAt(3).Key;
        Time4.text = " " + Sorted.ElementAt(3).Value;

        float T4 = float.Parse(Time4.text, System.Globalization.NumberStyles.Float);

        
        
        if (T4 < 960f)
        {
            Time4.text = string.Format("{0:##}", T4);
            Time4.text = Time4.text.Insert(1, ":");
            Time4.text = Time4.text.Insert(0, "0");
            
        }
        else {
            Time4.text = Time4.text.Insert(3, ":");
        }

        PlatUser5.text = " " + Sorted.ElementAt(4).Key;
        Time5.text = " " + Sorted.ElementAt(4).Value;

        float T5 = float.Parse(Time5.text, System.Globalization.NumberStyles.Float);

        if (T5 < 960f)
        {
            Time5.text = string.Format("{0:##}", T5);
            Time5.text = Time5.text.Insert(1, ":");
            Time5.text = Time5.text.Insert(0, "0");

        }
        else
        {
            Time5.text = Time5.text.Insert(3, ":");
        }
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
        //Debug.Log($"Just Value: {Sorted.ElementAt(0).Value}");
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

        if (PlatV == null)
        {
            //Finds the tag on the text field and gets whats being held
            PlatUser1 = GameObject.FindWithTag("FN")
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

        if (TimeV == null)
        {
            //Finds the tag on the text field and gets whats being held
            Time5 = GameObject.FindWithTag("FT")
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
