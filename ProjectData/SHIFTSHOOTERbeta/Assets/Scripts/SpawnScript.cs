using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public float dt;
    public float wt;
    public float nowPosi;
    public float nowPosiX;
    public float enemy2Speed;
    public float enemy2DeleteTime;
    public float enemy2amplitude;
    // Start is called before the first frame update
    void Start()
    {
        nowPosi = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, nowPosi + Mathf.PingPong(Time.time * enemy2Speed, enemy2amplitude), transform.position.z);
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
