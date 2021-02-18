using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract class Pickables
{
    private string name;
    private bool isPicked;
    
    private List<IListener> listeners = new List<IListener>();

    // Constructor
    public Pickables(string in_name, bool in_isPicked)
    {
        name = in_name;
        isPicked = in_isPicked;

    }

    public void Attach(IListener listener)
    {
        listeners.Add(listener);
    }

    public void Detach(IListener listener)
    {
        listeners.Remove(listener);
    }

    public void Notify()
    {
        foreach (IListener listener in listeners)
        {
            listener.UpdateAchievement(this);
        }

        Debug.Log("Listeners Notified with picked item");
    }

    public void Achieved()
    {
        Notify();
    }

    public string Name
    {
        get { return name; }
    }

    public bool isPickedObject
    {
        get { return isPicked; }
    }


}

/*class WalkedAMile : Pickables
{
    public WalkedAMile() : base("walked a mile",
        "my character had walked a mile",
        1.5f) { }
}*/

class Key : Pickables {
    public Key() : base("SafeKey", true) {  }
    
}


interface IListener
{
    void UpdateAchievement(Pickables isPicked);
}

