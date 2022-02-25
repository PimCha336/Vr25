using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimator : MonoBehaviour
{
    
    public void getAnimatorTwerk(){
       this.GetComponent<Animator>().Play("Dancing Twerk");
    }
    public void getAnimatorRumba(){
       this.GetComponent<Animator>().Play("Rumba Dancing");
    }

}
