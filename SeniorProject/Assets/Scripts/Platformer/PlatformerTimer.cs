using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlatformerTimer : MonoBehaviour
{

    public float time;
    public float time2;
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI timeText2;




    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        time2 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += 1 * Time.deltaTime;
        timeText.text = time.ToString("00");
        if (time >= 60)
        {
            time2++;
            timeText2.text = time2.ToString("00");
            time = 0;
        }
    }
}
