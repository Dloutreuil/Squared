using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerCoins : MonoBehaviour
{
    [Header("Component")]
    public TextMeshProUGUI runCoinCounter;
    public TextMeshProUGUI gameOverCoinCounter;
    public TextMeshProUGUI totalCoinCounter;
   

    [Header("Counter Settings")]
    public int currentCoins;
    public int totalCoins;
    public int DelayAmount;


    protected float Timer;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        gameOverCoinCounter.text = currentCoins.ToString("+ 0");

        totalCoinCounter.text = currentCoins.ToString("0");
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Coin")
        {
            currentCoins += 1;
            runCoinCounter.text = currentCoins.ToString();
            gameOverCoinCounter.text = runCoinCounter.text;

            Destroy(collision.gameObject);
        }
    }

    

}
