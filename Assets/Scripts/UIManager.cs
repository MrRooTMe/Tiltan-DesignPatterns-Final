using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Item Key1;
    public Item Key2;
    public Item Key3;

    public DOOR Door1;
    public DOOR Door2;
    public DOOR Door3;
    Text text;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        Key1.ItemCollected.AddListener(OnKeyCollected);
        Key2.ItemCollected.AddListener(OnKeyCollected);
        Key3.ItemCollected.AddListener(OnKeyCollected);

        Door1.DoorOpened.AddListener(OnDoorOpened);
        Door2.DoorOpened.AddListener(OnDoorOpened);
        Door3.DoorOpened.AddListener(OnDoorOpened);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnKeyCollected()
    {
     text.text = "Key Collected";
    }
    void OnDoorOpened()
    {
        text.text = "Door Opened";
    }
}
