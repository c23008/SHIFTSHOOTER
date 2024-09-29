using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.SocialPlatforms.Impl;

public class EnemyScript : MonoBehaviour
{
    public Rigidbody EnemyRG;
    public float EnemySpeed;
    public float EnemyDeleteTime;
    public float EnemyLife;
    public int s;
    public ScrollScript ScrollScript;
    void Start()
    {
        ScrollScript = GameObject.Find("MainCamera").GetComponent<ScrollScript>();
        Destroy(this.gameObject, EnemyDeleteTime);
    }

    void Update()
    {
        Life();
        Move();
    }
    void Life()
    {
        if (EnemyLife <= 0)
        {
            Debug.Log("a");
            ScrollScript.AddScore(s);
            Debug.Log("b");
            Destroy(gameObject);
        }
    }
    void Move()
    {
        transform.Translate(0, 0, EnemySpeed);
    }

    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "Nomal")
        {
            EnemyLife -= 10;
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Kakusan")
        {
            EnemyLife -= 2;
            Destroy(other.gameObject);
        }
    }
}
