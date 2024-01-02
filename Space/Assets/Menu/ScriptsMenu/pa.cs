using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pa : MonoBehaviour
{
    
    public Transform[] patrolPoints;
    public float moveSpeed = 5f;

    private int currentPatrolIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Move towards the current patrol point
        transform.position = Vector3.MoveTowards(transform.position, patrolPoints[currentPatrolIndex].position, moveSpeed * Time.deltaTime);

        // If the enemy reaches the patrol point, move to the next one
        if (Vector3.Distance(transform.position, patrolPoints[currentPatrolIndex].position) < 0.1f)
        {
            currentPatrolIndex = (currentPatrolIndex + 1) % patrolPoints.Length;
        }
    }
}
