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
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI timeText2;
    public GameObject TimeFUser;

    public TextMeshProUGUI endSec;
    public TextMeshProUGUI endmin;



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

        }
        else {

            timeer();


        }
    }
}
