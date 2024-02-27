using UnityEngine;
using DG.Tweening;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private Vector3 _rotatePosition;

    private Tween _tween;

    private void Start()
    {
        Rotate();
    }

    private void Rotate()
    {
        if (_tween != null)
        {
            _tween.Kill();
        }

        transform.DORotate(_rotatePosition, _duration, RotateMode.FastBeyond360)
            .SetEase(Ease.Linear)
            .OnComplete(Rotate);
    }
}
