
using UnityEngine;

public class SpikeHead : Restart3
{
    [SerializeField] private float speed;
    [SerializeField] private float range;
    [SerializeField] private float checkDelay;
    private Vector3 destination;
    private bool attacking;
    private float checkTimer;
    private Vector3[] direction = new Vector3[4];
    [SerializeField] LayerMask playerLayer;

    private void Update()
    {
        if (attacking)
        {
            transform.Translate(destination * Time.deltaTime * speed);
        }

        else
        {
            checkTimer += Time.deltaTime;
            if(checkTimer > checkDelay)
            {
                CheckForPlayer();
            }
        }
    }

    private void CheckForPlayer()
    {
        CalculateDirections();

        for(int i  = 0; i < direction.Length; i++)
        {
            Debug.DrawRay(transform.position, direction[i], Color.red);
            RaycastHit2D hit = Physics2D.Raycast(transform.position, direction[i], range, playerLayer);

            if(hit.collider != null && !attacking)
            {
                attacking = true;
                destination = direction[i];
                checkTimer = 0;
            }
        }
    }

    private void CalculateDirections()
    {
        direction[0] = transform.right * range;
        direction[1] = -transform.right * range;
        direction[2] = transform.up * range;
        direction[3] = -transform.up * range;
    }

 
}
