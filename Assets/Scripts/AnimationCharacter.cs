using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationCharacter : MonoBehaviour
{
    private Animator animator;

    private enum AnimationList
    {
        CHARACTER_ATTACK,
        CHARACTER_IDLE
    }

    AnimationList myAnimationList;

    private void Start()
    {
        myAnimationList = AnimationList.CHARACTER_IDLE;

        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (myAnimationList == AnimationList.CHARACTER_ATTACK)
            animator.SetTrigger("CharacterAttack");
        else
            animator.SetTrigger("CharacterIdle");
    }

    public void PlayeCharacterAnimation()
    {
        if (myAnimationList == AnimationList.CHARACTER_IDLE)
            myAnimationList = AnimationList.CHARACTER_ATTACK;
    }

    public void StopCharacterAnimation()
    {
        if (myAnimationList == AnimationList.CHARACTER_ATTACK)
            myAnimationList = AnimationList.CHARACTER_IDLE;
    }


}
