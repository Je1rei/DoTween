using UnityEngine;
using DG.Tweening;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private Vector3 _targetScale;

    private Tween _tween;

    private void Start()
    {
        Scale();
    }

    private void Scale()
    {
        if (_tween != null)
        {
            _tween.Kill();
        }

        transform.DOScale(_targetScale, _duration)
            .SetEase(Ease.Linear)
            .OnComplete(Scale);
    }
}

