using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(Renderer))]
public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Color _targetColor;
    [SerializeField] private float _duration;

    private Tween _tween;
    private Renderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void Start()
    {
        Change();
    }

    private void Change()
    {
        if (_tween != null)
        {
            _tween.Kill();
        }

        _tween = _renderer.material.DOColor(_targetColor, _duration);
    }
}
