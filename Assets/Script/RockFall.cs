using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockFall : MonoBehaviour
{
    public GameObject Rock;
    public GameObject[] Plateforms;
    private int rand;
    private int listLenght;

    // Start is called before the first frame update
    void Start()
    {
        Plateforms = GameObject.FindGameObjectsWithTag("Plateform");
        rand = Random.Range(0, 9);
        Instantiate(Rock,Plateforms[rand].transform);
    }
}
