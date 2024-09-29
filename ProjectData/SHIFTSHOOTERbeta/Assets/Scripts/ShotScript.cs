using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio; 


public class ShotScript : MonoBehaviour
{
    public GameObject BulletPrefab;
    public float ShotPow;
    public float interval;
    private float timer = 0.0f;
    public AudioSource AS;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            ShotChage();
        }

        if (Input.GetButtonUp("Fire1") && timer <= 0.0f)
        {
                PlayerShot();
        }

        if (timer > 0.0f)
        {
            timer -= Time.deltaTime;
        }
    }

    void ShotChage()
    {
        ShotPow ++;
    }
    void PlayerShot()
    {
        if (ShotPow <= 25)
        {
            AS.Play();
            Instantiate(BulletPrefab, transform.position, transform.rotation);
            BulletPrefab.transform.localScale = new Vector3(1,1,1);
            ShotPow = 0;
            timer = interval;
        }
        else
        {
            AS.Play();
            this.transform.localPosition = new Vector3((ShotPow / 25) + 3, 1, 0);
            Instantiate(BulletPrefab, transform.position, transform.rotation);
            BulletPrefab.transform.localScale = new Vector3(ShotPow / 25, ShotPow / 25, ShotPow / 25);
            ShotPow = 0;
            timer = interval;
        }
    }
}
