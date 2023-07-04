﻿using System.Collections.Generic;
using System.Linq;

namespace Tempest.UsefulStuff {
    public static class ListTools {
        public static void Subtract<T>(this List<T> list, List<T> valuesToRemove) {
            list.ToList().ForEach(value => {
                if (valuesToRemove.Contains(value)) {
                    list.Remove(value);
                }
            });
        }
    }
}