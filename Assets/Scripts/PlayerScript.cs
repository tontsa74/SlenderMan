using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 90;
    float xRotation;
    float yRotation;
    Rigidbody rigid;

    Vector3 inputVector;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        rigid = GetComponent<Rigidbody>();
      //  rigid.detectCollisions = false;
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
        rigid.MovePosition(transform.position + (transform.forward * Input.GetAxis("Vertical")*Time.deltaTime*speed) + (
            transform.right*Input.GetAxis("Horizontal") * Time.deltaTime*speed));
    }

    void Rotate()
    {
        xRotation -= Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;
        yRotation += Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;

        rigid.MoveRotation(Quaternion.Euler(xRotation, yRotation, 0));
    }

}
