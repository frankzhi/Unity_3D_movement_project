﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;

    public float restartDelay = 4.0f;

    public GameObject completeLevelUI;

    public void CompleteLevel ()
    {
        Debug.Log("Level Complete");
        completeLevelUI.SetActive(true);
    }

    public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }
        
    }


    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
