using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    [Header("Component")]

    public GameObject gameOverUI;
    public GameObject gameView;
    public GameObject player;

    public SwipeTest playerSwipeTest;


    public void Start()
    {


        playerSwipeTest = GetComponent<SwipeTest>();
    }



    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "DeathZone")
        {
            gameView.SetActive(false);
            gameOverUI.SetActive(true);

            player.SetActive(false);

            player.transform.position = new Vector3(0, 2, 0);

            playerSwipeTest.desiredPosition = new Vector3(0, 1, 0);

        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
