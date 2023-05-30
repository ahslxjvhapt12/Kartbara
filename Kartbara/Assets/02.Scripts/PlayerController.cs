using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector3 direction {  get; private set; }
    protected Rigidbody _rigid;
    protected Animator _animator;
    protected CapsuleCollider _col;
}
