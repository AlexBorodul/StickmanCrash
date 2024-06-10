using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    private float score = 0;
    [SerializeField] private TMP_Text _scoreText;
    void Update()
    {
        _scoreText.text = "Счёт: " + score.ToString();
    }

    public void addScore(float additionalScore)
    {
        score += (int)additionalScore;
    }

    public string viewScore()
    {
        return "Получено очков за заезд : " + score.ToString();
    }
}
