using System.Collections;
using UnityEngine;

public class Fall3 : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(Destroy());
    }

    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(1.5f);
        gameObject.SetActive(false);

    }
}
