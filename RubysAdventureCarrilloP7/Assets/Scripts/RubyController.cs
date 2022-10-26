using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        Vector2 position = transform.position;
        position.x = position.x + 3f * Horizontal * Time.deltaTime;
        position.y = position.y + 3f * Vertical * Time.deltaTime;
        transform.position = position;
    }
}
