using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody _rigidbody;
    [SerializeField] private float Speed = 5f;
    [SerializeField] private float RotationSpeed = 5f;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float BackForth = Input.GetAxis("Vertical") * Speed;
        float LeftRight = Input.GetAxis("Horizontal") * RotationSpeed;

        _rigidbody.AddRelativeForce(0f, 0f, BackForth);
        _rigidbody.AddRelativeTorque(0f, LeftRight, 0f);
    }
}
