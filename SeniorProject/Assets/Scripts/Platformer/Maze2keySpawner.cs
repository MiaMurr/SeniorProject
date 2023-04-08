using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maze2keySpawner : MonoBehaviour
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
        int Spawn11 = 0;
        int loop = 0;

        while (loop != 3)
        {
            int ranNum = Random.Range(0, 11);

            switch (ranNum)
            {
                case 1:
                    if (Spawn1 > 0)
                    {
                        break;
                    }
                    Spawn1++;
                    loop++;
                    Instantiate(prefab, new Vector3(-14.7299995f, 12.8400002f, -0.805999994f), Quaternion.identity);

                    break;
                case 2:
                    if (Spawn2 > 0)
                    {
                        break;
                    }
                    Spawn2++;
                    loop++;
                    Instantiate(prefab, new Vector3(-14.7299995f, 4.19999981f, -0.805999994f), Quaternion.identity);

                    break;
                case 3:
                    if (Spawn3 > 0)
                    {
                        break;
                    }
                    Spawn3++;
                    loop++;
                    Instantiate(prefab, new Vector3(-24.8600006f, 1.51999998f, -0.805999994f), Quaternion.identity);

                    break;
                case 4:
                    if (Spawn4 > 0)
                    {
                        break;
                    }
                    Spawn4++;
                    loop++;
                    Instantiate(prefab, new Vector3(-29.2600002f, 7.46000004f, -0.805999994f), Quaternion.identity);

                    break;
                case 5:
                    if (Spawn5 > 0)
                    {
                        break;
                    }
                    Spawn5++;
                    loop++;
                    Instantiate(prefab, new Vector3(-37.8499985f, 4.46999979f, -0.805999994f), Quaternion.identity);

                    break;
                case 6:
                    if (Spawn6 > 0)
                    {
                        break;
                    }
                    Spawn6++;
                    loop++;
                    Instantiate(prefab, new Vector3(-37.9300003f, 12.8000002f, -0.805999994f), Quaternion.identity);

                    break;
                case 7:
                    if (Spawn7 > 0)
                    {
                        break;
                    }
                    Spawn7++;
                    loop++;
                    Instantiate(prefab, new Vector3(-37.9300003f, 10.1099997f, -0.805999994f), Quaternion.identity);

                    break;
                case 8:
                    if (Spawn8 > 0)
                    {
                        break;
                    }
                    Spawn8++;
                    loop++;
                    Instantiate(prefab, new Vector3(-36.9099998f, -10.8100004f, -0.805999994f), Quaternion.identity);

                    break;
                case 9:
                    if (Spawn9 > 0)
                    {
                        break;
                    }
                    Spawn9++;
                    loop++;
                    Instantiate(prefab, new Vector3(-29.6100006f, -7.78999996f, -0.805999994f), Quaternion.identity);

                    break;
                case 10:
                    if (Spawn10 > 0)
                    {
                        break;
                    }
                    Spawn10++;
                    loop++;
                    Instantiate(prefab, new Vector3(-14.4499998f, -7.67999983f, -0.805999994f), Quaternion.identity);
                    break;
                case 11:
                    if (Spawn11 > 0)
                    {
                        break;
                    }
                    Spawn11++;
                    loop++;
                    Instantiate(prefab, new Vector3(-14.4499998f, -13.4899998f, -0.805999994f), Quaternion.identity);
                    break;
                default:

                    break;
            }



        }
    }

    void update()
    {


    }
}
