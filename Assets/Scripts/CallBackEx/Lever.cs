using UnityEngine;
using UnityEngine.Events;

public class Lever : MonoBehaviour
{
    public UnityEvent OnPulled;
    private bool isUsed = false;

    // Update is called once per frame
    void Update()
    {
        if (isUsed) return;

        if (Input.GetKeyDown(KeyCode.E))
        {
            isUsed = true;
            Debug.Log("레버를 당겼다.");
            OnPulled.Invoke();
        }
    }
}
