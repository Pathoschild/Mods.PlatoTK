﻿using PlatoTK.UI.Components;

namespace PlatoTK.UI
{
    internal class DrawInstructionHandle : IDrawInstructionsHandle
    {
        public IDrawInstruction Instructions { get; }

        public IComponent Component { get; }

        public IComponent Parent { get; }

        public DrawInstructionHandle(IDrawInstruction instructions, IComponent component, IComponent parent)
        {
            Instructions = instructions;
            Component = component;
            Parent = parent;
        }
    }
}
