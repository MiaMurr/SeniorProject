using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class newGamebrightness : MonoBehaviour
{
    [SerializeField] private PostProcessProfile Brightness;
    [SerializeField] private PostProcessLayer TheLayer;

    AutoExposure exposure;
    // Start is called before the first frame update
    void Start()
    {
        Brightness.TryGetSettings(out exposure);
        login();
    }

    private void login()
    {
        float loginExposer = PlayerPrefs.GetFloat("Brightness");
        ChangeBrightness(loginExposer);
    }
    // Update is called once per frame

    public void ChangeBrightness(float theInput)
    {
        if (theInput != 0)
        {
            Debug.Log("it is not 0 so should change");
            exposure.keyValue.value = theInput;
        }
        else
        {
            Debug.Log("it's zero so it's set to .2f");
            exposure.keyValue.value = .2f;
        }
    }
}
