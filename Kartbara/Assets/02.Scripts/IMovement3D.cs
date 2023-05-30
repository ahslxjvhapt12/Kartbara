using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMovement3D
{    /// <summary> ���� �̵� ������ ���� </summary>
    bool IsMoving();
    /// <summary> ���鿡 ��� �ִ��� ���� </summary>
    bool IsGrounded();
    /// <summary> �������κ����� �Ÿ� </summary>
    float GetDistanceFromGround();

    /// <summary> ���� �̵����� �ʱ�ȭ(�̵� ���) </summary>
    void SetMovement(in Vector3 worldMoveDirection, bool isRunning);
    /// <summary> ���� ��� - ���� ���� ���� ���� </summary>
    bool SetJump();
    /// <summary> �̵� ���� </summary>
    void StopMoving();

    /// <summary> ���ĳ��� </summary>
    void KnockBack(in Vector3 force, float time);
}
