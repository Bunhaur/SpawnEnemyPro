using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Player _target;
    private float _speed = 8;

    public void SetTarget(Player target)
    {
        _target = target;
    }
}
