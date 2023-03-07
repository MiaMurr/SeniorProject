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
