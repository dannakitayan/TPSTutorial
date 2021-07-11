using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerCamera : PlayerBase
{
    [Header("Player Transform")]
    public Transform PlayerTransform;

    void Awake()
    {
        PlayerAnimator = Camera.main.GetComponent<Animator>();
    }

    void Start()
    {
        //Подписка на обновления позиции игрока;
        CameraManager.CameraManagerObject.onPlayerPositionUpdate += CameraFollowingAtPlayer;
        CameraManager.CameraManagerObject.onCameraRotation += CameraRotationAtPlayer;
    }

    void CameraFollowingAtPlayer()
    {
        gameObject.transform.position = new Vector3(PlayerTransform.position.x, PlayerTransform.position.y + 1f, PlayerTransform.position.z);
    }

    void CameraRotationAtPlayer(Vector3 rotationVector)
    {
        transform.Rotate(rotationVector);
    }

    public override void Walk()
    {
        base.Walk();
        CameraFollowingAtPlayer();
    }

    public override void Run()
    {
        base.Run();
        CameraFollowingAtPlayer();
    }
}
