using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    static class PetStatusChanges
    {
        public static Dictionary<Status, Dictionary<ParameterType, int>> Delta = new Dictionary<Status, Dictionary<ParameterType, int>>()
        {
            [Status.Idle] = new Dictionary<ParameterType, int>()
            {
                [ParameterType.Energy] = -1,
                [ParameterType.Hunger] = -1,
                [ParameterType.Walk] = -1,
                [ParameterType.Mood] = -3
            },
            [Status.Eating] = new Dictionary<ParameterType, int>()
            {
                [ParameterType.Energy] = +3,
                [ParameterType.Hunger] = +2,
                [ParameterType.Walk] = -1,
                [ParameterType.Mood] = +1
            },
            [Status.Playing] = new Dictionary<ParameterType, int>()
            {
                [ParameterType.Energy] = -3,
                [ParameterType.Hunger] = -2,
                [ParameterType.Walk] = -1,
                [ParameterType.Mood] = +3
            },
            [Status.Sleeping] = new Dictionary<ParameterType, int>()
            {
                [ParameterType.Energy] = +3,
                [ParameterType.Hunger] = -1,
                [ParameterType.Walk] = -1,
                [ParameterType.Mood] = +1
            },
            [Status.Walking] = new Dictionary<ParameterType, int>()
            {
                [ParameterType.Energy] = -2,
                [ParameterType.Hunger] = -2,
                [ParameterType.Walk] = +3,
                [ParameterType.Mood] = +2
            }
        }; 
    }
}
