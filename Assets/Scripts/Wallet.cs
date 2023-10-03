using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Wallet : MonoBehaviour
{
    public static Wallet instance = null;

    [SerializeField] private int _startValue;
    [SerializeField] private TMP_Text _walletText;

    private int _currentValue;
   
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance == this)
        {
            Destroy(gameObject);
        }
        _currentValue = _startValue;
        _walletText.text = _startValue.ToString();
    }

    public void ChangeValue(int value)
    {
        if(value <= 0 || _currentValue <= 0)
        {
            return;
        }
        else
        {
            _currentValue -= value;
        }
        _walletText.text = _currentValue.ToString();

    }
}
