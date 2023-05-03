using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCamController : MonoBehaviour
{
    
    
    public float sensitivity;
    public float xRot=0f;
    public float minY = -90f;
    public float maxY = 90f;

    public Transform player;

    public GameManager gmScript;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        gmScript=GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.position.x, player.position.y+0.5f, player.position.z);
        MouseLook();
    }


    void MouseLook()
    {
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * sensitivity;

        xRot -= mouseY;
        xRot = Mathf.Clamp(xRot, minY, maxY);

        transform.localRotation = Quaternion.Euler(xRot, 0, 0);
        player.Rotate(Vector3.up * mouseX);
    }
}
