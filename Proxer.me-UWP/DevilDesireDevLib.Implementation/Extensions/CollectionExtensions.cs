﻿using System;
using System.Collections.Generic;
using System.Linq;
using DevilDesireDevLib.Interfaces.Entities;
using Template10.Utils;

namespace DevilDesireDevLib.Implementation.Extensions
{
    public static class CollectionExtensions
    {

        public static void UpdateWith<T, T1>(this ICollection<T> destination, IReadOnlyCollection<T1> updates, Func<T1, T> createFunc, Func<T, T1, bool> compareFunc) where T : IUpdatable<T1>
        {
            destination.Where(x => updates.All(y => !compareFunc(x, y))).ToArray().ForEach(x => destination.Remove(x));

            foreach (var update in updates)
            {
                var existingItem = destination.FirstOrDefault(x => compareFunc(x, update));
                if (existingItem == null)
                {
                    destination.Add(createFunc(update));
                }
                else
                {
                    existingItem.Update(update);
                }
            }
        }

        public static void UpdateByIndexWith<T, T1>(this IList<T> destination, IReadOnlyList<T1> updates, Func<T1, T> createFunc) where T : IUpdatable<T1>
        {
            var i = 0;
            for (; i < updates.Count; i++)
            {
                if (destination.Count > i)
                    destination[i].Update(updates[i]);
                else
                    destination.Add(createFunc(updates[i]));
            }

            for (; i < destination.Count; i++)
            {
                destination.RemoveAt(i);
            }
        }
    }
}