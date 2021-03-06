﻿using System;
using System.Collections.Generic;

namespace EPII.Test
{
    public abstract class Test
    {
        protected int _Index = 0;
        protected List<Action> _Actions 
            = new List<Action>();

        public abstract string Id { get; }

        public abstract void Prepare();

        public void AddAction(Action action) 
        {
            _Actions.Add(action);
        }

        public void Reset() 
        {
            _Index = 0;
        }

        public bool HasNext()
        {
            return _Actions.Count != 0 && _Index != -1;
        }

        public void MoveNext() 
        {
            _Index++;
            if (_Index == _Actions.Count)
                _Index = -1;
        }

        public void Perform() 
        {
            _Actions[_Index]();
        }
    }
}
