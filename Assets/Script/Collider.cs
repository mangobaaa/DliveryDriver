using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("충돌");
   }
}
