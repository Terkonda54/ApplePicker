/***
 * Created by: Anupam Terkonda
 * Date created: 1/31/2022
 * 
 * Last edited: N/A
 * Last edited by: N/A
 * 
 * Description: Controls tree movement and apple spawning
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    // Instantiating Variables
    public GameObject applePrefab;
    public float speed = 10f;
    public float leftAndRightEdge = 24f;
    public float chanceToChangeDirection = 0.1f;
    public float secondsBetweenAppleDrops = 1f;


    // Start is called before the first frame update
    void Start()
    {
        Invoke("DropApple", 2f);
    }

    void DropApple()
    {
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position; //Move apple to tree pos
        Invoke("DropApple", secondsBetweenAppleDrops);
    }

    // Update is called once per frame
    void Update()
    {
        //Move tree every frame
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
        if (pos.x < -leftAndRightEdge) //if left edge is hit
        {
            speed = Mathf.Abs(speed); //Move right
        }
        else if (pos.x > leftAndRightEdge) //if right edge is hit
        {
            speed = -Mathf.Abs(speed); //Move left
        }
        
    }

    private void FixedUpdate()
    {
        if (Random.value < chanceToChangeDirection)
        {
            speed *= -1; //change direction
        }
    }
}
