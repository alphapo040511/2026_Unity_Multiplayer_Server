using System;
using UnityEngine;

public class MyButton : MonoBehaviour
{
    public Action OnPressed;                        // 버튼 눌림 액션을 선언한다.

    private bool canPress = true;

    // Update is called once per frame
    void Update()
    {
        if (!canPress) return;

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("버튼을 눌렀다.");
            canPress = false;
            OnPressed.Invoke();                     // 버튼이 눌리면 Action을 호출 한다.
        }
    }
}
