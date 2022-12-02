using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityTimer;

public class PlatformFall : MonoBehaviour
{
    public int seccondsDelay;
    private GameObject[] Plateforms;
    private int Rand;
    private int lenghtList;
    private Timer _timer;
    Animator animator;
    

    // Start is called before the first frame update
    void Start()
    {
        if(_timer != null)
        {
            _timer.Cancel();
        }


        Plateforms = GameObject.FindGameObjectsWithTag("Plateform");
        lenghtList = Plateforms.Length;
        Rand = Random.Range(0, lenghtList-1);
        animator = Plateforms[Rand].GetComponent<Animator>();

        //Debug.Log(GetClipDuration("IsFalling"));


        _timer = Timer.Register(GetClipDuration("PlatFall",animator), () => {
            Debug.Log("timerCompleted");
            Debug.Log(GetClipDuration("PlatFall",animator));

        }
        );

        animator.SetBool("IsFalling",true);
        
        //Plateforms[Rand].SetActive(false);

        //animator.SetBool("IsFalling", false);
        //animator.SetBool("FirstTimeFall", true);
        //Plateforms[Rand].SetActive(true);
    }

    public float GetClipDuration(string animName,Animator anim)
    {
        float time=0f;
        AnimationClip clip = null;

        RuntimeAnimatorController ac = anim.runtimeAnimatorController;    //Get Animator controller
        for (int i = 0; i < ac.animationClips.Length; i++)                 //For all animations
        {
            if (ac.animationClips[i].name == animName)        //If it has the same name as your clip
            {
                time = ac.animationClips[i].length;
                clip = ac.animationClips[i];
            }
        }

        if (clip == null)
        {
            Debug.Log("Animation not found");
        }

        return time;
    }

}
