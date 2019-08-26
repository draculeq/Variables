using Sirenix.OdinInspector;
using UnityEngine;

namespace Deadbit.Variables.Generic
{
    public class GenericValue<T> : IGenericValue<T>
    {
        [HideLabel, ValueDropdown("ReferenceDropDown")]
        public bool UseReference = false;

        [HideIf("UseReference"), OnValueChanged("CheckReferenceValue"), HideLabel]
        public T LocalValue;

        [SerializeField, ShowIf("UseReference"), HideLabel, HideReferenceObjectPicker]
        public IGenericValue<T> Variable;
        
        public T Value => !UseReference ? LocalValue : (Variable == null ? default : Variable.Value);

        public GenericValue() { }

        public GenericValue(T localValue)
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
    }
}