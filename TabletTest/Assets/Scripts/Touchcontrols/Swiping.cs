using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Swiping : MonoBehaviour
{
    [SerializeField] Text swipeDirection;
    [SerializeField] float swipeRange = 50;
    [SerializeField] float tapRange = 10;

    Vector2 startTouchPosition;
    Vector2 currentPosition;
    Vector2 endTouchPosition;
    bool stopTouch = false;

    void Update()
    {
        StartSwipe();
    }

    public void StartSwipe()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startTouchPosition = Input.GetTouch(0).position;
        }
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            currentPosition = Input.GetTouch(0).position;
            Vector2 Distance = currentPosition - startTouchPosition;

            if (!stopTouch)
            {
                if (Distance.x < -swipeRange)
                {
                    swipeDirection.text = "Left";
                    stopTouch = true;
                }
                else if (Distance.x > swipeRange)
                {
                    swipeDirection.text = "Right";
                    stopTouch = true;
                }
                else if (Distance.y > swipeRange)
                {
                    swipeDirection.text = "Up";
                    stopTouch = true;
                }
                else if (Distance.y < -swipeRange)
                {
                    swipeDirection.text = "Down";
                    stopTouch = true;
                }
            }
        }
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            stopTouch = false;
            endTouchPosition = Input.GetTouch(0).position;
            Vector2 Distance = endTouchPosition - startTouchPosition;

            if (Mathf.Abs(Distance.x) < tapRange && Mathf.Abs(Distance.y) < tapRange)
            {
                swipeDirection.text = "Tap";
            }
        }
    }
}
