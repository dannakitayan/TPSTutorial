using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInputController : MonoBehaviour
{
    [Header("Players")]
    public GameObject Player1;
    public GameObject Player2;

    GameObject CurrentPlayer;

    void LateUpdate()
    {
        CameraManager.CameraManagerObject.PlayerPositionUpdate();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetAxisRaw("Vertical") > 0)
        {
            PlayerMovementManager.PlayerManager.Walk();
        }

        if (Input.GetAxisRaw("Vertical") > 0 && Input.GetButton("Jump"))
        {
            PlayerMovementManager.PlayerManager.Run();
        }
        
        if(Input.GetAxisRaw("Vertical") == 0)
        {
            PlayerMovementManager.PlayerManager.Idle();
        }

        if (Input.GetButton("Horizontal"))
        {
            Vector3 RotationVector = new Vector3(0, Input.GetAxisRaw("Horizontal") * 80f * Time.deltaTime, 0);
            PlayerMovementManager.PlayerManager.RotationPlayer(RotationVector);
            CameraManager.CameraManagerObject.CameraRotation(RotationVector);
        }
    }
}
