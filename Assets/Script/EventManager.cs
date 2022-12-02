using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    private RockFall rockFallScript;
    private PlatformFall platformFallScript;
    bool isSpwawningRock = false;
    bool isSpwawningPlatform = false;

    private void Awake()
    {
        rockFallScript = GetComponent<RockFall>();
        platformFallScript = GetComponent<PlatformFall>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!isSpwawningPlatform)
        {
            StartCoroutine(platformfall());
        }

        if (!isSpwawningRock)
        {
            StartCoroutine(rockfall());
        }
        

    }

    IEnumerator platformfall()
    {
        isSpwawningPlatform = true;
        yield return new WaitForSeconds(5);
        platformFallScript.platformFall();
        isSpwawningPlatform = false;
    }

    IEnumerator rockfall()
    {
        isSpwawningRock = true;
        yield return new WaitForSeconds(3);
        rockFallScript.RockSpawn();
        isSpwawningRock = false;
    }
}