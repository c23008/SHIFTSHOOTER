using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;

public class BulletSShotScript : MonoBehaviour
{
    public GameObject BulletPrefab;
    public float interval;
    private float timer = 0.0f;
    public AudioSource AS;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
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
        Instantiate(BulletPrefab, transform.position, transform.rotation = Quaternion.Euler(Random.Range(45, 136), 90, 0));
        Instantiate(BulletPrefab, transform.position, transform.rotation = Quaternion.Euler(Random.Range(45, 136), 90, 0));
        Instantiate(BulletPrefab, transform.position, transform.rotation = Quaternion.Euler(Random.Range(45, 136), 90, 0));
        Instantiate(BulletPrefab, transform.position, transform.rotation = Quaternion.Euler(Random.Range(45, 136), 90, 0));
        Instantiate(BulletPrefab, transform.position, transform.rotation = Quaternion.Euler(Random.Range(45, 136), 90, 0));
        timer = interval;
    }
}
