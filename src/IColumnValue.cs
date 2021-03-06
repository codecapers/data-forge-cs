﻿using System;

namespace DataForge
{
    /// <summary>
    /// Represents a row in a column.
    /// </summary>
    public interface IColumnValue
    {
        /// <summary>
        /// Interpret the column value as a string.
        /// </summary>
        IStringValue AsString();
    }

    /*fio:
    /// <summary>
    /// Represents a row in a column.
    /// </summary>
    public struct ColumnRow<T> : IColumnRow
    {
        /// <summary>
        /// The value in this row of the column.
        /// </summary>
        private T value;

        public ColumnRow(T value)
        {
            this.value = value;
        }

        /// <summary>
        /// Retrieve the value in the row.
        /// </summary>
        public TT As<TT>()
        {
            return (TT)(object)value;
        }

        /// <summary>
        /// Convert the value to a string.
        /// </summary>
        new public string ToString()
        {
            return value.ToString();
        }
    }
    */
}