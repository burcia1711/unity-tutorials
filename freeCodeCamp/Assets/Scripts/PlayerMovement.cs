using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal"); // A + D
        float v = Input.GetAxis("Vertical"); // W + S

        Vector2 pos = transform.position;
        pos.x += speed * h * Time.deltaTime;
        pos.y += speed * v * Time.deltaTime;

        transform.position = pos;
    }
}
