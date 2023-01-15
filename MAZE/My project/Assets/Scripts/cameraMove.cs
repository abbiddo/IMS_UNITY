using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{

    public Transform target;
    public Transform cam;

    public float offsetX;
    public float offsetY;
    public float offsetZ;

    public float speed;
    public float rotSpeed;

    public float mx;
    public float my;

    Vector3 camPos;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Transform>();

        offsetX = target.position.x;
        offsetY = target.position.y;
        offsetZ = target.position.z;

        speed = 6;
        rotSpeed = 200;
        mx = my = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float mouse_X = Input.GetAxis("Mouse X");
        float mouse_Y = Input.GetAxis("Mouse Y");

        mx += mouse_X * rotSpeed * Time.deltaTime;
        my += mouse_Y * rotSpeed * Time.deltaTime;

        my = Mathf.Clamp(my, -90, 90);

        transform.eulerAngles = new Vector3(-my, mx, 0);
        //target.transform.Rotate(new Vector3(0, mx, 0));

        camPos.x = target.position.x + offsetX;
        camPos.y = target.position.y + offsetY;
        camPos.z = target.position.z + offsetZ;

        cam.position = Vector3.Lerp(cam.position, camPos, speed * Time.deltaTime);
    }
}
