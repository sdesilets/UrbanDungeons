using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets
{
    public class CharacterBase
    {

        public String Name { get; set; }

        private Stat m_Strength, m_Dexterity, m_Intelligence, m_Health;
        private float m_BasicLift, m_BasicSpeed;
        private int m_BasicSpeedRounded, m_Dodge, m_BasicMove;

        private Range m_ThrustDamage, m_SwingDamage;
        
        public Stat Strength {
            get { return m_Strength; }
            set {
                // todo: load damage table.
                // hack: damage table assumes 10 STR. 
                m_ThrustDamage = new Range();
                m_ThrustDamage.Min = 0;
                m_ThrustDamage.Max = 4;

                m_SwingDamage = new Range();
                m_SwingDamage.Min = 0;
                m_SwingDamage.Max = 6;

                HitPoints = value.Value * 2;

                SetBasicLift();

                m_Strength = value;
            }
        }

        public Stat Dexterity {
            get { return m_Dexterity; }
            set {
                m_Dexterity = value;
                InternalSetBasicSpeed();
            }
        }

        public Stat Intelligence {
            get { return m_Intelligence; }
            set {
                Will = value.Value;
                Perception = value.Value;
                m_Intelligence = value;
            }
        }

        public Stat Health {
            get { return m_Health; }

            set {
                HitPoints = value.Value;
                m_Health = value;
                InternalSetBasicSpeed();
            }
        }

        public int HitPoints { get; set; }
        public int Will { get; set; }
        public int Perception { get; set; }
        public int Fatigue { get; set; }

        public Range ThrustDamage { get { return m_ThrustDamage; } }
        public Range SwingDamage { get { return m_SwingDamage; } }

        public float BasicLift {
            get {
                return m_BasicLift;
            }
        }

        private void SetBasicLift() {
            m_BasicLift = Strength.Value * Strength.Value / 5;
        }

        public float BasicSpeed {
            get { return m_BasicSpeed; }
        }

        private void InternalSetBasicSpeed() {
            m_BasicSpeed = (Health.Value + Dexterity.Value) / 4;
            m_BasicSpeedRounded = (int)m_BasicSpeed;
            m_Dodge = m_BasicSpeedRounded + 3;
            m_BasicMove = m_BasicSpeedRounded;
        }

        public int Dodge {
            get {
                return m_Dodge;
            }
        }

        public int BasicMove {
            get {
                return m_BasicMove;
            }
        }

        private CharacterBase m_Target;
        public CharacterBase Target { 
            get { return m_Target; } 
            set { m_Target = value; } 
        }

        public void Attack() {
			
/*			if (m_Target != null && m_Target)
			{
			}*/

        }

    }
}
