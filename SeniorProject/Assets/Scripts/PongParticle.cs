using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongParticle : MonoBehaviour
{


    public IEnumerator PongDestoryParticle()
    {
        yield return new WaitForSeconds(10);
        Destroy(gameObject);
    }









    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PongDestoryParticle());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
