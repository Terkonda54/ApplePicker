/***
 * Created by: Anupam Terkonda
 * Date created: 1/31/2022
 * 
 * Last edited: N/A
 * Last edited by: N/A
 * 
 * Description: Apple despawn logic
 * 
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{

    public static float bottomY = -20f;

  

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < bottomY)
        {
            Destroy(this.gameObject);
            //Camera.main = gm
            ApplePicker aScript = Camera.main.GetComponent<ApplePicker>();
            aScript.AppleDestroyed();
        }
    }
}
