using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public static float playerHealth;
    private float lerpTimer;
    public static float maxHealth = 100f;
    public float chipSpeed = 2f;
    public Image frontHB;
    public Image backHB;

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Target"))
        {
            RecoverHealth(20f);
            Debug.Log(playerHealth);
        }
    }
    void Start()
    {
        playerHealth = maxHealth;

    }

    // Update is called once per frame
    void Update()
    {
        playerHealth = Mathf.Clamp(playerHealth, 0 , maxHealth);
    }

   
    public static void TakeDamage(float damage) {
        playerHealth -= damage;
    }

    public static void RecoverHealth(float health) {
        if(playerHealth < maxHealth) {
            playerHealth += health;
        }
        Debug.Log(playerHealth);
    }
}
