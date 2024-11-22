using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("COLISIONOOOOOOO");
        if(collision.gameObject.CompareTag("Target"))
        {
            Debug.Log("hit " + collision.gameObject.name + "!");
            Destroy(gameObject);
        }
    }
}
