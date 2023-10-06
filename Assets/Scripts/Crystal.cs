using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystal : MonoBehaviour
{
    public AudioClip shotaia;
    void Update()
    {
        AudioSource.PlayClipAtPoint(shotaia, transform.position);
    }
}
