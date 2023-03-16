using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapybaraMove : MonoBehaviour
{
    [SerializeField] private float speed = 10;
    [SerializeField] private float rotateSpeed = 10;
    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("히히 회전");
        }
    }


}
