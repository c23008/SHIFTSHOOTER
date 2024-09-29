using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class StartScript : MonoBehaviour
{
    public AudioSource AS;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 30;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnStart()
    {
        AS.Play();
        Invoke("OnMain", 1);
    }

    public void OnMain()
    {
        SceneManager.LoadScene("Main");
    }
}
