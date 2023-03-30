using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletScript : MonoBehaviour
{
    public PlayerHealtScript playerHealth;
    public int damage = 2;
    public float speed = 5f;
    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = GameObject.Find("Player").GetComponent<PlayerHealtScript>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerHealth.TakeDamage(damage);
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
            print("osuin");
           
        }
        else if (other.gameObject.CompareTag("MisTarget"))
        {
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
            
        }
    }
}