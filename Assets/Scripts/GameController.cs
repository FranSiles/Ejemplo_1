using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    private List<GameObject> _cans; // Lista de elementos de objetivos 
    private int _score = 0;
    public TextMeshProUGUI scoreText;

    void Start()
    {
        scoreText = GameObject.Find("ScoreText").GetComponent<TextMeshProUGUI>();
        _cans = new List<GameObject>(GameObject.FindGameObjectsWithTag("Cans"));
    }

    public void TargetHit(GameObject go)
    {
        Debug.Log("Score: " + _score);
        if (_cans.Contains(go))
        {
            _score += 10;
            _cans.Remove(go);
            Debug.Log("Score " + _score);
            Destroy(go, 5);
            scoreText.text = "Score " + _score;
        }
    }
}
