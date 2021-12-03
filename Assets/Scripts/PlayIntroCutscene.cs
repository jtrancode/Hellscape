using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class PlayIntroCutscene : MonoBehaviour
{
    VideoPlayer videoPlayer = null;
    
    // Start is called before the first frame update
    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.Play();

        // When video is done playing, call LoadNextLevel
        videoPlayer.loopPointReached += LoadNextLevel;
    }

    void LoadNextLevel(VideoPlayer videoPlayer)
    {
        int currentBuildIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentBuildIndex + 1);
    }

    /*
    // Update is called once per frame
    void Update()
    {
        
    }
    */
}
