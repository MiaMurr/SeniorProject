using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongProjectileSound : MonoBehaviour
{
    public IEnumerator PongDestorySound()
    {
        yield return new WaitForSeconds(10);
        Destroy(gameObject);
    }






    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PongDestorySound());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
