using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public GameObject eggPrefab;
    public Transform eggSpawn;
    public float eggVelocity = 30;
    public float eggPrefabLifetime = 3f;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            FireWeapon();
        }
    }

    private void FireWeapon()
    {
        GameObject egg = Instantiate(eggPrefab, eggSpawn.position, Quaternion.identity);
        egg.GetComponent<Rigidbody>().AddForce(eggSpawn.forward.normalized * eggVelocity, ForceMode.Impulse);
        StartCoroutine(DestroyEgg(egg, eggPrefabLifetime));
    }

    private IEnumerator DestroyEgg(GameObject egg, float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(egg);
    }
}
