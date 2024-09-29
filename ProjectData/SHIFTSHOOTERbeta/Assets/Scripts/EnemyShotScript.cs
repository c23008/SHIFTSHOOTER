using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShotScript : MonoBehaviour
{
    public GameObject BulletPrefab;
    public float dt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dt += Time.deltaTime;
        if (dt > 1)
        {
            dt = 0.0f;
            Instantiate(BulletPrefab, transform.position, transform.rotation);
            BulletPrefab.transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
