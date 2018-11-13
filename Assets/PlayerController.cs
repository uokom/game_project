using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    
    
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("衝突");
        //Destroy(gameObject);
        SceneManager.LoadScene("stage1");
    }
}