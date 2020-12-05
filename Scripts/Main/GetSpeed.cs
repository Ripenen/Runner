using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetSpeed : MonoBehaviour
{
    public static int ControlSpeed = 0;

    private int iter = 100;

    void Update()
    {
        if ((int)Points.Point >= 0 + iter)
        {
            iter += 100;
            ControlSpeed += 1;
        }
    }
}
