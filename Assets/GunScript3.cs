using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript3 : MonoBehaviour
{

    public Transform target;
    [Header("Shooting")]
    public GameObject gun;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPos = new Vector3(target.position.x, target.position.y, target.position.z);
        transform.LookAt(targetPos);
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    public void Shoot()
    {
        Instantiate(bullet, gun.transform.position, gun.transform.rotation);
    }
}