using UnityEngine;

namespace GameProgrammingPattern.Observer
{
    public abstract class Observer:MonoBehaviour
    {
        public abstract void Notify(Subject subject);
    }// class
}// namespace