using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealtScript : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth;

    public HealtBar healthBar;
    public GameObject retryButton;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(2);
        }
    }

    public void TakeDamage(int damage)
    {
        Debug.Log("otin damagee");
        if (healthBar == null) { Debug.Log("jep mikä ihmeen healthbar"); }
        currentHealth -= damage;
        healthBar.SetHealt(currentHealth);
        if (currentHealth <= 0)
        {
            retryButton.SetActive(true);
            Destroy(gameObject);
        }
    }
}
