using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BuyButton : MonoBehaviour
{
    public event UnityAction BuyBodyPart;
    public void Buy(int value)
    {
        Wallet.instance.ChangeValue(value);
        gameObject.SetActive(false);
        BuyBodyPart?.Invoke();
    }


}
