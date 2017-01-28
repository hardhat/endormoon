using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour

{
    public float playedTime;
    public Text timeDisplay;
    Canvas canvas;
     
    public void Start()
    {
        playedTime = 0.0f;
        canvas = FindObjectOfType<Canvas>();
    }

    public void Update()
    {
        Score score = canvas.GetComponent<Score>();
        if (score.score < 5)
        {
            playedTime += Time.deltaTime;
            int min = (int)playedTime / 60;
            int sec = (int)playedTime % 60;
            timeDisplay.text = "Time: " + min + (sec<10?":0":":") + sec; //Mathf.RoundToInt(playedTime).ToString();
               
        }
    }
    
}
