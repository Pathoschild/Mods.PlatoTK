﻿using Harmony;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PlatoTK.Harmony
{
    public interface IHarmonyHelper
    {
        HarmonyInstance HarmonyInstance { get; }
        bool LinkObjects(object original, object target);

        void LinkTypes(Type originalType, Type targetType, object targetForAllInstances = null);

        void UnlinkObjects(object original, object target = null);

        void LinkContruction<TOriginal, TTarget>();

        bool TryGetLink(object linkedObject, out object target);

        void PatchTileDraw(string id, Func<Texture2D> targetTexture, Texture2D patch, Rectangle? sourceRectangle, int index, int tileWidth = 16, int tileHeight = 16);

        void PatchTileDraw(string id, Func<Texture2D> targetTexture, Texture2D patch, Rectangle? sourceRectangle, Func<int> getIndex, int tileWidth = 16, int tileHeight = 16);

        void PatchAreaDraw(string id, Func<Texture2D> targetTexture, Texture2D patch, Rectangle? sourceRectangle, Rectangle? targetTileArea);
        void PatchAreaDraw(string id, Func<Texture2D> targetTexture, Texture2D patch, Rectangle? sourceRectangle, Func<Rectangle> getTargetTileArea);

        void RemoveDrawPatch(string id);

        bool ForwardMethodVoid(object __instance, MethodInfo __originalMethod, params object[] args);

        bool ForwardMethod(ref object __result, object __instance, MethodInfo __originalMethod, params object[] args);

        Texture2D GetDrawHandle(string id, Func<ITextureDrawHandler, bool> handler, Texture2D texture);

        Texture2D GetDrawHandle(string id, Func<ITextureDrawHandler, bool> handler, int width, int height, GraphicsDevice graphicsDevice = null);

        Texture2D GetDrawHandle<TData>(string id, TData data, Func<ITextureDrawHandler<TData>, bool> handler, Texture2D texture);

        Texture2D GetDrawHandle<TData>(string id, TData data, Func<ITextureDrawHandler, bool> handler, int width, int height, GraphicsDevice graphicsDevice = null);

        void RegisterTileAction(ITileAction tileAction);

        void RegisterTileAction(Action<ITileActionTrigger> handler, params string[] trigger);
    }
}
