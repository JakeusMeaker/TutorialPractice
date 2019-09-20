using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public Transform hoursTransform, minutesTransform, secondsTranform;

    public bool continuous;

    const float degreesPerHour = 30f,
                    degreesPerMinute = 6,
                    degreesPerSecond = 6;

    private void Update()
    {
        if (continuous)
        {
            UpdateContinuous();
        }
        else
        {
            UpdateDiscrete();
        }
    }

    private void UpdateContinuous()
    {
        TimeSpan time = DateTime.Now.TimeOfDay; 
        hoursTransform.localRotation = 
            Quaternion.Euler(0f, (float)time.TotalHours * degreesPerHour, 0f);
        minutesTransform.localRotation =
            Quaternion.Euler(0f, (float)time.TotalMinutes * degreesPerMinute, 0f);
        secondsTranform.localRotation =
            Quaternion.Euler(0f, (float)time.TotalSeconds * degreesPerSecond, 0f);
    }

    private void UpdateDiscrete()
    {
        DateTime time = DateTime.Now;
        hoursTransform.localRotation = 
            Quaternion.Euler(0f, time.Hour * degreesPerHour, 0f);
        minutesTransform.localRotation =
            Quaternion.Euler(0f, time.Minute * degreesPerMinute, 0f);
        secondsTranform.localRotation =
            Quaternion.Euler(0f, time.Second * degreesPerSecond, 0f);
    }
}
 