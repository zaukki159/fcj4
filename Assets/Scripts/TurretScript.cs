using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretScript : MonoBehaviour
{
    public GameObject[] target;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectsWithTag("Target");
        InvokeRepeating("Shoot", 1f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        int rnd = Random.Range(0, 4);
        print(rnd);
        transform.LookAt(target[rnd].transform);
    }

    public void Shoot()
    {

        Instantiate(bullet, transform.position, transform.rotation);
        
    }
}