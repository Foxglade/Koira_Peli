using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerUp : StateMachineBehaviour
{
    // Reference to the Animator component
    private Animator animator;

    // Start is called before the first frame update
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        // Store a reference to the Animator component
        this.animator = animator;
    }

    // Update is called once per frame
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        // Check if the "Up" key is pressed
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            // Trigger the "Up" animation
            animator.SetTrigger("UpTrigger");
        }
    }
}
