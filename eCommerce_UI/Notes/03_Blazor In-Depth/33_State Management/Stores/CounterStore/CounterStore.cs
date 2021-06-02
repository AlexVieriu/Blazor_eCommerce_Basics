using System;

namespace eCommerce_UI.Notes.Stores.CounterStore
{       
    public class CounterStore
    {
        // here we store the State of the component
        private CounterState _state;

        // the store constructor initialize the default State with 0 when the CounterStore is injected into the razor page
        public CounterStore()
        {
            _state = new CounterState(0);
        }      

        public void IncrementCount()
        {
            // create a variable and take the value of the current state
            var count = this._state.Count;            
            count++;
            // initialized the state with the count++
            this._state = new CounterState(count);
            BroadcastStateChange();
        }

        public void DecrementCount()
        {
            var count = this._state.Count;
            count--;
            this._state = new CounterState(count);
            BroadcastStateChange();
        }

        public CounterState GetState()
        {
            return _state;
        }

        #region observer pattern

        // encapsulate a method that has no parameters and does not return a value
        private Action _listeners;

        // register the liseners
        public void AddStateChangeListeners(Action listener)
        {
            _listeners += listener;
        }

        public void RemoveStateChangeListeners(Action listener)
        {
            _listeners -= listener;
        }

        public void BroadcastStateChange()
        {
            _listeners.Invoke();
        }

        #endregion
    }

    // another class
    public class CounterState
    {
        public int Count { get; }

        public CounterState(int count)
        {
            Count = count;
        }
    }
}
