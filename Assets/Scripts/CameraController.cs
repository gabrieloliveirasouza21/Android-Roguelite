using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private Transform _playerPos;
    private Vector2 _minMaxXY;
    void Start()
    {
        _minMaxXY.x = 5;
        _minMaxXY.y = 3;
    }

    void LateUpdate()
    {
        var targetPos = _playerPos.position;
        targetPos.z = -10;
        targetPos.x = Mathf.Clamp(targetPos.x,-_minMaxXY.x,_minMaxXY.x);
        targetPos.y = Mathf.Clamp(targetPos.y,-_minMaxXY.y,_minMaxXY.y);
        transform.position = targetPos;
    }
}
