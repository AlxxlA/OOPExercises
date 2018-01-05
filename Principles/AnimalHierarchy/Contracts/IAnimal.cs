using System;
using AnimalHierarchy.Common;

namespace AnimalHierarchy.Contracts
{
    public interface IAnimal : ISound
    {
        string Name { get; }

        int Age { get; }

        Gender Gender { get; }
    }
}