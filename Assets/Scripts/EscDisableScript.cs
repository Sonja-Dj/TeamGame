using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscDisableScript : MonoBehaviour
{
    public GameObject newText;
    
    // Start is called before the first frame update
    void Start()
    {
        newText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gameObject.GetComponent<Animator>().Play("letter01-fade-out");

            StartCoroutine("DeactivateObject");
            //gameObject.SetActive(false);
        }
    }

    private IEnumerator DeactivateObject()
    {
        yield return new WaitForSeconds(3);
        gameObject.SetActive(false);
        newText.SetActive(true);
    }
}
