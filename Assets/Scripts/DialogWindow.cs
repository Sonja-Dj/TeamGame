using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogWindow : MonoBehaviour
{
    public string windowName;
    public GameObject[] windows;
    private GameObject player;

    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.FindWithTag("Player");
        // window = GameObject.Find(windowName);
        // window.SetActive(false);

        windows = player.GetComponent<TurnOffWindows>().wind;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            for (int i = 0; i < windows.Length; i++)
            {
                if(windows[i].name == windowName)
                {
                    windows[i].SetActive(true);
                    Debug.Log(windows[i]);
                    StartCoroutine(DestroyWindow(i));
                }
            }
        }

    }

    IEnumerator DestroyWindow(int i)
    {
        yield return new WaitForSeconds(5);
        Destroy(windows[i]);
    }
}
