using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscDisableSimple : MonoBehaviour
{
    public GameObject owl;
    
    // Start is called before the first frame update
    void Start()
    {
        owl.SetActive(false);
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gameObject.GetComponent<Animator>().Play("fade-out");

            StartCoroutine("DeactivateObject");
            //gameObject.SetActive(false);
        }
    }

    private IEnumerator DeactivateObject()
    {
        yield return new WaitForSeconds(3);
        
        owl.SetActive(true);
        gameObject.SetActive(false);
        this.enabled = false;

    }
}
