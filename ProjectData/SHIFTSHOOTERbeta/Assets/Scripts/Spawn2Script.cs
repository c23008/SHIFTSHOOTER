using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn2Script : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public float dt;
    public float wt;
    public float nowPosiX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        nowPosiX = transform.position.x;
        dt += Time.deltaTime;
        if (dt > wt)
        {
            dt = 0.0f;
            EnemyShot();
        }
        if (nowPosiX > 100)
        {
            Destroy(gameObject);
        }
    }
    void EnemyShot()
    {
        Instantiate(EnemyPrefab, transform.position, transform.rotation);
    }
}