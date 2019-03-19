using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Gyro : MonoBehaviour
{
	private bool gyroEnabled;
	private Gyroscope gyro;
	public Text GryroDisabled;

	private void Start()
	{
		gyroEnabled = EnableGyro();
		Screen.orientation = ScreenOrientation.LandscapeLeft;
		GryroDisabled.gameObject.SetActive(false);
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
		if (gyroEnabled == true)
		{
			float x = -gyro.rotationRate.x;
			float y = -gyro.rotationRate.y;
			float z = -gyro.rotationRate.z;

			transform.eulerAngles = new Vector3(transform.eulerAngles.x + x, transform.eulerAngles.y + z, transform.eulerAngles.z + y);

		}
		else
		{
			GryroDisabled.gameObject.SetActive(true);
		}
	}
}