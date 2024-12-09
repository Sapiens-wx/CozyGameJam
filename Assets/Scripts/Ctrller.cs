using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ctrller : MonoBehaviour
{
    public Animator animator;
    public AudioSource src;
    public AudioClip leftclip, rightclip, upclip, downclip;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void PlaySound(AudioClip clip){
        if(clip==null) return;
        if(src.clip==clip) return;
        src.clip=clip;
        src.Play();
    }

    // Update is called once per frame
    void FixedUpdate(){
        int h=(int)Input.GetAxisRaw("Horizontal");
        int v=(int)Input.GetAxisRaw("Vertical");
        if(h==1){ //right
            PlaySound(rightclip);
            animator.SetBool("right",true);

            animator.SetBool("up",false);
            animator.SetBool("down",false);
            animator.SetBool("left",false);
        } else if(h==-1){ //left
            PlaySound(leftclip);
            animator.SetBool("left",true);

            animator.SetBool("up",false);
            animator.SetBool("down",false);
            animator.SetBool("right",false);
        } else if(v==1){ //up
            PlaySound(upclip);
            animator.SetBool("up",true);

            animator.SetBool("down",false);
            animator.SetBool("left",false);
            animator.SetBool("right",false);
        } else if(v==-1){ //down
            PlaySound(downclip);
            animator.SetBool("down",true);

            animator.SetBool("up",false);
            animator.SetBool("left",false);
            animator.SetBool("right",false);
        } else{
            src.Stop();
            animator.SetBool("up",false);
            animator.SetBool("down",false);
            animator.SetBool("left",false);
            animator.SetBool("right",false);
        }
    }
}
