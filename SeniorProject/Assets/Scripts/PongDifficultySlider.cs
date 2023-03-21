using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PongDifficultySlider : MonoBehaviour
{

    public Slider slider;
    public TextMeshProUGUI sliderText;





    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value == 0)
        {
            sliderText.text = "Easy";
        }
        else if (slider.value == 1)
        {
            sliderText.text = "Medium";
        }
        else if (slider.value == 2)
        {
            sliderText.text = "Hard";
        }
    }

}
