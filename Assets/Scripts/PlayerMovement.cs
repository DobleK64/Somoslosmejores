using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour

{
    // Start is called before the first frame update
    public float velocity;
    public KeyCode upKey;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(upKey))
        {
            transform.Translate(Vector2.up * velocity * Time.deltaTime);
        }
    }
}
//aaaaaaaaaaaaaaaaaaaaaaa