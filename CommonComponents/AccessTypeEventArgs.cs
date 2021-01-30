using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonComponents
{
    public class AccessTypeEventArgs : IAccessTypeEventArgs
    {
        private AccesType _accesType;
        private bool _valuesWereChanged;

        public enum AccesType
        {
            Read,
            Add,
            Update,
            Delete
        }

        public bool ValuesWereChanged
        {
            get { return _valuesWereChanged; }
            set { _valuesWereChanged = value; }
        }

        public AccesType AccesTypeValue
        {
            get { return _accesType; }
            set { _accesType = value; }
        }
    }
}
