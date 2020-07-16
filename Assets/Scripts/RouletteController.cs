using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RouletteController : MonoBehaviour
{
    float speed = 0;
    float r;

    void Start(){
        Random.InitState(System.DateTime.Now.Second);
        r = Random.Range (30.0f, 1000.00f);
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            this.speed = -r;
        }
            transform.Rotate(0, 0, this.speed);
            this.speed *= 0.98f;
    }
}