using Sirenix.OdinInspector;

namespace Deadbit.Variables
{
    public class GenericValueComponent<T> : SerializedMonoBehaviour, IGenericValue<T>
    {
        [HideReferenceObjectPicker]
        public GenericValue<T> Variable = new GenericValue<T>();

        public bool IsVariableReference => Variable.UseReference;

        [ShowInInspector]
        public T Value => Variable.Value;
    }
}