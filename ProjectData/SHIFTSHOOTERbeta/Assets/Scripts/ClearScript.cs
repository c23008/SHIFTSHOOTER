using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class ClearScript : MonoBehaviour
{
    public AudioSource AS;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnRes()
    {
        AS.Play();
        Invoke("OnRestart", 1);
    }

    public void OnFinButton()
    {
        AS.Play();
        Invoke("OnFin", 1);
    }
    public void OnRestart()
    {
        SceneManager.LoadScene("Main");
    }

    public void OnFin()
    {
        Application.Quit();
    }
}
