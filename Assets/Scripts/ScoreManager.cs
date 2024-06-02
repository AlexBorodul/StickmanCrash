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
    [SerializeField] private Car car;
    void Update()
    {
        _scoreText.text = "Очки: " + score.ToString();
    }

    public void addScore(float additionalScore)
    {
        score += (int)additionalScore;
    }
}
