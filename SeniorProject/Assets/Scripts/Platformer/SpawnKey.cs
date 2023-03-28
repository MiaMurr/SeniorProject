using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnKey : MonoBehaviour
{

    public Transform prefab;
   
    void Start()
    {
        int Spawn1 = 0;
        int Spawn2 = 0;
        int Spawn3 = 0;
        int Spawn4 = 0;
        int Spawn5 = 0;
        int Spawn6 = 0;
        int Spawn7 = 0;
        int Spawn8 = 0;
        int Spawn9 = 0;
        int Spawn10 = 0;
        int loop = 0;

        while (loop != 3)
        {
            int ranNum = Random.Range(0, 10);
            
            switch (ranNum)
            {
                case 1:
                    if (Spawn1 > 0) {
                        break;
                    }
                    Spawn1++;
                    loop++;
                    Instantiate(prefab, new Vector3(-6.526f, 0.85f, 0.816f), Quaternion.identity);

                    break;
                case 2:
                    if (Spawn2 > 0)
                    {
                        break;
                    }
                    Spawn2++;
                    loop++;
                    Instantiate(prefab, new Vector3(-6.52600002f, 0.850000024f, 6.05999994f), Quaternion.identity);

                    break;
                case 3:
                    if (Spawn3 > 0)
                    {
                        break;
                    }
                    Spawn3++;
                    loop++;
                    Instantiate(prefab, new Vector3(-9.21000004f, 0.850000024f, 6.05999994f), Quaternion.identity);

                    break;
                case 4:
                    if (Spawn4 > 0)
                    {
                        break;
                    }
                    Spawn4++;
                    loop++;
                    Instantiate(prefab, new Vector3(-12f, 0.850000024f, 13.3699999f), Quaternion.identity);

                    break;
                case 5:
                    if (Spawn5 > 0)
                    {
                        break;
                    }
                    Spawn5++;
                    loop++;
                    Instantiate(prefab, new Vector3(9.38000011f, 0.850000024f, 8.47000027f), Quaternion.identity);

                    break;
                case 6:
                    if (Spawn6 > 0)
                    {
                        break;
                    }
                    Spawn6++;
                    loop++;
                    Instantiate(prefab, new Vector3(9.27000046f, 0.850000024f, 1.55999994f), Quaternion.identity);

                    break;
                case 7:
                    if (Spawn7 > 0)
                    {
                        break;
                    }
                    Spawn7++;
                    loop++;
                    Instantiate(prefab, new Vector3(4.80999994f, 0.850000024f, -7.94999981f), Quaternion.identity);

                    break;
                case 8:
                    if (Spawn8 > 0)
                    {
                        break;
                    }
                    Spawn8++;
                    loop++;
                    Instantiate(prefab, new Vector3(-2.45000005f, 0.850000024f, -7.86000013f), Quaternion.identity);

                    break;
                case 9:
                    if (Spawn9 > 0)
                    {
                        break;
                    }
                    Spawn9++;
                    loop++;
                    Instantiate(prefab, new Vector3(-2.30999994f, 0.850000024f, -14.1499996f), Quaternion.identity);

                    break;
                case 10:
                    if (Spawn10 > 0)
                    {
                        break;
                    }
                    Spawn10++;
                    loop++;
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
