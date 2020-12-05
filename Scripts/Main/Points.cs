using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    private Text PointText;

    public static float Point = 0;
    private void Start()
    {
        PointText = GetComponent<Text>();
    }
    void Update()
    {
        Point = (Point + 1 * Time.deltaTime * 10);
        int PointInt = (int)Point;
        PointText.text = PointInt.ToString();
    }

    
}
