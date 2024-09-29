using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossScript : MonoBehaviour
{

    public Rigidbody EnemyRG;
    public float EnemySpeed;
    public float EnemyDeleteTime;
    public float EnemyLife;
    public int enemyScore;
    public ScrollScript ScrollScript;
    void Start()
    {
        ScrollScript = GameObject.Find("MainCamera").GetComponent<ScrollScript>();
        EnemyRG.AddForce((transform.forward) * EnemySpeed);
    }

    void Update()
    {
        Life();
    }
    void Life()
    {
        if (EnemyLife <= 0)
        {
            ScrollScript.AddScore(enemyScore);
            SceneManager.LoadScene("Clear");
            Destroy(gameObject);
        }
    }

    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            EnemyLife--;
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
