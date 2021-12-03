using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillVolume : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player has entered");
        // Turn off gameObject that entered
        //other.gameObject.SetActive(false);
        PlayerController playerController = other.GetComponent<PlayerController>();

        if(playerController != null)
        {
            playerController.Die();
        }
    }

    /*
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    */
}
