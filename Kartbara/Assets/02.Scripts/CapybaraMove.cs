using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CapybaraMove : MonoBehaviour
{
    [SerializeField] private float speed = 5;
    [SerializeField] private float rotateSpeed = 10;

    private Rigidbody _rigid = null;

    private void Awake()
    {
        _rigid = GetComponent<Rigidbody>();
        Debug.Log(Mathf.Repeat(10,3));
    }

    private void FixedUpdate()
    {

        _rigid.velocity = (transform.forward * speed) + Vector3.up * _rigid.velocity.y; //new Vector3(_rigid.velocity.x, _rigid.velocity.y, speed);//-transform.up * speed;
        Rotate();
    }

    private void Rotate()
    {
        //if (Input.GetKey(KeyCode.A))
        //{
        //    transform.Rotate(0, -rotateSpeed * Time.deltaTime, 0);
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
        //}

        float h = Input.GetAxisRaw("Horizontal");
        //transform.localEulerAngles += new Vector3(0, h * Time.deltaTime * rotateSpeed, 0);

        //transform.rotation *= Quaternion.Euler(0, h * Time.deltaTime * rotateSpeed, 0);
        transform.rotation = Quaternion.Euler(0, h * Time.deltaTime * rotateSpeed, 0) * transform.rotation;
    }
}
