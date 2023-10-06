using Unity.VisualScripting;
using UnityEngine;

public class RogueAttacking : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator anim;
    [SerializeField] private bool attack;
    [SerializeField] private GameObject attackArea;
    private float timetoAttack = 0.25f;
    private float timer = 0f;
    
    void Start()
    {
        attackArea = transform.GetChild(0).gameObject;
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            Attack();
        }

        if(attack)
        {
            timer += Time.deltaTime;

            if(timer > timetoAttack)
            {
                timer = 0f;
                attack = false;
                attackArea.SetActive(false);
            }
        }
    }

    private void Attack()
    {
        attack = true;
        attackArea.SetActive(attack);
        anim.SetBool("Attack", true);
    }
}
