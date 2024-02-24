using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public bool onGround;
    public float ForceJump = 500;
    public float fuerza_X;
    public float fuerzaIncrement = 200f;
    private bool zPressed = false;
    private bool xPressed = false;

    // Start is called before the first frame update
    void Start()
    {
        onGround = false;
        fuerza_X = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            print("Space key was released");
            if (GetComponent<Rigidbody>() != null)
            {
                GetComponent<Rigidbody>().useGravity = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            if (onGround)
            {
                Vector3 fuerza = new Vector3(fuerza_X, ForceJump, 0);
                GetComponent<Rigidbody>().AddForce(fuerza);
            }

        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            zPressed = true;
        }
        else if (Input.GetKeyUp(KeyCode.Z))
        {
            zPressed = false;
        }

        if (zPressed)
        {
            fuerza_X -= fuerzaIncrement * Time.deltaTime;
        }


        if (Input.GetKeyDown(KeyCode.X))
        {
            xPressed = true;
        }
        else if (Input.GetKeyUp(KeyCode.X))
        {
            xPressed = false;
        }

        if (xPressed)
        {
            fuerza_X += fuerzaIncrement * Time.deltaTime;
        }
    }

    private void OnCollisionEnter(Collision c)
    {
        Debug.Log("Colision");
        onGround = true;
    }

    private void OnCollisionStay(Collision c)
    {
        onGround = true;
    }

    private void OnCollisionExit(Collision c)
    {
        onGround = false;
        Debug.Log("Libre");
    }
}