using System.Collections;
using UnityEngine;

public class Fall2 : MonoBehaviour
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
