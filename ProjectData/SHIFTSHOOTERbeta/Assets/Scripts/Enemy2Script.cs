using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Script : MonoBehaviour
{
    Vector3 startPosition;

    public float nowPosi;
    public float enemy2Speed;
    public float enemy2DeleteTime;  
    public float enemy2amplitude;
    public float EnemyLife;
    public int enemyScore;
    public ScrollScript ScrollScript;
    void Start()
    {
        nowPosi = transform.position.y;
        Destroy(gameObject,enemy2DeleteTime);
    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x, nowPosi + Mathf.PingPong(Time.time * enemy2Speed, enemy2amplitude), transform.position.z);
        ScrollScript = GameObject.Find("MainCamera").GetComponent<ScrollScript>();
        Life();
    }

    void Life()
    {
        if (EnemyLife <= 0)
        {
            ScrollScript.AddScore(enemyScore);
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision other)
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
        if(other.gameObject.tag == "Kakusan")
        {
            EnemyLife -= 2;
            Destroy(other.gameObject) ;
        }
    }
}
