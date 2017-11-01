﻿namespace TensorSharp.Operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class BinaryOperation<T> : BaseNode<T>
    {
        private INode<T> left;
        private INode<T> right;
        private int rank;
        private int[] shape;

        public BinaryOperation(INode<T> left, INode<T> right)
        {
            if (!left.Shape.SequenceEqual(right.Shape))
                throw new InvalidOperationException();

            this.left = left;
            this.right = right;
            this.rank = left.Rank;
            this.shape = left.Shape;
        }

        public override int Rank { get { return this.rank; } }

        public override int[] Shape { get { return this.shape; } }

        public INode<T> Left { get { return this.left; } }

        public INode<T> Right { get { return this.right; } }

        public override T GetValue(params int[] coordinates)
        {
            throw new NotImplementedException();
        }
    }
}
