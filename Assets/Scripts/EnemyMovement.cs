using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    public float speed = 3f;
    public float attackRate = 1f;
    //public bool start = true;
    private Animation anim;
    private Transform target;
    private Transform goblin;
    private int wavepointIndex = 0;
    private float attackTime;
    private bool attacking;
    private float fireCountDown;
    // Use this for initialization
    void Start ()
    {
        attacking = false;
        target = Waypoints.points[0];
        goblin = this.transform;
        anim = GetComponent<Animation>();
        foreach (AnimationState state in anim)
        {
            state.speed = 4F;
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        //if (start == true)
        // {
        if (!attacking)
        {
            anim.Play("walk");
            Vector3 dir = target.position - transform.position;
            Quaternion lookRotation = Quaternion.LookRotation(dir);
            Vector3 rotation = Quaternion.Lerp(goblin.rotation, lookRotation, Time.deltaTime * 10f).eulerAngles;
            goblin.rotation = Quaternion.Euler(0f, rotation.y, 0f);
            transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

            if (Vector3.Distance(transform.position, target.position) <= 0.4f)
            {
                GetNextWaypoint();
            }
        }
        else
        {
            
            anim.Play("attack3");
            if (fireCountDown <= 0f)
            {
                BaseHealth.health -= Enemy.damage;
                fireCountDown = 1f / attackRate;
            }

            fireCountDown -= Time.deltaTime;
           
        }
        
        
        // }

        if (GameManager.gameOver)
        {
            return;
        }


    }

    void GetNextWaypoint()
    {
        if (wavepointIndex >= Waypoints.points.Length - 1)
        {
            foreach (AnimationState state in anim)
            {
                state.speed = 1F;
            }
            anim.Play("idle");
            attacking = true;
            //wavepointIndex = 0;
            return;
        }
        wavepointIndex++;
        target = Waypoints.points[wavepointIndex];
    }
}
