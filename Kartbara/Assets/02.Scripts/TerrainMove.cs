using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class TerrainMove : MonoBehaviour
{
    [SerializeField] private float speed = 5;
    
    private void Update()
    {
        transform.position += new Vector3(1, 0, -1) * Time.deltaTime * speed;
        if(transform.position.x > -190)
        {
            transform.position += new Vector3(-600, 0, 600);
        }
    }
}
