using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnKey : MonoBehaviour
{

    public Transform prefab;
   
    void Start()
    {
        
        for (int i = 0; i < 3; i++)
        {
            int ranNum = Random.Range(0, 10);
            
            switch (ranNum)
            {
                case 1:
                    Instantiate(prefab, new Vector3(-6.526f, 0.85f, 0.816f), Quaternion.identity);

                    break;
                case 2:
                    Instantiate(prefab, new Vector3(-6.52600002f, 0.850000024f, 6.05999994f), Quaternion.identity);

                    break;
                case 3:
                    Instantiate(prefab, new Vector3(-9.21000004f, 0.850000024f, 6.05999994f), Quaternion.identity);

                    break;
                case 4:
                    Instantiate(prefab, new Vector3(-12f, 0.850000024f, 13.3699999f), Quaternion.identity);

                    break;
                case 5:
                    Instantiate(prefab, new Vector3(9.38000011f, 0.850000024f, 8.47000027f), Quaternion.identity);

                    break;
                case 6:
                    Instantiate(prefab, new Vector3(9.27000046f, 0.850000024f, 1.55999994f), Quaternion.identity);

                    break;
                case 7:
                    Instantiate(prefab, new Vector3(4.80999994f, 0.850000024f, -7.94999981f), Quaternion.identity);

                    break;
                case 8:
                    Instantiate(prefab, new Vector3(-2.45000005f, 0.850000024f, -7.86000013f), Quaternion.identity);

                    break;
                case 9:
                    Instantiate(prefab, new Vector3(-2.30999994f, 0.850000024f, -14.1499996f), Quaternion.identity);

                    break;
                case 10:
                    Instantiate(prefab, new Vector3(-5.57999992f, 0.850000024f, -12.1899996f), Quaternion.identity);
                    break;
                default:
                    
                    break;
            }

            

        }
    }

    void update() { 
    
    
    }
}
