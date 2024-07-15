using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class carController : MonoBehaviour
{
    private Rigidbody2D car;
    private float horizon;
    public float speed;
    public float rotationSpeed;
    private bool onGround;
    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        car = GetComponent<Rigidbody2D>();
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        horizon = Input.GetAxis("Horizontal");

        if (horizon != 0 && onGround)
        {
            car.velocity = new Vector2(speed * horizon, car.velocity.y);
            if (Input.GetKey(KeyCode.W))
            {
                transform.Rotate(0, 0, rotationSpeed);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                transform.Rotate(0, 0, -rotationSpeed);
            }
        }
        else if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(0, 0, rotationSpeed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(0, 0, -rotationSpeed);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            onGround = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            onGround = false;
        }
    }

    public void sceneLoader()
    {
        Time.timeScale = 1;
    }


}
