using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Player _player;
    [SerializeField]
    private float moveSpeed;

    void Start()
    {
        _player = FindFirstObjectByType<Player>();
        if (_player is null) Debug.Log("player not found");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = (_player.transform.position - transform.position).normalized;
        Vector2 targetPosition = (Vector2)transform.position + direction * moveSpeed * Time.deltaTime;
        transform.position = targetPosition;
    }
}
