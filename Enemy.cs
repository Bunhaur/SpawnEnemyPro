using UnityEngine;

[RequireComponent(typeof(EnemyMovement))]

public class Enemy : MonoBehaviour
{
    private EnemyMovement _enemyMovement;
    private Player _target;

    private void Awake()
    {
        _enemyMovement = GetComponent<EnemyMovement>();
    }

    public void TransferTarget(Player target)
    {
        _target = target;
        _enemyMovement.SetTarget(_target);
    }
}