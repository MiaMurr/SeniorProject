using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.IO;
using System;
using System.Linq;

public class SnakeLeaderBoard : MonoBehaviour
{
    //Textboxes
    public TMP_Text user1;
    public TMP_Text user2;
    public TMP_Text user3;
    public TMP_Text user4;
    public TMP_Text user5;
    public TMP_Text user6;
    public TMP_Text user7;
    public TMP_Text user8;
    public TMP_Text user9;
    public TMP_Text user10;

    public TMP_Text HS1;
    public TMP_Text HS2;
    public TMP_Text HS3;
    public TMP_Text HS4;
    public TMP_Text HS5;
    public TMP_Text HS6;
    public TMP_Text HS7;
    public TMP_Text HS8;
    public TMP_Text HS9;
    public TMP_Text HS10;






    // use the following code also add using System.IO;

    private string paths = "Assets/Data/userD.txt";
    void userScore()
    {
        string[] Lines = System.IO.File.ReadAllLines(paths);
        int size = Lines.Length;

        string[] name = new string[size];
        float[] snakeScore = new float[size];
        IDictionary<string, float> NameScore = new Dictionary<string, float>();
        IDictionary<string, float> Sorted = new Dictionary<string, float>();
        int count = 0;


        foreach (string line in File.ReadAllLines(paths))
        {
            string[] data = line.Split(';');

            // assigning all the variables
            name[count] = data[0];// this is the name
            float.TryParse(data[8], out snakeScore[count]);// this is the scores
            NameScore.Add(name[count], snakeScore[count]);
            //Debug.Log(name[count]);
            //Debug.Log(snakeScore[count]);
            count++;

        }

        // add code here

        //foreach (KeyValuePair<string, float> kvp in NameScore)
        //{
        //    Debug.Log("Key: {0}, Value: {1}" + kvp.Key + kvp.Value);
        //}
        foreach (KeyValuePair<string, float> kvp in NameScore.OrderByDescending(key => key.Value))
        {
            Sorted.Add(kvp.Key, kvp.Value);
        }
        foreach (KeyValuePair<string, float> kvp in Sorted)
        {
            Debug.Log("Key: {0}, Value: {1}" + kvp.Key + kvp.Value);
        }
        Debug.Log($"Just Key: {Sorted.ElementAt(1).Key}");
        user1.text = " " + Sorted.ElementAt(0).Key;
        HS1.text = " " + Sorted.ElementAt(0).Value;
        user2.text = " " + Sorted.ElementAt(1).Key;
        HS2.text = " " + Sorted.ElementAt(1).Value;
        user3.text = " " + Sorted.ElementAt(2).Key;
        HS3.text = " " + Sorted.ElementAt(2).Value;
        user4.text = " " + Sorted.ElementAt(3).Key;
        HS4.text = " " + Sorted.ElementAt(3).Value;
        user5.text = " " + Sorted.ElementAt(4).Key;
        HS5.text = " " + Sorted.ElementAt(4).Value;
        user6.text = " " + Sorted.ElementAt(5).Key;
        HS6.text = " " + Sorted.ElementAt(5).Value;
        user7.text = " " + Sorted.ElementAt(6).Key;
        HS7.text = " " + Sorted.ElementAt(6).Value;
        user8.text = " " + Sorted.ElementAt(7).Key;
        HS8.text = " " + Sorted.ElementAt(7).Value;
        user9.text = " " + Sorted.ElementAt(8).Key;
        HS9.text = " " + Sorted.ElementAt(8).Value;
        user10.text = " " + Sorted.ElementAt(9).Key;
        HS10.text = " " + Sorted.ElementAt(9).Value;
        Debug.Log($"Just Value: {Sorted.ElementAt(1).Value}");
    }

    void Start()
    {
        if (user1 == null)
        {
            //Finds the tag on the text field and gets whats being held
            user1 = GameObject.FindWithTag("user1")
                .GetComponent<TMP_Text>();
        }
        //Checks if the text field has no value 
        if (user2 == null)
        {
            //Finds the tag on the text field and gets whats being held
            user2 = GameObject.FindWithTag("user2")
                .GetComponent<TMP_Text>();
        }

        if (user3 == null)
        {
            //Finds the tag on the text field and gets whats being held
            user3 = GameObject.FindWithTag("user3")
                .GetComponent<TMP_Text>();
        }

        if (user4 == null)
        {
            //Finds the tag on the text field and gets whats being held
            user4 = GameObject.FindWithTag("user4")
                .GetComponent<TMP_Text>();
        }

        if (user5 == null)
        {
            //Finds the tag on the text field and gets whats being held
            user5 = GameObject.FindWithTag("user5")
                .GetComponent<TMP_Text>();
        }
        if (user6 == null)
        {
            //Finds the tag on the text field and gets whats being held
            user1 = GameObject.FindWithTag("user6")
                .GetComponent<TMP_Text>();
        }
        //Checks if the text field has no value 
        if (user7 == null)
        {
            //Finds the tag on the text field and gets whats being held
            user2 = GameObject.FindWithTag("user7")
                .GetComponent<TMP_Text>();
        }

        if (user8 == null)
        {
            //Finds the tag on the text field and gets whats being held
            user3 = GameObject.FindWithTag("user8")
                .GetComponent<TMP_Text>();
        }

        if (user9 == null)
        {
            //Finds the tag on the text field and gets whats being held
            user4 = GameObject.FindWithTag("user9")
                .GetComponent<TMP_Text>();
        }

        if (user10 == null)
        {
            //Finds the tag on the text field and gets whats being held
            user5 = GameObject.FindWithTag("user10")
                .GetComponent<TMP_Text>();
        }

        if (HS1 == null)
        {
            //Finds the tag on the text field and gets whats being held
            HS1 = GameObject.FindWithTag("HS1")
                .GetComponent<TMP_Text>();
        }
        if (HS2 == null)
        {
            //Finds the tag on the text field and gets whats being held
            HS2 = GameObject.FindWithTag("HS2")
                .GetComponent<TMP_Text>();
        }
        if (HS3 == null)
        {
            //Finds the tag on the text field and gets whats being held
            HS3 = GameObject.FindWithTag("HS3")
                .GetComponent<TMP_Text>();
        }
        if (HS4 == null)
        {
            //Finds the tag on the text field and gets whats being held
            HS4 = GameObject.FindWithTag("HS4")
                .GetComponent<TMP_Text>();
        }
        if (HS5 == null)
        {
            //Finds the tag on the text field and gets whats being held
            HS5 = GameObject.FindWithTag("HS5")
                .GetComponent<TMP_Text>();
        }
        if (HS6 == null)
        {
            //Finds the tag on the text field and gets whats being held
            HS1 = GameObject.FindWithTag("HS6")
                .GetComponent<TMP_Text>();
        }
        if (HS7 == null)
        {
            //Finds the tag on the text field and gets whats being held
            HS2 = GameObject.FindWithTag("HS7")
                .GetComponent<TMP_Text>();
        }
        if (HS8 == null)
        {
            //Finds the tag on the text field and gets whats being held
            HS3 = GameObject.FindWithTag("HS8")
                .GetComponent<TMP_Text>();
        }
        if (HS9 == null)
        {
            //Finds the tag on the text field and gets whats being held
            HS4 = GameObject.FindWithTag("HS9")
                .GetComponent<TMP_Text>();
        }
        if (HS10 == null)
        {
            //Finds the tag on the text field and gets whats being held
            HS5 = GameObject.FindWithTag("HS10")
                .GetComponent<TMP_Text>();
        }

        //userScore();
    }

    void Update() {

        userScore();

    }


    }


