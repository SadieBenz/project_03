using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialougeController : MonoBehaviour
{
    [SerializeField] private DialougeView _dialougeView;
    [SerializeField] private DialougeData[] _dialouge;
    private int _counter=0;

    private void Update()
    {
        //make 'slideshow' of text, one click advances dialouge number
        if (_counter < _dialouge.Length)
        {
            if (Input.GetMouseButtonDown(0))
            {
                /* if (_dialouge[i].checkRespond() = true)
                 {

                 }*/
                _dialougeView.Display(_dialouge[_counter]);
                _counter++;
            }
        }
    }
}