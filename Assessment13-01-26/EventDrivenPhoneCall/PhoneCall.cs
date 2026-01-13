using System;

namespace EventDrivenPhoneCall;

public class PhoneCall
{
    public string Message{ get; private set; }

    public delegate void Notify();

    public event Notify PhoneCallEvent;

    private void OnSubscribe()
    {
        Message = "Subscribed to call";
    }

    private void UnSubscribe()
    {
        Message = "Unsubscribed to call";
    }

    public void MakeAPhoneCall(bool Notify)
    {
        
        if(Notify)
        {
            PhoneCallEvent += OnSubscribe;
        }
        else
        {
            PhoneCallEvent += UnSubscribe;
        }

        PhoneCallEvent.Invoke();
    }  
}
