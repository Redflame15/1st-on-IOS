using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarManagement : MonoBehaviour
{
    public GameObject bar;
    Collider2D col;
    Collider2D touchCollider;
    Touch touch;
    Vector2 touchPosition;

    //public void ToggleVisibility()
    //{
    //    hBar.SetActive(false);
    //}

    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider2D>();
        bar.Visible = true;
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

            if (touch.phase == TouchPhase.Began)
            {
                touchCollider = Physics2D.OverlapPoint(touchPosition);
                if (col == touchCollider)
                {
                    bar.Visible = true;
                }
            }

            if (touch.phase == TouchPhase.Moved)
            {

            }

            if (touch.phase == TouchPhase.Ended)
            {

            }

        }
    }
}
