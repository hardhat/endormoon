using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void PlayGame()
    {
        StartCoroutine(launchAfterDelay(1));
    }

    public IEnumerator launchAfterDelay(int index)
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(index);
    }
}
