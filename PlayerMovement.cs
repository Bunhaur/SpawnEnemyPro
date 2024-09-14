using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private CheckPoint[] _points;

    private Vector3 _currentPoint;
    private float _speed = 10;
    private int _current;

    private void Start()
    {
        SetCurrentPoint(_current);
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        if (transform.position == _currentPoint)
        {
            _current++;
            ChangePoint();
        }

        transform.position = Vector3.MoveTowards(transform.position, _currentPoint, _speed * Time.deltaTime);
        transform.LookAt(_currentPoint);
    }

    private void ChangePoint()
    {
        if (_current == _points.Length)
            _current = 0;

        SetCurrentPoint(_current);
    }

    private void SetCurrentPoint(int index)
    {
        _currentPoint = _points[_current].transform.position;
    }
}