using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    
    bool turnLeft;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float LR = -1, SpeedX = 2.0f;
       
        transform.Translate(LR * Time.deltaTime * SpeedX, 0, 0); //????????????? ??? Player ??????????????????? ???????? X

        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            
        }
    }
}
