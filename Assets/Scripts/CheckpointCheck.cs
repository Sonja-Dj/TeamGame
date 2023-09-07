using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointCheck : MonoBehaviour
{
    public CheckpointCtrl checkpointCtrl;
    
    // Start is called before the first frame update
    void Start()
    {
        checkpointCtrl = GameObject.Find("CheckpointCTRL").GetComponent<CheckpointCtrl>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.tag);
        if (col.CompareTag("Player"))
        {
            GetComponent<BoxCollider2D>().enabled = false;

            checkpointCtrl.activeCheckpointIndex++;
        }
    }

    //
    //
    // private void OnTriggerEnter2D(Collider other)
    // {
    //     Debug.Log(other.tag);
    //     if (other.CompareTag("player"))
    //     {
    //         enabled = false;
    //     }
    //     
    // }
}
