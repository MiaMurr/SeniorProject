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
                    Instantiate(prefab, new Vector3(-38.0400009f, 0.850000024f, 12.1400003f), Quaternion.identity);

                    break;
                case 2:
                    if (Spawn2 > 0)
                    {
                        break;
                    }
                    Spawn2++;
                    loop++;
                    Instantiate(prefab, new Vector3(-37.9399986f, 0.850000024f, 9.38000011f), Quaternion.identity);

                    break;
                case 3:
                    if (Spawn3 > 0)
                    {
                        break;
                    }
                    Spawn3++;
                    loop++;
                    Instantiate(prefab, new Vector3(-37.9399986f, 0.850000024f, 3.6500001f), Quaternion.identity);

                    break;
                case 4:
                    if (Spawn4 > 0)
                    {
                        break;
                    }
                    Spawn4++;
                    loop++;
                    Instantiate(prefab, new Vector3(-37.0099983f, 0.850000024f, -11.4799995f), Quaternion.identity);

                    break;
                case 5:
                    if (Spawn5 > 0)
                    {
                        break;
                    }
                    Spawn5++;
                    loop++;
                    Instantiate(prefab, new Vector3(-29.5100002f, 0.850000024f, -8.46000004f), Quaternion.identity);

                    break;
                case 6:
                    if (Spawn6 > 0)
                    {
                        break;
                    }
                    Spawn6++;
                    loop++;
                    Instantiate(prefab, new Vector3(-24.9400005f, 0.850000024f, 0.930000007f), Quaternion.identity);

                    break;
                case 7:
                    if (Spawn7 > 0)
                    {
                        break;
                    }
                    Spawn7++;
                    loop++;
                    Instantiate(prefab, new Vector3(-29.5200005f, 0.850000024f, 6.78000021f), Quaternion.identity);

                    break;
                case 8:
                    if (Spawn8 > 0)
                    {
                        break;
                    }
                    Spawn8++;
                    loop++;
                    Instantiate(prefab, new Vector3(-14.6999998f, 0.850000024f, 12.1199999f), Quaternion.identity);

                    break;
                case 9:
                    if (Spawn9 > 0)
                    {
                        break;
                    }
                    Spawn9++;
                    loop++;
                    Instantiate(prefab, new Vector3(-14.46f, 0.850000024f, -8.47999954f), Quaternion.identity);

                    break;
                case 10:
                    if (Spawn10 > 0)
                    {
                        break;
                    }
                    Spawn10++;
                    loop++;
                    Instantiate(prefab, new Vector3(-14.6999998f, 0.850000024f, 3.41000009f), Quaternion.identity);
                    break;
                case 11:
                    if (Spawn11 > 0)
                    {
                        break;
                    }
                    Spawn11++;
                    loop++;
                    Instantiate(prefab, new Vector3(-14.46f, 0.850000024f, -14.1400003f), Quaternion.identity);
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
