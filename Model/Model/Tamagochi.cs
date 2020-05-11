using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Tamagochi
    {
        #region Parameters
        private Dictionary<ParameterType, int> _parameters = new Dictionary<ParameterType, int>();
        public event Action<ParameterType, int, int> OnParamsChanged = delegate { };

        public void SetParameter(ParameterType type, int value)
        {
            OnParamsChanged(type, _parameters[type], value);
            _parameters[type] = value;
        } 

        public int GetParameter(ParameterType type)
        {
            return _parameters[type];
        }
        #endregion

        #region Status
        private Status _status;
        public event Action<Status> OnStatusChanged = delegate { };

        public void SetStatus(Status value)
        {
            _status = value;
        }

        public Status GetStatus()
        {
            return _status;
        }
        #endregion

        public Tamagochi()
        {
            SetStatus(Status.Idle);
            foreach (ParameterType item in Enum.GetValues(typeof(ParameterType)))
            {
                _parameters[item] = 0;
            }
        }

        public void Init()
        {
            foreach (ParameterType item in Enum.GetValues(typeof(ParameterType)))
            {
                SetParameter(item, 50);
            }
        }

    }
}
