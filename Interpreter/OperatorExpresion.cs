using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class OperatorExpression : IExpression
    {
        private string _operation;

        public OperatorExpression(string token)
        {
            _operation = token;
        }

        public void interpret(Context context)
        {
            context.setOperation(_operation);
        }
    }
}
