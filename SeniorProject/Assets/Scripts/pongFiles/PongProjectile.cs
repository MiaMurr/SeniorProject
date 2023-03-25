using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PongProjectile : MonoBehaviour
{
    public float speed;
    public GameObject particle;
    public AudioSource soundEffect;

    public IEnumerator PongDestoryProjectile()
    {
        yield return new WaitForSeconds(10);
        Destroy(gameObject);
    }


    private void FixedUpdate()
    {
        transform.position += -transform.right * Time.deltaTime * speed;

    }

    private void OnCollisionEnter(Collision collision)
    {
        var newParticle = Instantiate(particle, transform.position, transform.rotation);
        newParticle.transform.parent = gameObject.transform.parent;
        var newSound = Instantiate(soundEffect, transform.position, transform.rotation);
        newSound.transform.parent = gameObject.transform.parent;
        Destroy(gameObject);
    }






    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PongDestoryProjectile());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
