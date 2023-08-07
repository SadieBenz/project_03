using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Dialouge", fileName = "DLG_")]

public class DialougeData : ScriptableObject
{
    [Multiline][SerializeField] private string _dialouge = ",,.";
    [SerializeField] private string _characterName = "...";
    [SerializeField] private Sprite _portrait = null;
    [SerializeField] private bool _respondTo = false;
    [SerializeField] private bool _displayNot = false;

    public string Dialouge => _dialouge;
    public string CharacterName => _characterName;
    public Sprite Portriat => _portrait;
    public bool RespondTo => _respondTo;
    public bool DisplayNot => _displayNot;
}
