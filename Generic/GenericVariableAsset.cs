using System;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Events;

namespace Deadbit.Variables
{
    public enum VariableChangePermission
    {
        FORBIDDEN,
        ALLOW,
        ALLOW_TEMPORARY
    }

    [Serializable]
    public class GenericVariableAsset<T, TEvent> : SerializedScriptableObject, IGenericVariableWithEvent<T> where TEvent : UnityEvent<T>
    {

        [HideLabel, ValueDropdown("ReferenceDropDown")]
        public bool UseReference = false;

        [HideIf("UseReference"), OnValueChanged("CheckReferenceValue"), HideLabel]
        public T LocalVariable;
        private T cachedVariable;

#pragma warning disable 649
        [SerializeField, ShowIf("UseReference"), HideLabel, HideReferenceObjectPicker]
        private IGenericVariable<T> variable;

        [BoxGroup("Events"), SerializeField]
        private bool emitUnityEvent;

        [BoxGroup("Events"), SerializeField, ShowIf("emitUnityEvent")]
        private TEvent valueChanged;
#pragma warning restore 649

        [BoxGroup("Options"), HideIf("UseReference"), SerializeField]
        private VariableChangePermission variableChangePermission = VariableChangePermission.ALLOW;

#pragma warning disable 649
        [BoxGroup("Options"), SerializeField]
        private bool logValueChange;
#pragma warning restore 649
        
        [SerializeField,BoxGroup("Options"),ShowIf("ChangePermission",VariableChangePermission.ALLOW_TEMPORARY)]
        private T defaultVariable;

        protected virtual void ChangeCachedValue()
        {
            cachedVariable = LocalVariable;
        }

        public T GetValue()
        {
            return Value;
        }

        public TEvent ValueChanged { get { return valueChanged; } }

        
        public VariableChangePermission ChangePermission
        {
            get { return variableChangePermission; }
            set { variableChangePermission = value; }
        }

        public virtual T Value
        {
            get
            {

                if (UseReference)
                    return this.variable.Value;
                else
                    return LocalVariable;
            }
            set
            {
                if (logValueChange)
                {
                    Debug.LogFormat(this, "Value change was requested on {0}", name);
                }

                if (ChangePermission == VariableChangePermission.FORBIDDEN)
                {
                    Debug.LogError("You are trying to change the value of a variable that was marked FORBIDDEN");
                    return;
                }

                if (UseReference)
                    this.variable.Value = value;
                else
                    LocalVariable = value;

                if (!Equals(value, this.variable))
                    if (emitUnityEvent)
                        InvokeValueChangedEvents();

            }
        }

        UnityEvent<T> IGenericVariableWithEvent<T>.ValueChanged => ValueChanged;
        

        public void OnEnable()
        {
            if (ChangePermission == VariableChangePermission.ALLOW_TEMPORARY)
            {
                LocalVariable = defaultVariable;
            }
        }

        public void OnDisable()
        {
            if (ChangePermission == VariableChangePermission.ALLOW_TEMPORARY)
            {
                cachedVariable = defaultVariable;
            }
        }

        protected virtual void InvokeValueChangedEvents()
        {
            ValueChanged?.Invoke(Value);
        }

        protected virtual void CheckReferenceValue()
        {
        }

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