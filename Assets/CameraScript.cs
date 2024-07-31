using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject Player;

    public float CameraDistance;
    public float CameraHeight;
    public float CameraSpeed;

    // Start is called before the first frame update
    void Start()
    {
        float MouseX = Input.GetAxis("Mouse X");
        float MouseY = Input.GetAxis("Mouse Y");

        if (Mathf.Abs(MouseX) > 0.00009f)
        {
            MouseX = MouseX * 6;

            transform.RotateAround(Player.transform.position, Vector3.up, MouseX);
        }

        if (Mathf.Abs(MouseY) > 0.00009f)
        {
            if ((CameraHeight - MouseY) < -1 || (CameraHeight - MouseY) > 3)
            {
                MouseY = 0;
            }
            CameraHeight -= MouseY / 6;
        }
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 playerCenter = Player.transform.position + Vector3.up * CameraHeight;

        Vector3 targetPosition = playerCenter - Player.transform.forward * CameraDistance;

        Vector3 smoothedPosition = Vector3.Lerp(transform.position, targetPosition, CameraSpeed * Time.deltaTime);

        transform.position = smoothedPosition;

        transform.LookAt(Player.transform);
    }
}
