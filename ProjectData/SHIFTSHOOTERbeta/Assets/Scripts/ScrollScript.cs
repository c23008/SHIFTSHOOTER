using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollScript : MonoBehaviour
{
    public int score;
    public GameObject ScoreText;
    public float scrollSpeed;
    public static int nowScore;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        nowScore = score;
        Text scoreText = ScoreText.GetComponent<Text>();
        scoreText.text = "Score:" + nowScore;

        float X = transform.position.x;
        if (X <= 90)
        {
            transform.Translate(scrollSpeed, 0, 0);
        }
        AddScore(0);
    }
    public void AddScore(int s)
    {
        score += s;
    }
}
