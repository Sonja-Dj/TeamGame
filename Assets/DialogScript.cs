using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogScript : MonoBehaviour
{
    //public GameObject owl;
    public GameObject[] dialog;

    public int activeIndex = 0;

    private void Awake()
    {
        for (int i = 0; i < dialog.Length; i++)
        {
            dialog[i].SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        activeIndex = 0;
        NextDialogBox(activeIndex);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (activeIndex == 3)
            {
                SceneManager.LoadScene("MainLevel");
            }
            
            StartCoroutine("DeactivateDialog");
            //gameObject.SetActive(false);
        }
    }

    public void NextDialogBox(int index)
    {
        dialog[index].SetActive(true);
        activeIndex++; 
    }
    
    private IEnumerator DeactivateDialog()
    {
        dialog[activeIndex - 1].GetComponent<Animator>().Play("fade-out-sprite");

        yield return new WaitForSeconds(2);
        dialog[activeIndex - 1].SetActive(false);
        
        NextDialogBox(activeIndex);
    }
}
