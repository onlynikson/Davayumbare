using UnityEngine;
using System.Collections;

public class Fall : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(Destroy());
    }

    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(3f);
        gameObject.SetActive(false);

    }
}
