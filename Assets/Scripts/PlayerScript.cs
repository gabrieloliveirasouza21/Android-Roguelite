using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [Header("Joystick")]
    [SerializeField]
    private MobileJoystick _joystick;
    private float _moveSpeed;
    private Rigidbody2D _rb;
    void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();
        _moveSpeed = 5;
    }

   
    void FixedUpdate()
    {
        _rb.velocity = _joystick.GetMoveVector()*_moveSpeed*Time.deltaTime;
    }
}
