using System.Collections;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    [SerializeField]
    string command;
    // Field to link target element
    [SerializeField]
    ActionMother target;
    [SerializeField]
    Animator animator;
    [SerializeField]
    float duration;
    bool isBlocked = false;
    public AudioClip buttonSound;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ButtonTest()
    {
        if (!isBlocked)
        {
            animator.SetTrigger("buttonTrigger");
            target.Action(command);
            print("hello world from buttonScript");
            StopAllCoroutines();
            StartCoroutine(timer());
            SoundManagers.PlaySound();
            isBlocked = true;
        }
    }

    public void SailsOn(){
        if (!isBlocked)
        {
            target.Action(command);
            print("hello world from SailOn");
            StopAllCoroutines();
            StartCoroutine(timer());
            isBlocked = true;
        }

    }
    public void SailsOff(){
        if (!isBlocked)
        {
            target.Action(command);
            print("hello world from SailOn");
            StopAllCoroutines();
            StartCoroutine(timer());
            isBlocked = true;
        }

    }

    public void ButtonTest(bool isGrabbed)
    {
        if (!isBlocked && isGrabbed)
        {
            animator.SetTrigger("buttonTrigger");
            target.Action(command);
            print("hello world");
            StopAllCoroutines();
            StartCoroutine(timer());
            isBlocked = true;
        }
    }

    IEnumerator timer()
    {
        yield return new WaitForSeconds(duration);
        isBlocked = false;
    }

}
