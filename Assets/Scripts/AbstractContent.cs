using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public abstract class AbstractContent : MonoBehaviour
{
    [SerializeField] private BodyPart _bodyPart;
    [SerializeField] private BuyButton _buyButton;

    public BuyButton BuyButton => _buyButton;

    public event UnityAction<BodyPart> ChangeBodyPart;


    public  void Active()
    {

        ChangeBodyPart?.Invoke(_bodyPart);
    }

}
