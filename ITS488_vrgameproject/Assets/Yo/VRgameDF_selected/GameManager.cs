using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public float timeTillNextLevel = 30.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timeTillNextLevel > 0)
        {
            timeTillNextLevel -= Time.deltaTime;
            if (timeTillNextLevel < 0)
            {
                LoadNextScene();
            }
            print("Time Till Next Level: " + timeTillNextLevel);
        }
    }

    public void LoadNextScene()
    {
        // Getting Index of Active Scene
        int currentIndex = SceneManager.GetActiveScene().buildIndex;

        // Load Next Scene
        SceneManager.LoadScene(currentIndex + 1);
    }

    public void LocalPreviousLevel()
    {
        // Getting Index of Active Scene
        int currentIndex = SceneManager.GetActiveScene().buildIndex;

        // Load Previous Scene
        SceneManager.LoadScene(currentIndex - 1);
    }
}
