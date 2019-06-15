using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 90;

    Vector3 inputVector;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateInputVector();
        Move();
        Rotate();
    }

    void UpdateInputVector()
    {
        inputVector = new Vector3(Input.GetAxis("Horizontal"),
                                    0,
                                    Input.GetAxis("Vertical")).normalized;
    }

    void Move()
    {
        // transform.position += inputVector * Time.deltaTime * speed;

        transform.Translate(inputVector * Time.deltaTime * speed);
    }

    void Rotate()
    {
        transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime);
    }
}
