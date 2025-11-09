using UnityEngine;

public class testing : MonoBehaviour
{ int number = 5;
    void Start()
    {
        if (number > 6)
        {
            Debug.Log("Number is greater than 6");
        }
        else
        {
            Debug.Log("Number is 6 or less");
        }
    }
}
