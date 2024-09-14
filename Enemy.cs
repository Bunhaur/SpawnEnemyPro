using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Player _target;
    private float _speed = 8;

    private void Update()
    {
        Move(_target);
    }

    public void SetTarget(Player target)
    {
        _target = target;
    }

    private void Move(Player player)
    {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, _speed * Time.deltaTime);
        transform.LookAt(player.transform);
    }
}