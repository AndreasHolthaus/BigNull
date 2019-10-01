namespace Nullcheck
{
    /// <summary>
    /// BigNull class
    /// </summary>
    public class BigNull
    {
        /// <summary>
        /// Event
        /// </summary>
        public event EventHandler BigNullEvent;

        /// <summary>
        /// Event handler
        /// Check for NULL with the Elvis-Operator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnBigNull(object sender, EventArgs e)
        {
            BigNullEvent?.Invoke(sender, e);
        }

        /// <summary>
        /// Check for NULL with the Elvis-Operator 2
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public string GetStringFromObject(object o) => o?.ToString();

        /// <summary>
        /// classic code
        /// if o == null then return true else return false
        /// </summary>
        /// <param name="o">the object</param>
        /// <returns></returns>
        public Boolean IsNullClassic(object o)
        {
            if (o == null)
                return true;
            else
                return false;
        }

        /// <summary>
        /// using the ternary operator ?:
        /// if o == null then return true else return false
        /// and expression bodied function
        /// </summary>
        /// <param name="o">the object</param>
        /// <returns></returns>
        public Boolean IsNullTernary(object o) => o == null ? true : false;

        /// <summary>
        /// generic method using the ternary operator ?:
        /// if o == null then return new T else return T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="o"></param>
        /// <returns></returns>
        public T SaveObjectInstance<T>(T o) where T : new() => o == null ? new T() : o;

        /// <summary>
        /// Check Null with nullcoalescing ??
        /// return o if not null, else return new object
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public object SaveObjectInstance(object o) => o ?? new object();

        /// <summary>
        /// Save object instance
        /// </summary>
        /// <typeparam name="T">the type of object</typeparam>
        /// <param name="o">the object</param>
        /// <returns>new object if argument is null, else the argument object</returns>
        public T SaveObjectTypeInstance<T>(T o) where T : new() => o == null ? new T() : o;

        /// <summary>
        /// Delegate for Null checking
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public delegate Boolean IsNullHandler<T>(T obj);

        /// <summary>
        /// Check Null with Lambda expression
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="o"></param>
        /// <returns></returns>
        public static Boolean IsNullLambda<T>(T o) where T : new()
        {
            IsNullHandler<T> IsNull;
            IsNull = obj => obj == null ? true : false;
            return IsNull(o);
        }
    }
}
