using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MosuLook : MonoBehaviour
{

    private float mouseSens = 100f;
    public Transform playerBody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float MouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
        float MouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;

        playerBody.Rotate(Vector3.up * MouseX);
        playerBody.Rotate(Vector3.left   * MouseY);

    }
}
