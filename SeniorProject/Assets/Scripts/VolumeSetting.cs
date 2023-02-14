using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeSetting : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] protected float MusicVolume = 1f;
    [SerializeField] protected AudioMixer audioMixer;
    void Start()
    {
        MusicVolume = PlayerPrefs.GetFloat("volume");
    }

    // Update is called once per frame
    void Update()
    {

        PlayerPrefs.SetFloat("volume", MusicVolume);
    }
}
