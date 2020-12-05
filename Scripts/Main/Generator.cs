using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject[] Prefabs;

    private float Speed = 5f;

    private bool isGenerate;

    private int point;

    private void Update()
    {
        transform.Translate(Vector2.up * (Speed + GetSpeed.ControlSpeed) * Time.deltaTime);

        GenerateCell();
        DestroyCell();
    }

    private void GenerateCell()
    {
        if (transform.position.y >= 0 && isGenerate == false && GameObject.FindGameObjectsWithTag("Cube").Length >= 1)
        {
            int RandomNumber = Random.Range(0, Prefabs.Length);

            Instantiate(Prefabs[RandomNumber], new Vector2(0, -4.5f + (transform.localScale.y / 2) * -1), Quaternion.Euler(0, 0, 0));

            isGenerate = true;
        }
    }

    private void DestroyCell()
    {
        if (transform.position.y >= 5 + (transform.localScale.y / 2))
        {
            Destroy(gameObject);
        }
    }
}
