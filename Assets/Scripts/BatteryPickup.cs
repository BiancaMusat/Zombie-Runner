﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickup : MonoBehaviour
{
    [SerializeField] float restoreAngle = 90f;
    [SerializeField] float addIntensity = 10f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.GetComponentInChildren<FlashLightSistem>().RestoreLightAngle(restoreAngle);
            other.GetComponentInChildren<FlashLightSistem>().RestoreLightIntensity(addIntensity);
            Destroy(gameObject);
        }
    }

}
