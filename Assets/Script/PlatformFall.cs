using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformFall : MonoBehaviour
{
    private GameObject[] Plateforms;
    private int Rand;
    private int lenghtList;

    // Start is called before the first frame update
    void Start()
    {
        Plateforms = GameObject.FindGameObjectsWithTag("Plateform");
        lenghtList = Plateforms.Length;
        Rand = Random.Range(1, lenghtList);


    }
}
