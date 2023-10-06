using System.Collections;
using UnityEngine;

public class Coroutine : MonoBehaviour
{
    [SerializeField ]private GameObject Trap;
    [SerializeField] private int Timer;

    void Start()
    {
        StartCoroutine(HideObject());
    }

    
    void Update()
    {
        
    }
    IEnumerator HideObject()
    {
        yield return new WaitForSeconds(Timer);
        Trap.SetActive(false);
    }
}
