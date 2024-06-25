using UnityEngine;

public class ChangeAnimator : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            animator.SetInteger("NumberAnim", 1);
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            animator.SetInteger("NumberAnim", 2);
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            animator.SetInteger("NumberAnim", 3);
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            animator.SetInteger("NumberAnim", 4);
        }
        if (Input.GetKey(KeyCode.Alpha5))
        {
            animator.SetInteger("NumberAnim", 5);
        }
    }
}