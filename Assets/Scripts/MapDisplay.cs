using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MapDisplay : MonoBehaviour
{
    [SerializeField] private TMP_Text _mapName;
    [SerializeField] private Image _mapImage;
    [SerializeField] private Button _playButton;
    [SerializeField] private GameObject _lock;

    public void DisplayMap(Map map)
    {
        _mapName.text = map.mapName;
        _mapImage.sprite = map.mapImage;

        bool mapUnlocked = PlayerPrefs.GetInt("currentScene", 0) >= map.mapIndex;
        _lock.SetActive(!mapUnlocked);
        _playButton.interactable = mapUnlocked;

        if (mapUnlocked)
        {
            _mapImage.color = Color.white;
        }

        else
        {
            _mapImage.color = Color.grey;
        }
    }
}
