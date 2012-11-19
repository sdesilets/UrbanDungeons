using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets
{
    public class OnChangedValueEventArgs : EventArgs
    {
        public int OldValue;
    }

    public class Stat
    {

        private int m_value;

        public delegate void OnChangedValueEventHandler(object sender);

        public event OnChangedValueEventHandler OnChangedValue;

        public StatTypes StatType { get; set; }
        public int Value {
            get { return m_value; }
            set {
                m_value = value;
                ChangedValue();
            }
        }

        protected void ChangedValue()
        {
            if (OnChangedValue  != null)
            {
                OnChangedValue(this);
            }

        }


    }
}
