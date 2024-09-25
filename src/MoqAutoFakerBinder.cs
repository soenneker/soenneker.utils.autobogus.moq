using System;
using Moq;
using Soenneker.Reflection.Cache.Methods;
using Soenneker.Reflection.Cache.Types;
using Soenneker.Utils.AutoBogus.Context;

namespace Soenneker.Utils.AutoBogus.Moq;

/// <summary>
/// An AutoFakerBinder for interfaces and abstract objects using Moq
/// </summary>
public class MoqAutoFakerBinder : AutoFakerBinder
{
    private CachedMethod? _ofMethod;

    public override TType? CreateInstance<TType>(AutoFakerContext context, CachedType cachedType) where TType : default
    {
        if (cachedType.IsInterface || cachedType.IsAbstract)
        {
            if (_ofMethod == null)
            {
                CachedType mockType = context.CacheService.Cache.GetCachedType(typeof(Mock));
                _ofMethod = mockType.GetCachedMethod("Of", Type.EmptyTypes);
            }

            CachedMethod? ofGenericMethod = _ofMethod!.MakeCachedGenericMethod(cachedType);

            return (TType)ofGenericMethod!.Invoke(null, []);
        }

        return base.CreateInstance<TType>(context, cachedType);
    }
}