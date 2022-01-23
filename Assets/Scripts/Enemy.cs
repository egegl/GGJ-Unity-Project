using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public ParticleSystem blood;
    public int maxHP;
    int currHP;
    // Start is called before the first frame update
    void Start()
    {
        currHP = maxHP;
    }
    public void TakeDamage (int damage)
    {
        currHP -= damage;
        // ADD HURT ANIMATION

        if (currHP <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        blood.Play();
        Destroy(gameObject);
    }
    
    // MOVEMENT
    private enum State
    {
        Walking,
        Knockback,
        Dead
    }
    private void Update()
    {
        switch(currentState)
        {
            case State.Walking:
                UpdateWalkingState();
                break;
            case State.Knockback:
                UpdateKnockbackState();
                break;
            case State.Dead:
                UpdateDeadState();
                break;
        }
    }
    private State currentState;

    [SerializeField]
    private Transform
        groundCheck,
        wallCheck;
    [SerializeField]
    private LayerMask whatIsGround;

    private bool
        groundDetected,
        wallDetected;

    // WALKING STATE
    private void EnterWalkingState()
    {

    }
    private void UpdateWalkingState()
    {

    }
    private void ExitWalkingState()
    {

    }
    // KNOCKBACK STATE
    private void EnterKnockbackState()
    {

    }
    private void UpdateKnockbackState()
    {

    }
    private void ExitKnockbackState()
    {

    }
    // DEAD STATE
    private void EnterDeadState()
    {

    }
    private void UpdateDeadState()
    {

    }
    private void ExitDeadState()
    {

    }

    // OTHER FUNCTIONS
    private void SwitchState(State state)
    {
        switch(currentState)
        {
            case State.Walking:
                ExitWalkingState();
                break;
            case State.Knockback:
                ExitKnockbackState();
                break;
            case State.Dead:
                ExitDeadState();
                break;
        }

        switch (state)
        {
            case State.Walking:
                EnterWalkingState();
                break;
            case State.Knockback:
                EnterKnockbackState();
                break;
            case State.Dead:
                EnterDeadState();
                break;
        }
    }
}
