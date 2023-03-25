using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongPlayerController : MonoBehaviour
{

    public PongPlayer leftPlayer;
    public PongPlayer rightPlayer;






    public void resetPlayer()
    {
        leftPlayer.rb.velocity = Vector3.zero;
        leftPlayer.transform.position = new Vector3(-25, 0, 0);
        rightPlayer.rb.velocity = Vector3.zero;
        rightPlayer.transform.position = new Vector3(25, 0, 0);
        var Leftprojectiles = GameObject.FindGameObjectsWithTag("PongLeftPlayerProjectile");
        var Rightprojectiles = GameObject.FindGameObjectsWithTag("PongRightPlayerProjectile");
        var projectileEffects = GameObject.FindGameObjectsWithTag("PongProjectileEffect");
        foreach (GameObject x in Leftprojectiles)
        {
            GameObject.Destroy(x);
        }
        foreach (GameObject x in Rightprojectiles)
        {
            GameObject.Destroy(x);
        }
        foreach (GameObject x in projectileEffects)
        {
            GameObject.Destroy(x);
        }
        leftPlayer.player1Cooldown = leftPlayer.projectileCooldown;
        rightPlayer.player1Cooldown = rightPlayer.projectileCooldown;
        leftPlayer.player2Cooldown = leftPlayer.projectileCooldown;
        rightPlayer.player2Cooldown = rightPlayer.projectileCooldown;
    }











    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
