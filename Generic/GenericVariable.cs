using System;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Deadbit.Variables
{
    [Serializable]
    public class GenericVariable<T> : IGenericVariable<T>
    {
        [HideLabel, ValueDropdown("ReferenceDropDown")]
        public bool UseReference = false;

        [HideIf("UseReference"), OnValueChanged("CheckReferenceValue"), HideLabel]
        public T LocalValue;

        [SerializeField, ShowIf("UseReference"), HideLabel, HideReferenceObjectPicker]
        public IGenericVariable<T> Variable;


        [ShowInInspector, ShowIf("UseReference"), LabelText("Referenced Value")]
        public T Value
        {
            get => !UseReference ? LocalValue : (Variable == null ? default(T) : Variable.Value);

            set
            {
                if (!UseReference)
                    LocalValue = value;
                else if (Variable != null)
                    Variable.Value = value;
            }
        }

        public GenericVariable() { }

        public GenericVariable(T localValue)
        {
            LocalValue = localValue;
        }

        protected virtual void CheckReferenceValue() { }

        private ValueDropdownList<bool> ReferenceDropDown =>
            new ValueDropdownList<bool>()
            {
                {"Value", false},
                {"Reference", true}
            };

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}