using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnKotak8 : MonoBehaviour
{
    public GameObject Kotak;

    float Vertikal, Horizontal, Total;
    void Start()
    {
        Total = Random.Range(5, 20);
        for (int i = 0; i < Total; i++)
        {
            Vertikal = Random.Range(3.37f, -3.37f);
            Horizontal = Random.Range(6.32f, -6.32f);
            Instantiate(Kotak, new Vector2(Horizontal, Vertikal), Quaternion.identity);
        }
    }
}
