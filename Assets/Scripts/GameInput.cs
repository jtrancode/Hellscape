using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameInput : MonoBehaviour
{
    /*
    // Start is called before the first frame update
    void Start()
    {
        
    }
    */

    // Update is called once per frame
    void Update()
    {
        // If backspace key pressed, reset level
        if(Input.GetKeyDown(KeyCode.Backspace))
        {
            // Determine current scene
            int currentLevelIndex = SceneManager.GetActiveScene().buildIndex;
            // Reload scene
            SceneManager.LoadScene(currentLevelIndex);
        }

        // If escape key pressed, exit application
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Exit the game");
            Application.Quit();
        }
    }
}
