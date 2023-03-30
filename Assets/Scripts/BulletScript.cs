using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float bulletSpeed = -15f;
    public GameManager gm;
    public GameObject explosion1;
    public GameObject explosion2;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GM").GetComponent<GameManager>();
        Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * bulletSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Airship"))
        {
            Instantiate(explosion1, transform.position, transform.rotation);
            Destroy(other.gameObject);
            
            Destroy(gameObject);
            gm.score +=100;
            gm.airShipsDestroyed += 1;
        }

        if (other.gameObject.CompareTag("EnemyBullet"))
        {
            Instantiate(explosion2, transform.position, transform.rotation);
            Destroy(other.gameObject);
            
            Destroy(gameObject);
            gm.score += 10;
        }

        if (other.gameObject.CompareTag("Rakennus"))
        {
            Instantiate(explosion2, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}