using System.Reflection;
using System.Text;

namespace JS.NET
{
    public class Caches
    {
        private StringBuilder sb = new($"window.{MethodBase.GetCurrentMethod()?.DeclaringType?.Name.ToLower()}");
        /// <summary>
        /// 加入其他材料
        /// </summary>
        /// <returns></returns>
        public Caches Open(string param)
        {
            sb.Append($".{MethodBase.GetCurrentMethod()?.Name.ToLower()}('{param}')");
            return this;
        }
        public string End()
        {
            return sb.ToString();
        }
    }

    public class Console
    {
        private StringBuilder sb = new($"window.{MethodBase.GetCurrentMethod()?.DeclaringType?.Name.ToLower()}");
        /// <summary>
        /// 加入其他材料
        /// </summary>
        /// <returns></returns>
        public Console Log(string param)
        {
            sb.Append($".{MethodBase.GetCurrentMethod()?.Name.ToLower()}('{param}')");
            return this;
        }
        public string End()
        {
            return sb.ToString();
        }
    }

    public static class WindowJS
    {
        private static readonly string instance = "window";

        #region Properties
        public static string Name(string param) => $"{instance}.{MethodBase.GetCurrentMethod()?.Name.ToLower()}={param}";
        public static string Name() => $"{instance}.{MethodBase.GetCurrentMethod()?.Name.ToLower()}";

        public static Caches Caches { get; set; } = new Caches();
        public static Console Console { get; set; } = new Console();
        #endregion

        #region Method
        public static string Open(string param) => $"{instance}.{MethodBase.GetCurrentMethod()?.Name.ToLower()}('{param}')";

        /// <summary>
        /// window.alert() instructs the browser to display a dialog with an optional message, and to wait until the user dismisses the dialog
        /// Under some conditions — for example, when the user switches tabs — the browser may not actually display a dialog, or may not wait for the user to dismiss the dialog.
        /// </summary>
        /// <param name="param">A string you want to display in the alert dialog, or, alternatively, an object that is converted into a string and displayed.</param>
        /// <returns>None undefined</returns>
        public static string Alert(string param) => $"{instance}.{MethodBase.GetCurrentMethod()?.Name.ToLower()}('{param}')";

        /// <summary>
        /// The atob() method of the Window interface decodes a string of data which has been encoded using Base64 encoding. You can use the Window.btoa() method to encode and transmit data which may otherwise cause communication problems, then transmit it and use the atob() method to decode the data again. For example, you can encode, transmit, and decode control characters such as ASCII values 0 through 31.
        /// </summary>
        /// <param name="param">A binary string (i.e., a string in which each character in the string is treated as a byte of binary data) containing base64-encoded data.</param>
        /// <returns>An ASCII string containing decoded data from encodedData.</returns>
        public static string Atob(string param) => $"{instance}.{MethodBase.GetCurrentMethod()?.Name.ToLower()}('{param}')";
        /// <summary>
        /// The btoa() method of the Window interface creates a Base64-encoded ASCII string from a binary string (i.e., a string in which each character in the string is treated as a byte of binary data).You can use this method to encode data which may otherwise cause communication problems, transmit it, then use the Window.atob() method to decode the data again.For example, you can encode control characters such as ASCII values 0 through 31.
        /// </summary>
        /// <param name="param">The binary string to encode.</param>
        /// <returns>An ASCII string containing the Base64 representation of stringToEncode.</returns>
        public static string Btoa(string param) => $"{instance}.{MethodBase.GetCurrentMethod()?.Name.ToLower()}('{param}')";
        /// <summary>
        /// The obsolete and non-standard method back() on the window interface returns the window to the previous item in the history. This was a Firefox-specific method and was removed in Firefox 31.
        /// </summary>
        /// <returns></returns>
        public static string Back() => $"{instance}.{MethodBase.GetCurrentMethod()?.Name.ToLower()}()";
        /// <summary>
        /// The Window.blur() method does nothing.
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public static string Blur() => $"{instance}.{MethodBase.GetCurrentMethod()?.Name.ToLower()}()";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public static string CancelAnimationFrame(string param) => $"{instance}.{MethodBase.GetCurrentMethod()?.Name.ToLower()}({param})";
        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public static string CancelIdleCallback(string param) => $"{instance}.{MethodBase.GetCurrentMethod()?.Name.ToLower()}({param})";

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string Close() => $"{instance}.{MethodBase.GetCurrentMethod()?.Name.ToLower()}()";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public static string Confirm(string param) => $"{instance}.{MethodBase.GetCurrentMethod()?.Name.ToLower()}({param})";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public static string Dump(string param) => $"{instance}.{MethodBase.GetCurrentMethod()?.Name.ToLower()}('{param}')";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aString"></param>
        /// <param name="aCaseSensitive"></param>
        /// <param name="aBackwards"></param>
        /// <param name="aWrapAround"></param>
        /// <param name="aWholeWord"></param>
        /// <param name="aSearchInFrames"></param>
        /// <param name="aShowDialog"></param>
        /// <returns></returns>
        public static string Find(string aString, bool aCaseSensitive, bool aBackwards, bool aWrapAround, bool aWholeWord, bool aSearchInFrames, bool aShowDialog)
            => $"{instance}.{MethodBase.GetCurrentMethod()?.Name.ToLower()}('{aString}', {aCaseSensitive}, {aBackwards}, {aWrapAround}, {aWholeWord}, {aSearchInFrames}, {aShowDialog})";

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string Focus() => $"{instance}.{MethodBase.GetCurrentMethod()?.Name.ToLower()}()";

        public static string GetComputedStyle(string element) => $"{instance}.{MethodBase.GetCurrentMethod()?.Name.ToLower()}('{element}')";

        public static string GetComputedStyle(string element, string pseudoElt) => $"{instance}.{MethodBase.GetCurrentMethod()?.Name.ToLower()}('{element}','{pseudoElt}')";

        #endregion
    }

    public enum CacheStorage
    {
        Delete,
        Has,
        Keys,
        Match,
        Open
    }
}
