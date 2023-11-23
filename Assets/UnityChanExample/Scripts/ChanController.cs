using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChanController : MonoBehaviour
{
    public Animator mAnimator;
    private float h;
    private float v;

    private void Start()
    {
        mAnimator = GetComponent<Animator>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            mAnimator.Play("JUMP00", -1, 0);
        }

        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        mAnimator.SetFloat("h", h);
        mAnimator.SetFloat("v", v);

    }
}
