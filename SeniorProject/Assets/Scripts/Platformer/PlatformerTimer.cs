using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlatformerTimer : MonoBehaviour
{

    public float time;
    public float time2;
    public float seconds;
    public float minutes;
    public float Lowestime;
    public float Minutes;
    public float Seconds;
    public float Low;
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI timeText2;
    public GameObject TimeFUser;

    public TextMeshProUGUI endSec;
    public TextMeshProUGUI endmin;

    //public TextMeshProUGUI FastestSec;
    public TextMeshProUGUI FastestMin;


    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        time2 = 0;
        seconds = 0;
        minutes = 0;
    }

    void timeer() {

        time += 1 * Time.deltaTime;
        timeText.text = time.ToString("00");
        if (time >= 60)
        {
            time2++;
            timeText2.text = time2.ToString("00");
            time = 0;
        }

    }
    // Update is called once per frame
    void Update()
    {


        if (TimeFUser.activeInHierarchy)
        {
            seconds = time;
            endSec.text = seconds.ToString("00");
            minutes = time2;
            endmin.text = minutes.ToString("00");

            Minutes = minutes * 100;
            Seconds = seconds;
            Lowestime = Minutes + Seconds;

            Low = PlayerPrefs.GetFloat("HighScore2");

            FastestMin.text = Low.ToString("0");
            FastestMin.text = FastestMin.text.Insert(1, ":");

            if (Lowestime < 960) {

                FastestMin.text = FastestMin.text.Insert(0, "0");
            }

            if (PlayerPrefs.GetFloat("HighScore2") == 0f)
            {

                PlayerPrefs.SetFloat("HighScore2", Lowestime);


            }

            if (Lowestime < PlayerPrefs.GetFloat("HighScore2"))
            {

                PlayerPrefs.SetFloat("HighScore2", Lowestime);
               

            }



        }
        else {

            timeer();


        }



        
    }
}
