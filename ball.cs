using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public Rigidbody2D rb;



    // Start is called before the first frame update
    void Start()
    {
        bool isRight = UnityEngine.Random.value >= 0.5;

        float xVelocity = -1f;

        if (isRight == true)
        {
            xVelocity = 1f;
        }


        float yVelocity = UnityEngine.Random.Range(-1, 1);


        rb.velocity = new Vectore2(xVelocity, yVelocity);
    }

   
    // Update is called once per frame
    void Update()
    {
        
    }
}
