using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScoreScript : MonoBehaviour
{
    public Text EndScore;
    int score = 0;
    public ScrollScript ScrollScript;
    // Start is called before the first frame update
    void Start()
    {
        EndScore.text = ScrollScript.nowScore + "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
