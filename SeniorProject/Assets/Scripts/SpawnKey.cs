using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnKey : MonoBehaviour
{

    public Transform prefab;
    void Start()
    {
        Instantiate(prefab, new Vector3(2.88f, 8.59f, 1.5f), Quaternion.identity);
    }
}
