using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField] private float targetSpeed = 5f;
    [SerializeField] private AudioClip sfx;
    private float speed = 0f;
    private Vector2 swipePoint = new();
    private Vector2 originPos;
    // Start is called before the first frame update
    void Start()
    {
        originPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            swipePoint.x = Input.mousePosition.x;
        }

        if (Input.GetMouseButtonUp(0))
        {
            swipePoint.y = Input.mousePosition.x;
            speed = Mathf.Abs(swipePoint.y - swipePoint.x) / targetSpeed;
            
            print(swipePoint.y - swipePoint.x);
            print(speed);
        }

        transform.Translate(speed, 0f, 0f);
        speed *= 0.98f;
        if (speed <= 0.01f)
        {
            speed = 0f;
            transform.position = originPos;
        }
    }
}
