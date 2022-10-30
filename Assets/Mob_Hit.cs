using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob_Hit : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
       GameManager.Get().hit();
    }
}
