using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeviceChecker : MonoBehaviour
{
    // Called when the script instance is being loaded
    void Start()
    {
        string deviceModel = SystemInfo.deviceModel;
        string deviceName = SystemInfo.deviceName;
        string deviceType = SystemInfo.deviceType.ToString();

        // Check if the device model is null or empty
        if (string.IsNullOrEmpty(deviceModel))
        {
            Debug.Log("Unable to retrieve device model");
        }

        // Check if the device name is null or empty
        if (string.IsNullOrEmpty(deviceName))
        {
            Debug.Log("Unable to retrieve device name");
        }

        // Check if the device type is Unknown
        if (deviceType == "Unknown")
        {
            Debug.Log("Unable to retrieve device type");
        }

        // Log the device model and device type if both are available
        if (!string.IsNullOrEmpty(deviceModel) && !string.IsNullOrEmpty(deviceName) && deviceType != "Unknown")
        {
            Debug.Log("Device model: " + deviceModel + ", Device name: " + deviceName + ", Device type: " + deviceType);
        }
    }
}