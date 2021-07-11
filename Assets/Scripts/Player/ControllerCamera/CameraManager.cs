using System;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public static CameraManager CameraManagerObject;
    // Start is called before the first frame update
    void Awake()
    {
        CameraManagerObject = this;
    }

    //Получение текущего игрока;
    //Метод для камеры, передавать текущего игрока, чтобы камера брала фокусировку на нового игрока;
    public event Action<Transform> onGetCurrentPlayer;
    public void GetCurrentPlayer(Transform player)
    {
        onGetCurrentPlayer?.Invoke(player);
    }

    //Обновление позиции камеры относительно текущего игрока;
    public event Action onPlayerPositionUpdate;
    public void PlayerPositionUpdate()
    {
        onPlayerPositionUpdate?.Invoke();
    }

    //Обновление поворота камеры;
    public event Action<Vector3> onCameraRotation;
    public void CameraRotation(Vector3 rotationVector)
    {
        onCameraRotation?.Invoke(rotationVector);
    }
}
