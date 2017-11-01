﻿namespace TensorSharp.Operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class SubtractDoubleOperation : BinaryOperation<double>
    {
        public SubtractDoubleOperation(INode<double> left, INode<double> right)
            : base(left, right)
        {
        }


        public override void Calculate(double[] newvalues, double[] leftvalues, double[] rightvalues)
        {
            int l = newvalues.Length;

            for (int k = 0; k < l; k++)
                newvalues[k] = leftvalues[k] - rightvalues[k];
        }
    }
}
