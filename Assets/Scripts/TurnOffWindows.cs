using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffWindows : MonoBehaviour
{
    public GameObject[] wind;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < wind.Length; i++)
        {
            wind[i].gameObject.SetActive(false);
        }
    }
}
