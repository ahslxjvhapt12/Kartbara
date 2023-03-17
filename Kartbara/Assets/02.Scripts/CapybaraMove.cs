using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapybaraMove : MonoBehaviour
{
    [SerializeField] private float speed = 5;
    [SerializeField] private float rotateSpeed = 10;

    private void Update()
    {
        transform.position += transform.forward * Time.deltaTime * speed;
        Rotate();
    }

    private void Rotate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -rotateSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
        }
    }
}
