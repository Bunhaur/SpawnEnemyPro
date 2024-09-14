using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Player _target;

    public Enemy GetEnemy()
    {
        return _enemy;
    }

    public Player GetTarget()
    {
        return _target;
    }
}