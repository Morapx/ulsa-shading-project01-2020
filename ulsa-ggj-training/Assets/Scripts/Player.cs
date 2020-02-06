using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    void Update()
    {
        Vector2 axis = new Vector2(input.GetAxis("Horizontal"), input.GetAxis("Vertical"));

        transform.Translate(axis * 1f);
    }
}
