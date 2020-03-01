using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Events;

namespace Deadbit.Variables
{
    public class GenericVariableComponent<T, T2> : SerializedMonoBehaviour, IGenericVariableWithEvent<T> where T2 : UnityEvent<T>
    {
        [HideReferenceObjectPicker, BoxGroup("Variable"), HideLabel]
        public GenericVariable<T> Variable = new GenericVariable<T>();

        public bool IsVariableReference => Variable.UseReference;

        private bool VariableConstantAndEmitEvent => IsVariableReference && emitUnityEvent;
#pragma warning disable 649
        [BoxGroup("Events"), SerializeField]
        private bool emitUnityEvent;

        [BoxGroup("Events"), SerializeField, ShowIf("emitUnityEvent")]
        private T2 valueChanged;
#pragma warning restore 649

        public T Value
        {
            get
            {
                return Variable.Value;
            }

            set
            {
                Variable.Value = value;

                if (emitUnityEvent)
                {
                    EmitEvent();
                }
            }
        }

        [BoxGroup("Events"), Button(ButtonSizes.Medium)]
        protected virtual void EmitEvent()
        {
            valueChanged.Invoke(Variable.Value);
        }

        public UnityEvent<T> ValueChanged => valueChanged;
    }
}