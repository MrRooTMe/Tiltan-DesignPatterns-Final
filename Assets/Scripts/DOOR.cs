using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DOOR : MonoBehaviour
{

    public Item Key;
    bool canBeOpen;
    public UnityEvent DoorOpened;

    public Animator animations;

    void OpenDoor()
    {
        DoorOpened.Invoke();
    }
    // Start is called before the first frame update
    void Start()
    {
        canBeOpen = false;
        Key.ItemCollected.AddListener(OnKeyCollected);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnKeyCollected()
    {
        canBeOpen = true;
    }

    private void OnMouseDown()
    {
        Debug.Log("OnMouseDown");
        Debug.Log(canBeOpen);
        if (canBeOpen)
        {
            Debug.Log(animations.GetBool("CanBeOpen"));
            animations.SetBool("CanBeOpen", !animations.GetBool("CanBeOpen"));
            if (animations.GetBool("CanBeOpen"))
                OpenDoor();
        }
    }
}
