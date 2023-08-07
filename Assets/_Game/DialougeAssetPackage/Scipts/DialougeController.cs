using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialougeController : MonoBehaviour
{
    [SerializeField] private DialougeView _dialougeView;
    [SerializeField] private DialougeData[] _dialouge;
    private int _counter=0;
    [SerializeField] private DialougeData[] _Options;
    [SerializeField] private DialougeData[] _topReturn;
    [SerializeField] private DialougeData[] _bottomReturn;
    private int _optionCounter;
    [SerializeField] private Button _topButton = null;
    [SerializeField] private Button _bottomButton = null;

    private void Update()
    {
            //make 'slideshow' of text, one click advances dialouge number
            if (_counter < _dialouge.Length)
            {
                if (Input.GetMouseButtonDown(0))
                {
                if (_dialouge[_counter].DisplayNot == false)
                {
                    _dialougeView.Display(_dialouge[_counter]);
                }
                _counter++;
                if (_dialouge[_counter].RespondTo == true)
                {
                    ButtonOnOff(true);
                }
                else
                {
                    ButtonOnOff(false);
                }
            }
            }
    }
    public void TopButtonClicked()
    {
        if(_optionCounter < _Options.Length)
        {
            _dialougeView.Display(_topReturn[_optionCounter]);
            _optionCounter++;
        }
    }
    public void BottomButtonClicked()
    {
        if (_optionCounter < _Options.Length)
        {
            _dialougeView.Display(_bottomReturn[_optionCounter]);
            _optionCounter++;
        }
    }
    private void ButtonOnOff(bool turnOnOff)
    {
        _topButton.gameObject.SetActive(turnOnOff);
        _bottomButton.gameObject.SetActive(turnOnOff);
    }
}