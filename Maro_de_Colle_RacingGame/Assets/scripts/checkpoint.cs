using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour
{

    public bool IsChecked = false;
    private void OnTriggerEnter(Collider other)
    {
        IsChecked = true;
    }
    public void Reset()
    {
        IsChecked = false;
    }
}
