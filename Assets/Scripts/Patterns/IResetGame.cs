using System;
using UnityEngine;

namespace Patterns
{
    public abstract class IResetGame : MonoBehaviour
    {
        protected void Register()
        {
            GameManager.Instance.Register(this);
            Debug.Log("I've Registered, My Name is " + gameObject.name );
        }

        public virtual void ResetGame()
        {
            throw new NotImplementedException();
        }
        
        protected void DeRegister()
        {
            GameManager.Instance.DeRegister(this);
        }
    }
}