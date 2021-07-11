using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBase : MonoBehaviour
{

    protected Animator PlayerAnimator;

    void Start()
    {
        //Подписка на события PlayerMovementManager;
        PlayerMovementManager.PlayerManager.onIdle += Idle;
        PlayerMovementManager.PlayerManager.onWalk += Walk;
        PlayerMovementManager.PlayerManager.onRun += Run;
        PlayerMovementManager.PlayerManager.onRotationPlayer += Turn;
    }

    //Определяем значения переменных анимации;
    void PlayerState(bool RunState, bool WalkState)
    {
        PlayerAnimator.SetBool("Run", RunState);
        PlayerAnimator.SetBool("Walk", WalkState);
    }

    public void Idle()
    {
        PlayerState(false, false);
    }

    public virtual void Run()
    {
        PlayerState(true, false);
    }

    public virtual void Walk()
    {
        PlayerState(false, true);
    }

    public virtual void Turn(Vector3 rotationVector)
    {

    }
}