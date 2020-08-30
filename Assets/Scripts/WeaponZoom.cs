using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera mainCamera;
    [SerializeField] RigidbodyFirstPersonController fpsController;
    [SerializeField] float zoomedOutFOV = 60f;
    [SerializeField] float zoomedInFOV = 30f;
    [SerializeField] float zoomedOutSensitivity = 2f;
    [SerializeField] float zoomedInSensitivity = 0.5f;

    bool zoomedInToggle = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (!zoomedInToggle)
            {
                mainCamera.fieldOfView = zoomedInFOV;
                fpsController.mouseLook.XSensitivity = zoomedInSensitivity;
                fpsController.mouseLook.YSensitivity = zoomedInSensitivity;
            }
            else
            {
                mainCamera.fieldOfView = zoomedOutFOV;
                fpsController.mouseLook.XSensitivity = zoomedOutSensitivity;
                fpsController.mouseLook.YSensitivity = zoomedOutSensitivity;
            }
            zoomedInToggle = !zoomedInToggle;
        }
    }
}
