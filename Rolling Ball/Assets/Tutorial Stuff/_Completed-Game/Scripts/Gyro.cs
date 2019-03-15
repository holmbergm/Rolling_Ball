using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gyro : MonoBehaviour
{
    private bool gyroEnabled;
    private Gyroscope gyro;

    private void Start()
    {
        gyroEnabled = EnableGyro();
    }

    private bool EnableGyro()
    {
        if (SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;
            return true;
        }
        return false;
    }

    public void Update()
    {
        if(gyroEnabled == true)
        {
            float x = gyro.rotationRate.x;
            float y = gyro.rotationRate.y;
            float z = gyro.rotationRate.z;

            transform.eulerAngles = new Vector3(x, y, z);

        }
    }
}