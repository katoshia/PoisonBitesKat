using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyMovement : MonoBehaviour
{
    private Animator anim;
    [SerializeField] GameObject myObject;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (myObject.name == "FlySpecial")
            anim.SetBool("Special",true);
    }
}
