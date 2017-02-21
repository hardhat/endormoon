﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour {

    public int score;
    public GameObject explosionPrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void MainMenu()
    {
        StartCoroutine(launchAfterDelay(0));
    }

    public IEnumerator launchAfterDelay(int index)
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(index);
    }
}
