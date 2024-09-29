using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletKScript : MonoBehaviour
{
    public float bulletSpeed;
    public float bulletDeleteTime;
    public Rigidbody bulletRG;
    void Start()
    {
        bulletRG.AddForce((transform.up) * bulletSpeed);
        Destroy(this.gameObject, bulletDeleteTime);
    }

    void Update()
    {

    }
}
