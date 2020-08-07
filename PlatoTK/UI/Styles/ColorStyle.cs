﻿using Microsoft.Xna.Framework;
using PlatoTK.UI.Components;
using System;

namespace PlatoTK.UI.Styles
{
    public class ColorStyle : Style
    {
        public Color TextColor { get; set; } = Color.White;

        public ColorStyle(IPlatoHelper helper, string option = "")
            : base(helper,option)
        {

        }

        public override IStyle New(IPlatoHelper helper, string option = "")
        {
            return new ColorStyle(helper, option);
        }

        public override void Apply(IComponent component)
        {
            if (component is TextComponent text)
                text.Color = TextColor;

            base.Apply(component);
        }

        public override string[] PropertyNames => new string[] { "TextColor" };

        public override void Parse(string property, string value, IComponent component)
        {
            if (property.ToLower() == "textcolor" && component is TextComponent text && Helper.Content.Textures.TryParseColorFromString(value, out Color color))
                TextColor = color;

        }
    }
}
