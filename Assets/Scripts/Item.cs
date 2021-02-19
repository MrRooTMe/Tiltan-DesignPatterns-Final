using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Item : MonoBehaviour
{

    //Key
    public UnityEvent ItemCollected;

    void ColletItem()
    {
        ItemCollected.Invoke();

    }
    private void OnMouseDown()
    {
        ColletItem();
    }
}
