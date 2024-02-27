using UnityEngine;
using DG.Tweening;

public class Mover : MonoBehaviour
{
    [SerializeField] private Transform[] _waypoints;
    [SerializeField] private float _duration;

    private Tween _tween;
    private Vector3[] _waypointsVectors;

    private void Start()
    {
        FillArray();
        Move();
    }

    private void Move()
    {
        if (_tween != null)
        {
            _tween.Kill();
        }

        _tween = transform.DOPath(_waypointsVectors, _duration, PathType.CatmullRom)
            .SetEase(Ease.Linear)
            .SetRecyclable(true)
            .OnComplete(() => _tween.Restart());
    }

    private void FillArray()
    {
        _waypointsVectors = new Vector3[_waypoints.Length];

        for (int i = 0; i < _waypoints.Length; i++)
        {
            _waypointsVectors[i] = _waypoints[i].transform.position;
        }
    }
}


