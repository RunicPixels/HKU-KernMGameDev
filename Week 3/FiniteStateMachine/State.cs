using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiniteStateMachine {
    abstract class State {
        void Start() { }
        void Run() { }
        void Complete() { }
    }
}
