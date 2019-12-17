using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    void OnBecameInvisible()
    {
        transform.Translate(Vector2.right * 19.2f * 2);
    }
}
