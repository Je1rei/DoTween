using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{ 
    [SerializeField] private Text _text;
    [SerializeField] private float _duration;
    [SerializeField] private float _delay;  
    [SerializeField] private string _newText;

    private Sequence _sequence;

    private void Start()
    {
        _sequence = DOTween.Sequence();

        SequenceStart();
        
    }

    private void SequenceStart()
    {
        _sequence.Append(_text.DOText(_newText, _duration))
            .PrependInterval(_delay)
            .Append(_text.DOText(_text.text + _newText, _duration))
            .PrependInterval(_delay)
            .Append(_text.DOText(_text.text, _duration)
                        .SetEase(Ease.OutBounce));
    }
}
