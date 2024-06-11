using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class FinalTextManager : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    [SerializeField] private ScoreManager _scoreManager;
    void Update()
    {
        /*_text.text = _scoreManager.viewScore();*/
        _text.GetComponent<TMP_Text>().text = _scoreManager.viewScore();
    }
}
