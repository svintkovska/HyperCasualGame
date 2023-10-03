
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContentActivator : MonoBehaviour
{
    [SerializeField] private NextButton _nextButton;
    [SerializeField] private List<GridLayoutGroup> _content;

    private GridLayoutGroup _currentContent;
    private int _currentContentIndex;

    public void OnEnable()
    {
        _nextButton.ChangeImages += OnChangeImages;
    }
    private void OnDisable()
    {
        _nextButton.ChangeImages -= OnChangeImages;
    }
    private void Start()
    {
        _currentContentIndex = _nextButton.CurrentImageIndex;
        ActiveContent(_currentContentIndex);
    }

    private void ActiveContent(int contentIndex)
    {
        _content[contentIndex].gameObject.SetActive(true);
        _currentContent = _content[contentIndex];
    }

    private void DisableContent()
    {
        _currentContent.gameObject.SetActive(false);
    }

    private void OnChangeImages()
    {
        if(_currentContentIndex < _content.Count - 1)
        {
            DisableContent();
            _currentContentIndex++;
            ActiveContent(_currentContentIndex);
        }
        else
        {
            DisableContent();
            _currentContentIndex = 0;
            ActiveContent(_currentContentIndex);
        }
    }
    
}
