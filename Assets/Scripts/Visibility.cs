using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visibility : MonoBehaviour
{
    public GameObject bar;

    Vector2 touchPosition;
    Touch touch;
    Collider2D collider;
    Collider2D touchCollider;

    //public void ToggleVisibility()
    //{

    //}

    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<Collider2D>();
        bar.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (2 > Input.touchCount && Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

            if (touch.phase == TouchPhase.Began)
            {
                touchCollider = Physics2D.OverlapPoint(touchPosition);
                if (collider == touchCollider)
                {
                    bar.SetActive(true);
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
