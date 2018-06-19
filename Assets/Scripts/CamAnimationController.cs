using UnityEngine;

public class CamAnimationController : MonoBehaviour {
    Animator CamAnimator;
    bool isInOptions = true;
    public void MoveCam()
    {
        CamAnimator = GetComponent<Animator>();
        if(!isInOptions) //Daca bool e 0
        {
            CamAnimator.Play("ToMainMenu");
            
            isInOptions = !isInOptions;
        }
        else
        {
            CamAnimator.Play("ToOptionsMenu");
            
            isInOptions = !isInOptions;
        }
    }

}
