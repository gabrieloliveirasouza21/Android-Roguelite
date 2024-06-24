using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Player _player;
    [SerializeField]
    private float _moveSpeed;
    [SerializeField]
    private float _playerDetectionRadius;

    void Start()
    {
        _player = FindFirstObjectByType<Player>();
        if (_player is null) Debug.Log("player not found");
    }

    // Update is called once per frame
    void Update()
    {
        FollowPlayer();
        TryAttack();
    }

    private void TryAttack()
    {
        float distanceToPlayer = Vector2.Distance(transform.position, _player.transform.position);
        if (distanceToPlayer <= _playerDetectionRadius)
        {
            Destroy(gameObject);
        }
    }

    private void FollowPlayer()
    {
        Vector2 direction = (_player.transform.position - transform.position).normalized;
        Vector2 targetPosition = (Vector2)transform.position + direction * _moveSpeed * Time.deltaTime;
        transform.position = targetPosition;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position,_playerDetectionRadius);
    }
}
