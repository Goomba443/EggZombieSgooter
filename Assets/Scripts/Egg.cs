using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Target"))
        {
            Debug.Log("hit " + collision.gameObject.name + "!");

            CreateEggImpactEffect(collision);
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Wall"))
        {
            Debug.Log("hit a wall");
            CreateEggImpactEffect(collision);
            Destroy(gameObject);
        }
    }

    void CreateEggImpactEffect(Collision objectHit)
    {
        ContactPoint contact = objectHit.contacts[0];
        GameObject eggWhite = Instantiate(
            GlobalReferences.Instance.eggImpactEffectPrefab,
            contact.point,
            Quaternion.LookRotation(contact.normal)
            );

        eggWhite.transform.SetParent(objectHit.gameObject.transform);
    }
}
