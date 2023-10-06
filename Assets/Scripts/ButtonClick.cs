using UnityEngine;

public class ButtonClick : MonoBehaviour
{

    [SerializeField] private AudioSource Child;
 
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Child.Play();
    }
}
