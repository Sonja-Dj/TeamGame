using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupScript : MonoBehaviour
{
    public bool pickupPossible;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player") && pickupPossible)
        {
            Destroy(gameObject);
        }
    }
}
