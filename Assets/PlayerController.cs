using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{

    
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("衝突");
        Destroy(gameObject);

    }
}