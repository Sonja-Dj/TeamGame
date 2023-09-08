using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraZoomOut : MonoBehaviour
{
    public Camera mainCam;
    public bool changeCam = false;
    
    private float startingSize;
    private float endSize = 9.0f;
    private float t = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        startingSize = mainCam.orthographicSize;
    }

    private void Update()
    {
        if (changeCam)
        {
            t += Time.deltaTime;
            mainCam.orthographicSize = Mathf.SmoothStep(startingSize, endSize, t);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            changeCam = true;
        }
    }
}
