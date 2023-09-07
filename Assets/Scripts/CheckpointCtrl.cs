using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointCtrl : MonoBehaviour
{
    public GameObject[] checkpoints;

    public Transform player;
    public int activeCheckpointIndex;
    
    // Start is called before the first frame update
    void Start()
    {
        checkpoints = GameObject.FindGameObjectsWithTag("Checkpoint");
        Debug.Log(GameObject.FindGameObjectsWithTag("Checkpoint"));

        player.position = checkpoints[0].transform.position;
        activeCheckpointIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
