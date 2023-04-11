using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameOverVictory : MonoBehaviour
{
    public TMP_Text Username;

    public GameObject cam1;
    public GameObject cam2;
    //public GameObject char1;
    //public GameObject char2;
    public GameObject Vic;
    public GameObject mis;
    public GameObject GameOverScreen;
    public GameObject PlayingScreen;
    public int count;

    public userLoading userLoading = null;

    // Start is called before the first frame update
    void Start()
    {
        //cam1.SetActive(true);
        cam2.SetActive(false);
        //char1.SetActive(true);
        //char2.SetActive(false);
        Vic.SetActive(false);
        mis.SetActive(false);
        GameOverScreen.SetActive(false);
        count = 0;

        if (Username == null)
        {
            //Finds the tag on the text field and gets whats being held
            Username = GameObject.FindWithTag("user")
                .GetComponent<TMP_Text>();
        }

        Username.text = PlayerPrefs.GetString("username");
    }

    private void OnTriggerEnter(Collider other)
    {
        count++;
        if (other.tag == "Player" && KeyCollection.score == 3)
        {
            userLoading.Gamescore();
            //KeyCollection.score -= 3;
            cam1.SetActive(false);
            cam2.SetActive(true);
            //char1.SetActive(false);
            //char2.SetActive(true);
            Vic.SetActive(false);
            other.gameObject.SetActive(false);
            GameOverScreen.SetActive(true);
            PlayingScreen.SetActive(false);
        }
        else
        {

            mis.SetActive(true);
            Invoke("dela", 5);
        }

    }
    // Update is called once per frame

    void dela() {
        mis.SetActive(false);
    }
    void Update()
    {
        
    }
}
