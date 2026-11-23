using UnityEngine;

public class trunks : MonoBehaviour
{
    private float x_start =  60.00f;
    private float x_end   = -28.00f;

    private float x_position;
    private float y_position;
    private float z_position;

    private float speed = 2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // void Start()
    // {
    // }

    // Update is called once per frame
    void Update()
    {
        x_position = transform.position.x;
        y_position = transform.position.y;
        z_position = transform.position.z;

        float new_position = -Time.deltaTime * speed;

        if (new_position + x_position < x_end) {
            transform.Translate(0, 0, x_start * 2);
        }

        else {
            transform.Translate(0, 0, new_position);
        }

    }
}
