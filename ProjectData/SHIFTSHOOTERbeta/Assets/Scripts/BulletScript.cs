using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
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
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Kakusan") 
        {
            return;
        }
        else
        {
            Destroy(this.gameObject, 0.01f);
        }
    }
}
