using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private int iter = 1;
    void Update()
    {
        Moving();

        ScrollingSize();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Water")
        {
            if(transform.localScale.x < 1 && transform.localScale.y < 1)
            {
                transform.localScale = new Vector2(transform.localScale.x + 0.1f, transform.localScale.y + 0.1f);
                Destroy(collision.gameObject);
            }
        }
        else
        {
            ReloadScene();
        }
    }

    private void Moving()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            Ray TouchPosition = Camera.main.ScreenPointToRay(touch.position);

            if (touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(TouchPosition.origin.x, transform.position.y, -1f);
            }
        }
    }

    private void ScrollingSize()
    {
        if ((int)Points.Point == 0 + iter)
        {
            iter += 1;
            transform.localScale = new Vector2(transform.localScale.x - 0.01f, transform.localScale.y - 0.01f);

            if (transform.localScale == new Vector3(0.25f, 0.25f))
            {
                ReloadScene();
            }
        }
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Points.Point = 0;
    }
}
