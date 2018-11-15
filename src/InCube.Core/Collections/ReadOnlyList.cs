﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace InCube.Core.Collections
{
    /// <summary>
    /// Wraps an <see cref="IList{T}"/> into an <see cref="IReadOnlyList{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of the list.</typeparam>
    public readonly struct ReadOnlyList<T> : IReadOnlyList<T>, IEquatable<ReadOnlyList<T>>
    {
        private readonly IList<T> wrapped;

        public ReadOnlyList(IList<T> wrapped)
        {
            this.wrapped = wrapped;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.wrapped.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.wrapped.GetEnumerator();
        }

        public int Count => this.wrapped.Count;

        public T this[int index] => this.wrapped[index];

        public bool Equals(ReadOnlyList<T> other) => 
            Equals(this.wrapped, other.wrapped);

        public override bool Equals(object obj) => 
            obj is ReadOnlyList<T> other && Equals(other);

        public override int GetHashCode() => 
            this.wrapped?.GetHashCode() ?? 0;

        public static bool operator ==(ReadOnlyList<T> left, ReadOnlyList<T> right) => 
            left.Equals(right);

        public static bool operator !=(ReadOnlyList<T> left, ReadOnlyList<T> right) => 
            !left.Equals(right);
    }
}