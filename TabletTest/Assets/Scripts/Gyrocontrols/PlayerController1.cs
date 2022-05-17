using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController1 : MonoBehaviour
{

    private Input inputActions;
    private Input.GyroActions gyroActions;

    public bool useX;
    public bool useY;
    public bool useZ;
    // Start is called before the first frame update
    void Start()
    {
        InputSystem.EnableDevice(UnityEngine.InputSystem.Gyroscope.current);

        inputActions = new Input();

        gyroActions = inputActions.Gyro;
        gyroActions.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 gyro = gyroActions.Rotation.ReadValue<Vector3>();
        if (useX)
        {
           this.transform.Rotate(new Vector3(gyro.x, 0, 0) * Time.deltaTime);
        }
        else if (useY)
        {
            this.transform.Rotate(new Vector3(0, gyro.y, 0) * Time.deltaTime);
        }
        else if (useZ)
        {
            this.transform.Rotate(new Vector3(0, 0, gyro.z) * Time.deltaTime);
        }
        else
        {
            this.transform.Rotate(gyro * Time.deltaTime);
        }
    }

}