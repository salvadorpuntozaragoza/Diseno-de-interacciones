using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform cameraTarget, Player;
    [Range(1, 10)]
    public float rotationSpeed = 1;
    private float mouseX, mouseY;
    public Vector2 limitY = new Vector2(30, 100);

    void Start()
    {
        //Cursor.visible = false;
        //Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        cameraControl();
    }

    void cameraControl()
    {
        mouseX += CrossPlatformInputManager.GetAxis("Mouse X") * rotationSpeed;
        mouseY -= CrossPlatformInputManager.GetAxis("Mouse Y") * rotationSpeed;
        //mouseY = Mathf.Clamp(mouseY, limitY.x, limitY.y);

        cameraTarget.rotation = Quaternion.Euler(mouseY, mouseX, 0);
        Player.rotation = Quaternion.Euler(0, mouseX, 0);

        //transform.LookAt(cameraTarget);
    }
}
