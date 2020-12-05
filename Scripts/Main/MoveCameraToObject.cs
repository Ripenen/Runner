using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCameraToObject : MonoBehaviour
{
    public GameObject Object;

    private Vector2 Offset;

    private bool NeedMovingCamera;

    private void Update()
    {

        if (Vector2.Distance(Object.transform.position, transform.position) > 0.1 || NeedMovingCamera == false)
        {
            NeedMovingCamera = true;

            MoveCamera();
        }
    }

    private void MoveCamera()
    {
        Offset = Object.transform.position - transform.position;

        transform.Translate(new Vector2(Offset.x, transform.position.y) * Time.deltaTime * 5);

        if (Vector2.Distance(Object.transform.position, transform.position) < 0.2)
        {
            NeedMovingCamera = false;
        }
    }
}
