using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public float playerSpeed;
    public float Life;
    public float scrollSpeed;
    public Rigidbody RG;
    public GameObject ShotT;
    public GameObject ShotK;
    public GameObject ShotS;
    private float shift;
    public AudioSource AS;


    void Awake()
    {
        Application.targetFrameRate = 30;
    }
    void Start()
    {
        ShotK.SetActive(false);
        ShotS.SetActive(false);
        ShotT.SetActive(true);
        shift = 0;
    }

    void Update()
    {
        PlayerMove();

        float X = transform.position.x;
        if (X <= 80)
        {
            transform.Translate(scrollSpeed, 0, 0);
        }

        if (Life <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }

        if(Input.GetKeyDown(KeyCode.LeftShift)) 
        {
            Shift();
        }
    }

    void PlayerMove()
    {
        float playerMoveX = Input.GetAxis("Horizontal");
        float playerMoveY = Input.GetAxis("Vertical");

        RG.velocity = new Vector3(playerMoveX * playerSpeed, playerMoveY * playerSpeed,0);
    }

    void Shift()
    {
        shift++;
        if (shift == 1)
        {
            ShotK.SetActive(true);
            ShotS.SetActive(false);
            ShotT.SetActive(false);
        }
        if (shift == 2)
        {
            ShotK.SetActive(false);
            ShotS.SetActive(true);
            ShotT.SetActive(false);
        }
        if (shift == 3)
        {
            ShotK.SetActive(false);
            ShotS.SetActive(false);
            ShotT.SetActive(true);
            shift = 0;
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            AS.Play();
            Life--;
            Destroy(other.gameObject);
            Debug.Log(Life);
        }
        else
        {
            if (other.gameObject.tag == "Kaifuku")
            {
                Life++;
                Destroy(other.gameObject);
                Debug.Log(Life);
            }
        }
    }
}
