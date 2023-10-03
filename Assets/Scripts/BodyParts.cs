using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BodyParts : MonoBehaviour
{
    [SerializeField] private List<AbstractContent> _bodyParts;
    private BodyPart _currentBodyPart;

    private void OnEnable()
    {
        foreach (var bodyPart in _bodyParts)
        {
            bodyPart.ChangeBodyPart += OnChangeBodyPart;
            bodyPart.BuyButton.BuyBodyPart+= OnBuyBodyPart;

        }

    }
    private void OnDisable()
    {
        foreach (var bodyPart in _bodyParts)
        {
            bodyPart.ChangeBodyPart -= OnChangeBodyPart;
            bodyPart.BuyButton.BuyBodyPart -= OnBuyBodyPart;

        }
    }
    private void OnChangeBodyPart(BodyPart part)
    {
        if(_currentBodyPart == null)
        {
            _currentBodyPart = part;
            _currentBodyPart.gameObject.SetActive(true);

        }
        else
        {
            _currentBodyPart.gameObject.SetActive(false);
            _currentBodyPart = part;
            _currentBodyPart.gameObject.SetActive(true);
        }
    }
    private void OnBuyBodyPart()
    {
        foreach (var bodyPart in _bodyParts)
        {
            bodyPart.gameObject.SetActive(false);

        }
    }


}
