using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationDragon : MonoBehaviour
{
    private Animator animator;

    private enum AnimationList
    {
        DRAGON_ATTACK,
        DRAGON_IDLE
    }

    AnimationList myAnimationList;

    private void Start()
    {
        myAnimationList = AnimationList.DRAGON_IDLE;

        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (myAnimationList == AnimationList.DRAGON_ATTACK)
            animator.SetTrigger("DragonAttack");
        else
            animator.SetTrigger("DragonIdle");
    }

    public void PlayeDragonAnimation()
    {
        if (myAnimationList ==  AnimationList.DRAGON_IDLE)
            myAnimationList = AnimationList.DRAGON_ATTACK;
    }

    public void StopDragonAnimation()
    {
        if (myAnimationList == AnimationList.DRAGON_ATTACK)
            myAnimationList = AnimationList.DRAGON_IDLE;
    }
}
