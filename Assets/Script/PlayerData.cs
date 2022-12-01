using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData 
{
    public float bestTime;
    

    public PlayerData (TimerManager timerManager)
    {
        bestTime = timerManager.bestTime;
    }
}
