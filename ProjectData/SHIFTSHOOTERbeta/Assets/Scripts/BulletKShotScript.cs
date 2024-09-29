using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class BulletKShotScript : MonoBehaviour
{
    public GameObject BulletPrefab;
    public float interval;
    private float timer = 0.0f;
    public AudioSource AS;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetButton("Fire1") && timer <= 0.0f)
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
        AS.Play();
        Instantiate(BulletPrefab, transform.position, transform.rotation);
        BulletPrefab.transform.localScale = new Vector3(1, 10, 1);
        timer = interval;
    }
}
