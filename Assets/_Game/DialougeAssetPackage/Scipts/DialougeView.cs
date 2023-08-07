using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DialougeView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _dialougeTextUI;
    [SerializeField] private TextMeshProUGUI _characterNameUI;
    [SerializeField] private Image _portraitUI;

    public void Display(DialougeData data)
    {
        _dialougeTextUI.text = data.Dialouge;
        _characterNameUI.text = data.CharacterName;
        _portraitUI.sprite = data.Portriat;
    }
}
