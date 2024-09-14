using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Player _target;

    public void SetTarget(Player target)
    {
        _target = target;
    }
}
