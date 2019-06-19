using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowStickScript : MonoBehaviour
{
    public float speed = 700f;

    Vector3 direction;

    public float lifeSpan = 10f;
    float timer = 0;

    Rigidbody rb;

    bool throwed = false;

    public Light stickLight;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!throwed)
        {
            // rb.velocity = new Vector3(0,0,0);
            //  direction.y = 0;
            //  direction.x -= direction.x * 0.05f;
            rb.AddRelativeForce(direction * speed);
            throwed = true;

        }

        //    transform.Translate(direction * Time.deltaTime * speed);




        //rb.AddForce(direction * 100f);
        timer += Time.deltaTime;
        if (timer >= lifeSpan)
        {

            stickLight.color -= (Color.white / 3.0f) * Time.deltaTime;
        }

        //    rb.AddForce(direction * 100);
    }
    public void SetDirection(Vector3 newDirection, float force)
    {
        direction = newDirection;
        speed *= force;
    }

    void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.name);

      //  landing = true;
    }
}
