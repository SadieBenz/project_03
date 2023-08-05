using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Dialouge", fileName = "DLG_")]

public class DialougeData : ScriptableObject
{
    [Multiline][SerializeField] private string _dialouge = ",,.";
    [SerializeField] private string _characterName = "...";
    [SerializeField] private Sprite _portrait = null;

    public string Dialouge => _dialouge;
    public string CharacterName => _characterName;
    public Sprite Portriat => _portrait;
}
