﻿using Microsoft.Xna.Framework;
using PlatoTK.UI.Components;
using System;
using System.Collections.Generic;

namespace PlatoTK.UI.Styles
{
    public interface IStyle : IDisposable
    {
        int Priority { get; set; }
        string Option { get; }
        string[] PropertyNames { get; }

        void Parse(string property, string value, IComponent component);
        bool ShouldApply(IComponent component);
        void Apply(IComponent component);
        void Update(IComponent component);

        IStyle New(IPlatoHelper helper, string option = "");
    }

    public interface IDrawStyle : IStyle
    {
        IEnumerable<Color> Render(IComponent component, IComponent parent, IEnumerable<Color> render);
    }
}
