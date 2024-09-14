using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private SpawnPoint[] _points;

    private Enemy _enemy;
    private Vector3 _pointPosition;
    private Coroutine _createEnemiesJob;

    private void Start()
    {
        _createEnemiesJob = StartCoroutine(CreateEnemies());
    }

    private IEnumerator CreateEnemies()
    {
        Enemy newEnemy;
        SpawnPoint point;
        float cooldown = 2f;

        while (true)
        {
            point = _points[GetRandomIndex()];
            _enemy = point.GetEnemy();
            _pointPosition = point.transform.position;

            newEnemy = Instantiate(_enemy, _pointPosition, Quaternion.identity);
            newEnemy.TransferTarget(point.GetTarget());

            yield return new WaitForSeconds(cooldown);
        }
    }

    private int GetRandomIndex()
    {
        return Random.Range(0, _points.Length);
    }
}
