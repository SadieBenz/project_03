using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DialougeController : MonoBehaviour
{
    [SerializeField] private DialougeView _dialougeView;
    [SerializeField] private DialougeData _dialouge01;

    private void Update()
    {
        if (Keyboard.current.qKey.wasPressedThisFrame)
        {
            _dialougeView.Display(_dialouge01);
        }
    }
}
