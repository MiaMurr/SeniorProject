using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PongCooldownSliders : MonoBehaviour
{

    public Slider LeftPlayer;
    public Slider RightPlayer;
    public PongPlayer LeftpongPlayer;
    public PongPlayer RightpongPlayer;


    // Start is called before the first frame update
    void Start()
    {
        LeftPlayer.maxValue = LeftpongPlayer.projectileCooldown;
        RightPlayer.maxValue = RightpongPlayer.projectileCooldown;
    }

    // Update is called once per frame
    void Update()
    {
        LeftPlayer.value = LeftpongPlayer.player1Cooldown;
        RightPlayer.value = RightpongPlayer.player2Cooldown;
    }
}
