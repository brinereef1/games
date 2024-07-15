using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisions : MonoBehaviour
{
    public bool onGround;

    private void OnCollisionStay2D(Collision2D collision)
    {
        onGround = true;  
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        onGround = false;  
    }
}
