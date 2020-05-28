using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tinker
{
    /// <summary>
    /// Base for a custom Button class so we can add functionalities like cooldown etc.
    /// </summary>
    public class TButton<T> : MonoBehaviour
    {
        public System.Action<T> Callback;
        internal T m_genericMember;

        internal float m_ButtonCooldown { get; set; } = 30f;
        float m_LastTimeButtonPushed;

        internal void Init()
        {
            m_LastTimeButtonPushed = m_ButtonCooldown * -1;
        }

        /// <summary>
        /// The method to be called by OnClickListeners.
        /// </summary>
        public void Execute()
        {
         
            if (Time.time - m_LastTimeButtonPushed < m_ButtonCooldown) return;

            if(Callback != null)
            {
                Callback.Invoke(m_genericMember);
            }
            m_LastTimeButtonPushed = Time.time;
        }
    }
}