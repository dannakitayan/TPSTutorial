using System;
using UnityEngine;

public class PlayerMovementManager : MonoBehaviour
{
    /// <summary>
    /// Данный менеджер служит только для обработки анимации игрока и камеры в игре;
    /// </summary>
    public static PlayerMovementManager PlayerManager;

    void Awake()
    {
        PlayerManager = this;
    }

    //Бег;
    public event Action onRun;
    public void Run()
    {
        onRun?.Invoke();
    }

    //Бездействие;
    public event Action onIdle;
    public void Idle()
    {
        onIdle?.Invoke();
    }

    //Ходьба;
    public event Action onWalk;
    public void Walk()
    {
        onWalk?.Invoke();
    }

    //Вращение;
    public event Action<Vector3> onRotationPlayer;
    public void RotationPlayer(Vector3 rotationVector)
    {
        onRotationPlayer?.Invoke(rotationVector);
    }
}
