using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasuteraPlayer : PlayerBase
{
    [Header("Basutera Speed Propesties")]
    public float WalkSpeed;
    public float RunSpeed;

    [Header("Can Use This Player")] 
    public bool CanUse;

    CharacterController BasuteraController;

    void Awake()
    {
        PlayerAnimator = GetComponent<Animator>();
        BasuteraController = GetComponent<CharacterController>();
    }

    void GetMotionVector()
    {
        Vector3 MotionVector = new Vector3(0, 0, Input.GetAxisRaw("Vertical"));
        MotionVector = transform.TransformDirection(MotionVector);
        BasuteraController.Move(MotionVector * WalkSpeed * Time.deltaTime);
    }

    public override void Walk()
    {
        if (!CanUse) return;
        base.Walk();
        GetMotionVector();
    }

    public override void Run()
    {
        if (!CanUse) return;
        base.Run();
        GetMotionVector();
    }

    public override void Turn(Vector3 rotationVector)
    {
        if (!CanUse) return;
        BasuteraController.transform.Rotate(rotationVector);
    }
}
