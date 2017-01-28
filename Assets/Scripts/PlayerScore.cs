using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class PlayerScore : MonoBehaviour
{
    public Text myGuiText;
    public Canvas canvas;
    [SerializeField] private GameObject explosionPrefab;
    bool hit;
    GameObject _fireball;

    void Start()
    {
        canvas = FindObjectOfType<Canvas>();
        explosionPrefab = canvas.GetComponent<Score>().explosionPrefab;
        hit = false;
    }

    void OnTriggerEnter(Collider other)
    {
        Score score = canvas.GetComponent<Score>();
        if (hit == true) return;
        hit = true;
        score.score += 1;
        myGuiText.text = "Score: "+score.score;
        Destroy(this.gameObject);
        _fireball = Instantiate(explosionPrefab) as GameObject;
        Destroy(_fireball, 6);
    }
    void Update()
    {
    }
}