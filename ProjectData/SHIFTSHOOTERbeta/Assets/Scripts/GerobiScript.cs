using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerobiScript : MonoBehaviour
{
    public GameObject BulletPrefab;
    public float interval;
    private float timer = 0.0f;
    void Start()
    {
        
    }

    void Update()
    {
        if (timer <= 0.0f)
        {
            PlayerShot();
        }

        if (timer > 0.0f)
        {
            timer -= Time.deltaTime;
        }
    }
    void PlayerShot()
    {
        Instantiate(BulletPrefab, transform.position, transform.rotation);
        BulletPrefab.transform.localScale = new Vector3(1, 10, 1);
        timer = interval;
    }
}
